using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamuraApp.Domain
{
    public class Quote
    {
        public int Id { get; set; }
        public string Text { get; set; }

        public Samurai samurai { get; set; }
        public int samuraiId { get; set; }

    }
}
