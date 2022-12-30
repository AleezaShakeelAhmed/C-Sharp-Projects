using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelwithforms.BL
{
    class customer
    {
        private string name;
        private string idcardnumber;
        private List<room> bookedroomlist;
        private List<product> orderedlist;

        public string Name { get => name; set => name = value; }
        public string Idcardnumber { get => idcardnumber; set => idcardnumber = value; }
        public List<product> Orderedlist { get => orderedlist; set => orderedlist = value; }
        internal List<room> Bookedroomlist { get => bookedroomlist; set => bookedroomlist = value; }

        public customer(string name, string idcardnumber)
        {
            this.Name = name;
            this.Idcardnumber = idcardnumber;
        }
        public customer(string name)
        {
            this.Name = name;
        }
        public customer(string name, string idcardnumber, List<room> bookedroomlist)
        {
            this.Name = name;
            this.Idcardnumber = idcardnumber;
            this.bookedroomlist = bookedroomlist;
        }
        public customer(string name, string idcardnumber, List<product> orderedlist)
        {
            this.Name = name;
            this.Idcardnumber = idcardnumber;
            this.Orderedlist = orderedlist;
        }
        public customer()
        {

        }
    }
}
