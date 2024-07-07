using Restaurant_AP_Project.Model;
using Restaurant_AP_Project.Veiw;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace Restaurant_AP_Project.Control
{
    /// <summary>
    /// Interaction logic for CustomerFoodPageControl.xaml
    /// </summary>
    public partial class CustomerFoodPageControl : UserControl
    {
        private Comment tmpComment;
        private bool isEditFlag = false;

        #region Properties
        public double CustomerRate { get; set; } = -1;

            public string FoodNameText
            {
                get { return txtFoodName.Text; }
                set { txtFoodName.Text = value; }
            }

            public float FoodRate
            {
                get { return float.Parse(uinfoRate.BoxText); }
                set { uinfoRate.txtBox.Text = value.ToString("0.00"); }
            }

            public int FoodInventory
            {
                get { return int.Parse(uinfoFoodInventory.BoxText); }
                set { uinfoFoodInventory.txtBox.Text = value.ToString(); }
            }

            public string FoodRawMaterial
            {
                get { return uinfoRawMaterial.BoxText; }
                set { uinfoRawMaterial.txtBox.Text = value.ToString(); }
            }

            public double FoodPrice
            {
                get { return float.Parse(uinfoPrice.BoxText); }
                set { uinfoPrice.txtBox.Text = value.ToString("0.00"); }
            }

            public ImageSource FoodPictureAddress
            {
                get { return imgFoodPicture.Source; }
                set { imgFoodPicture.Source = value; }
            }
        #endregion

        #region EventHandlers
            //public event RoutedEventHandler btnOrderClick
            //{
            //    add { btnOrder.Click += value; }
            //    remove { btnOrder.Click -= value; }
            //}

            //public event RoutedEventHandler btnReserveClick
            //{
            //    add { btnReserve.Click += value; }
            //    remove { btnReserve.Click -= value; }
            //}

            //public event RoutedEventHandler btnCommentClick
            //{
            //    add { btnComment.Click += value; }
            //    remove { btnComment.Click -= value; }
            //}

            //public event RoutedEventHandler btnEditRateClick
            //{
            //    add { btnChangeRate.Click += value; }
            //    remove { btnChangeRate.Click -= value; }
            //}
        #endregion

        #region DataLoader
            Food food;
            Restaurant restaurant;
            List<Food> foodList;

            private void LoadFood()
            {
                FoodNameText = food.Name;
                FoodInventory = food.Inventory;
                FoodPrice = food.Price;
                FoodRate = food.Rate;
                FoodRawMaterial = food.RawMaterial;
                try
                {
                    FoodPictureAddress = (ImageSource)new ImageSourceConverter().ConvertFromString(food.ImageSource);
                }
                catch
                {
                    FoodPictureAddress = (ImageSource)new ImageSourceConverter().ConvertFromString("./../../../Asset/Element/DefaultPicture.png");
                }

                // TODO Load Comments
            }
            private void LoadComment()
            {

                lstComments.Items.Clear();

                if (food.ListComments is not null && food.ListComments.Count > 0)
                {
                    // Get CustomerRate
                    try
                        {
                            CustomerRate =  food.ListComments.Where(x => x.UserId == Veiw.CustomerMainVeiw.Customer.Id).First().Rate;
                            uinfoYourRate.BoxText = (CustomerRate == -1)? "" : CustomerRate.ToString("0.00");
                        }
                    catch { }

                    foreach (var item in food.ListComments)
                    {
                        URestaurantFoodCommentControl restaurantComment = new URestaurantFoodCommentControl();
                        restaurantComment.Comment = item.Content;
                        restaurantComment.Rate = (item.Rate == -1)? 0 : item.Rate;
                        restaurantComment.CreatedDate = item.DateTime;
                        restaurantComment.btnEditVisibility = (Veiw.CustomerMainVeiw.Customer.Id == item.UserId) ? Visibility.Visible : Visibility.Hidden;
                        restaurantComment.lblEditedVisibility = (item.IsEdited) ? Visibility.Visible : Visibility.Hidden;
                        restaurantComment.btnEditClick += btnCommentEdit;
                        restaurantComment.btnDeleteClick += btnCommentDelete;
                        restaurantComment.btnAnswerClick += btnShowAnswer;

                        lstComments.Items.Add(restaurantComment);
                    }
                }
            } 

            private void DataLoader(object sender, RoutedEventArgs e)
            {
                LoadFood();
                LoadComment();
            }

            public CustomerFoodPageControl(Food food, Restaurant restaurant, List<Food> foodList)
            {
                // Initial Values
                this.food = food;
                this.restaurant = restaurant;
                this.foodList = foodList;

                // Load UI
                InitializeComponent();

                DataContext = this;
                this.Loaded += DataLoader;
            }
        #endregion


        private void btnBack(object sender, RoutedEventArgs e)
        {
            grdMain.Children.Clear();
            grdMain.Children.Add(new CustomerFoodSelectionControl(foodList, restaurant));
        }

        private void btnCommentEdit(object sender, RoutedEventArgs e)
        {
            URestaurantFoodCommentControl commentControl = sender as URestaurantFoodCommentControl;
            var comment = food.ListComments.Where(x => x.UserId == Veiw.CustomerMainVeiw.Customer.Id && x.RestaurantId == restaurant.Id && x.Content == commentControl.Comment).First();
            food.ListComments.Remove(comment);
            LoadComment();

            txtComment.Text = comment.Content;
            tmpComment = comment;
            isEditFlag = true;
        }

        private void btnCommentDelete(object sender, RoutedEventArgs e)
        {
            URestaurantFoodCommentControl commentControl = sender as URestaurantFoodCommentControl;
            var comment = food.ListComments.Where(x => x.UserId == Veiw.CustomerMainVeiw.Customer.Id && x.RestaurantId == restaurant.Id && x.Content == commentControl.Comment).First();
            food.ListComments.Remove(comment);
            LoadComment();
        }

        private void btnShowAnswer(object sender, RoutedEventArgs e)
        {
            URestaurantFoodCommentControl commentControl = sender as URestaurantFoodCommentControl;
            var comment = food.ListComments.Where(x => x.UserId == Veiw.CustomerMainVeiw.Customer.Id && x.RestaurantId == restaurant.Id && x.Content == commentControl.Comment).First();
            if(comment != null && comment.Answer != null)
            {
                MessageBox.Show(comment.Answer);
            }
        }

        private void btnCommentClick(object sender, RoutedEventArgs e)
        {
            if(txtComment.Text.Trim().Length > 0 && txtComment.Text.Trim().Length <= 150)
            {
                if (isEditFlag)
                {
                    tmpComment.Content = txtComment.Text;
                    tmpComment.Rate = CustomerRate;
                    tmpComment.IsEdited = true;
                    food.ListComments.Add(tmpComment);
                    isEditFlag = false;
                }
                else
                {
                    Comment comment = new Comment(Veiw.CustomerMainVeiw.Customer.Id, restaurant.Id, txtComment.Text.Trim(), DateTime.Now, CustomerRate, false, null);
                    if(food.ListComments is null)
                        food.ListComments = new List<Comment>();
                    food.ListComments.Add(comment);
                }

                txtComment.Text = "";
                LoadComment();
            }
        }

        private void btnChangeRateClick(object sender, RoutedEventArgs e)
        {
            if (!uinfoYourRate.txtBox.IsEnabled)
            {
                uinfoYourRate.txtBox.IsEnabled = true;
                btnChangeRate.Content = "تایید";
            }
            else
            {
                int newRate;
                try
                {
                    if(uinfoYourRate.BoxText is null || uinfoYourRate.BoxText.Trim() == "")
                    {
                        newRate = -1;
                    }
                    else
                    {
                        newRate = int.Parse(uinfoYourRate.BoxText);
                        if (newRate < 0 || newRate > 5) { throw new Exception(); }
                    }

                    if (food.ListComments is not null && food.ListComments.Count > 0)
                    {
                        CustomerRate = newRate;
                        foreach (var comment in food.ListComments)
                        {
                            if (Veiw.CustomerMainVeiw.Customer.Id == comment.UserId)
                            {
                                comment.Rate = newRate;
                            }
                        }
                    }
                    
                    LoadComment();

                    uinfoYourRate.txtBox.IsEnabled =false;
                    btnChangeRate.Content = "ویرایش";
                }
                catch { }
            }
        }
    }
}
