using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelwithforms.BL
{
    public class product
    {
         private string productname;
         private float productprice;

        public string Productname { get => productname; set => productname = value; }
        public float Productprice { get => productprice; set => productprice = value; }

        public product(string productname)
        {
            this.Productname = productname;
        }
        public product(float productprice,string productname)
        {
            this.Productname = productname;
            this.Productprice = productprice;
        }
        public product()
        {

        }   
    }
}
