using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace PasswordAutoFill.Modules
{
    public class Credential
    {
        public int credentialid { get; set; }
        public string username { get; set; }
        public string NewPassword { get; set; }

        public int userid { get; set; }
        public IList<User> user { get; set; }

        public int websiteid { get; set; }
        public IList<Website> websites{ get; set; }

        public IList<History> history { get; set; }

    

    }
}
