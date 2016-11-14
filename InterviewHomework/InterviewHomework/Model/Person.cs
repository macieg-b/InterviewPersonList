using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace InterviewHomework
{
    public class Person
    {


        #region Fields
        private String _name;
        private String _email;
        #endregion


        #region Constructors
        public Person()
        {

        }
        public Person(String name, String email)
        {
            try
            {
                ValidaData(name, email);
                _name = name;
                _email = email;
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        #endregion


        #region Properties
        public String Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public String Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }
        #endregion


        #region Methods
        private void ValidaData(string name, string email)
        {
            String exceptionMessage = String.Empty;
            try
            {
                IsValidName(name);
            }
            catch (Exception e)
            {
                exceptionMessage = e.Message + " ";
            }
            try
            {
                IsValidEmail(email);
            }
            catch(Exception e)
            {
                exceptionMessage = exceptionMessage + e.Message;
            }
            if (!String.IsNullOrEmpty(exceptionMessage))
            {
                throw new Exception(exceptionMessage);
            }
        }
        private void IsValidName(string name)
        {
            var regex = new Regex("^[a-zA-Z0-9 ]*$");
            if (regex.IsMatch(name))
            {
                if (name.Length > 10)
                    throw new Exception("Incorrect lenght of name.");
            }
            else
            {
                throw new Exception("Special characters in name are not allowed.");
            }
        }
        private void IsValidEmail(string email)
        {
            try
            {
                MailAddress address = new MailAddress(email);
                if(!(address.Address == email))
                {
                    throw new Exception("Incorrect email address.");
                }
            }
            catch
            {
               throw new Exception("Incorrect email address.");
            }
        }

        override public string ToString()
        {
            return _name + ", " + _email;
        }
        #endregion


    }
}
