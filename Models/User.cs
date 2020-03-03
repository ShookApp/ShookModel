using System;
using System.Collections.Generic;

namespace ShookModel.Models
{
    class User
    {
        #region Variables
        public UserData UserData { get; set; }
        public List<Shook> Shooks { get; set; }
        public int CreatedShooks { get; private set; }
        public int WonShooks { get; private set; }
        #endregion

        public User()
        {

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
