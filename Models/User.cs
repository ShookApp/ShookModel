using MongoDB.Bson;
using System;
using System.Collections.Generic;

namespace ShookModel.Models
{
    public class User
    {
        #region Variables
        public ObjectId Id { get; set; }
        public UserData UserData { get; set; }
        public List<Shook> Shooks { get; set; }
        public int CreatedShooks { get; private set; }
        public int WonShooks { get; private set; }
        #endregion

        public User()
        {
            // TODO: Add method for calculating the CreatedShooks and WonShooks
            // when a User instance is created.
            CreatedShooks = 0;
            WonShooks = 0;
        }

        #region Methods 
        public void CreateShook()
        {
            throw new NotImplementedException();
        }

        public void EditShook(Shook shook)
        {
            throw new NotImplementedException();
        }

        public void JoinShook(Shook shook)
        {
            throw new NotImplementedException();
        }

        public void LeaveShook(Shook shook)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
