using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using hotelwithforms.BL;

namespace hotelwithforms.DL
{
    class productDL
    {
        public static List<product> productlist = new List<product>();
        public static List<product> orderedlist = new List<product>();

        public static void Addintolistproduct(product data)
        {
            productlist.Add(data);
        }
        public static bool readFromFile()
        {
            string currentproducts = "products information.txt";
            string record;
            if (File.Exists(currentproducts))
            {
                StreamReader f = new StreamReader(currentproducts);
                while ((record = f.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string productname = splittedRecord[0];
                    float productprice = float.Parse(splittedRecord[1]);
                    product p = new product(productprice,productname);
                    DL.productDL.productlist.Add(p);
                }
                f.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void storeinfile(product p)
        {
            string currentproducts = "products information.txt";
            StreamWriter f = new StreamWriter(currentproducts, true);
            f.WriteLine(p.Productname + "," + p.Productprice);
            f.Flush();
            f.Close();
        }
       
        public static product isProductExists(string splittedRecordForProductdata)
        {

            foreach (product p in productlist)
            {
                if (p.Productname == splittedRecordForProductdata)
                {
                    return p;
                }


            }
            return null;

        }
    }
}
