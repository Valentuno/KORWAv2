using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pages
{
    public class Alkohol
    {
        public int AlkoholId { get; set; }
        public string Title { get; set; }
        public string Rent { get; set; }
        public string Ocena { get; set; }


        public Alkohol(int alkoholid, string title, string rent, string ocena)
        {
            Title = title;
            Rent = rent;
            Ocena = ocena;
            AlkoholId = alkoholid;
            
        }
    }
}
