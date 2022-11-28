using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordAutoFill.Modules
{
    public class User
    {
        public int userid { get; set; }

        public string name { get; set; }
        public string username { get; set; }

        public string password { get; set; }

        //Relation with websites and credidential 
  
       public IList<History> history { get; set; }
        public IList<Credential> credential { get; set; }



    }
}
