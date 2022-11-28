using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordAutoFill.Modules
{
    public class Website
    {
        public int websiteid { get; set; }
        public string webAdress { get; set; }
        public IList<Credential> credentials { get; set; }
        public IList<History> history { get; set; }

       


    }
}
