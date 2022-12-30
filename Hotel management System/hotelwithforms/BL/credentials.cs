using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelwithforms.BL
{
    class credentials
    {
        private string username;
        private string password;
        private string role;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }

        public credentials(string username, string password, string role)
        {

            this.Username = username;
            this.Password = password;
            this.Role = role;
        }
        public credentials(string username, string password)
        {
            this.Username = username;
            this.Password = password;
            this.Role = "n/a";
        }
        public credentials()
        {

        }
    }
}
