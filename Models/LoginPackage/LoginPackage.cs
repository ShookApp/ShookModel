using System;
namespace ShookModel.Models
{
    public class LoginPackage
    {
        // Indicates whether the username and password are right.
        public bool Success { get; set; }

        // This is the user which logged into Shook.
        public User AccountUser { get; set; }

        // The API key which is valid for 24 hours. 
        public string ApiKey { get; set; }

        // The DateTime until we need a new API Key from the server.
        public DateTime ValidUntil { get; set; }
    }
}
