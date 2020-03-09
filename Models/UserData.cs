using MongoDB.Bson;
using System;
using System.Net.Mail;

namespace ShookModel.Models
{
    class UserData
    {
        #region Variables 
        public string UserName { get; set; }
        public Object ProfilePicture { get; set; }

        public string MailAddress
        {
            get { return this.MailAddress; }
            set
            {
                if (IsValidMail(value))
                {
                    this.MailAddress = value;
                }
                else
                {
                    throw new FormatException();
                }
            }
        }
        #endregion

        #region Methods
        private bool IsValidMail(string mailAddressString)
        {
            try
            {
                MailAddress mailAddress = new MailAddress(mailAddressString);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        #endregion
    }
}
