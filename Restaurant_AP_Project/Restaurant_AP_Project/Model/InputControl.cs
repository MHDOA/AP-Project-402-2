using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Restaurant_AP_Project.Model
{
    public static class InputControl
    {
        public static void NotEmpty(this string input, string fieldName)
        {
            if(input is null || input.Trim() == "")
            {
                throw new Exception($"{fieldName} نمیتواند خالی باشد");
            }
        }

        public static void MinChar(this string input, string fieldName, int charNum)
        {
            if(input is null || input.Trim().Length < charNum)
            {
                throw new Exception($"{fieldName} بخش باشد {charNum} نباید کمتر از");
            }
        }

        public static void MaxChar(this string input, string fieldName, int charNum)
        {
            if (input is null || input.Trim().Length > charNum)
            {
                throw new Exception($"{fieldName} بخش باشد {charNum} نباید بیشتر از");
            }
        }

        public static void IsCorrectName(this string input, string fieldName)
        {
            Regex regex = new Regex("^[A-Za-z\u0600-\u06FF]{3,32}$");
            if (!regex.IsMatch(input))
            {
                throw new Exception($"{fieldName} باید حداقل 3 و حداکثر 32 بخش و تنها شامل حروف فارسی یا انگلیسی باشد");
            }
        }

        public static void IsCorrectEmail(this string input)
        {
            Regex regex = new Regex("^[A-Za-z0-9._%+-]{3,32}@[A-Za-z0-9.-]{3,32}\\.[A-Za-z]{2,3}$");
            if (!regex.IsMatch(input))
            {
                throw new Exception($"ایمیل نامعتبر");
            }
        }

        public static void IsCorrectPhone(this string input)
        {
            Regex regex = new Regex("^09\\d{9}$");
            if (!regex.IsMatch(input))
            {
                throw new Exception($"موبایل نامعتبر");
            }
        }

        public static void IsCorrectPass(this string input)
        {
            Regex regex = new Regex("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)[A-Za-z\\d]{8,32}$");
            if (!regex.IsMatch(input))
            {
                throw new Exception($"رمز باید حداقل 8 و حداکثر 32 بخش باشد و حداقل شامل یک حرف بزرگ، یک حرف کوچک و یک عدد باشذ");
            }
        }
        
        public static void IsCorrectUserName(this string input)
        {
            Regex regex = new Regex("^(?=(?:.*[A-Za-z]){3,})[A-Za-z\\d]+$");
            if (!regex.IsMatch(input))
            {
                throw new Exception($"رمز باید حداقل 8 و حداکثر 32 بخش باشد و حداقل شامل یک حرف بزرگ، یک حرف کوچک و یک عدد باشذ");
            }
        }
    }
}
