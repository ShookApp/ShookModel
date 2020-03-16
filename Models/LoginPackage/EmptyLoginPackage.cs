using System;
namespace ShookModel.Models
{
    public class EmptyLoginPackage : LoginPackage
    {
        public EmptyLoginPackage()
        {
            this.Success = false;
            this.AccountUser = null;
            this.ApiKey = "";
            this.ValidUntil = DateTime.MinValue;
        }
    }
}
