using MongoDB.Bson;
using System;
using System.Collections.Generic;

namespace ShookModel.Models
{
    public class Shook
    {
        #region Variables 
        private ObjectId Id { get; set; }
        private string Title { get; set; }
        private string Description { get; set; }
        private DateTime StartTime { get; set; }
        private DateTime EndTime { get; set; }
        private List<User> Member { get; set; }
        private User Creator { get; set; }
        #endregion

        public Shook()
        {

        }

        #region Methods
        public void Start()
        {
            throw new NotImplementedException();
        }

        public void End()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
