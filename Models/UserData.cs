using MongoDB.Bson;
using System;

namespace ShookModel.Models
{
    class UserData
    {
        #region Variables 
        private ObjectId Id { get; set; }
        private string UserName { get; set; }
        private Object ProfilePicture { get; set; }
        // TODO: Add RegEx for email validation. 
        private string EmailAddress { get => this.EmailAddress; set => this.EmailAddress = value; }
        #endregion
    }
}
