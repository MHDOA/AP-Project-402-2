using Restaurant_AP_Project.Control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Restaurant_AP_Project.Model
{
    public class Customer
    {
		public enum Gender { Male, Female};
		public enum SpecialService { None, Gold, Silver, Bronze};

		private int id;

		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private string lastName;

		public string LastName
		{
			get { return lastName; }
			set { lastName = value; }
		}

		private string email;

		public string Email
		{
			get { return email; }
			set { email = value; }
		}

		private SpecialService service;

		public SpecialService Service
		{
			get { return service; }
			set { service = value; }
		}

		private Gender _gender;

		public Gender gender
		{
			get { return _gender; }
			set { _gender = value; }
		}


		private string phone;

		public string Phone
		{
			get { return phone; }
			set { phone = value; }
		}

		private string userName;

		public string UserName
		{
			get { return userName; }
			set { userName = value; }
		}

		private string password;

		public string Password
		{
			get { return password; }
			set { password = value; }
		}

		private string address;

		public string Address
		{
			get { return address; }
			set { address = value; }
		}

		private List<Order> orders;

		public List<Order> Orders
		{
			get { return orders; }
			set { orders = value; }
		}

		private List<Reserve> reserves;

		public List<Reserve> Reserves
		{
			get { return reserves; }
			set { reserves = value; }
		}


		private List<Complaint> complaints;

		public List<Complaint> Complaints
        {
			get { return complaints; }
			set { complaints = value; }
		}

		private List<Comment> comments;

        public List<Comment> Comments
        {
            get { return comments; }
            set { comments = value; }
        }

        public Customer(int id, string name, string lastName, string email, SpecialService service, Gender gender, string phone, string userName, string password, string address, List<Order> orders, List<Complaint> complaints, List<Comment> comments)
        {
            Id = id;
            Name = name;
            LastName = lastName;
            Email = email;
            Service = service;
            this.gender = gender;
            Phone = phone;
            UserName = userName;
            Password = password;

			if (address != null)
				Address = address;

			if(orders != null)
				Orders = orders;
			if(complaints != null)
				Complaints = complaints;
			if(comments != null)
				Comments = comments;
        }
	}
}
