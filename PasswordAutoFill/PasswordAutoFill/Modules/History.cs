using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

#nullable disable
namespace PasswordAutoFill.Modules
{
    public class History
    {
        public int historyid { get; set; }


        public string name { get; set; }
        public DateTime LastChanged { get; set; }

        public IList<Credential> Credentials { get; set; }
        public int credentialid { get; set; }
         public IList<User> users { get; set; }
        public int userid { get; set; }

        public IList<Website> websites { get; set; }
        public int websiteid { get; set; }
    
    }
}
