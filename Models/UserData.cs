using MongoDB.Bson;
using System;

namespace ShookModel.Models
{
    public class UserData
    {
        #region Variables 
        public string UserName { get; set; }

        public string Password { get; set; }
        // TODO: Find a proper data type for the profile picture
        // which can be stored in the MongoDB.
        public Object ProfilePicture { get; set; }
        // TODO: Add RegEx for email validation. 
        public string EmailAddress { get; set; }
        #endregion
    }
}
