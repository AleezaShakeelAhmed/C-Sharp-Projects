using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using hotelwithforms.BL;

namespace hotelwithforms.DL
{
    class customerDL
    {
        public static List<customer> customerlist = new List<customer>();

        public static void addcustomersintolist(customer c)
        {
            customerlist.Add(c);
        }
       
        public static void storecustomerdataintofile(customer c)
        {
            string customerpath = "customer information for room booking.txt";
            StreamWriter f = new StreamWriter(customerpath, true);
            string roomnames = "";
            for (int x = 0; x < DL.roomDL.bookedroomlist.Count - 1; x++)
            {
                roomnames = roomnames + DL.roomDL.bookedroomlist[x].Roomname + ";";
            }
            roomnames = roomnames + DL.roomDL.bookedroomlist[DL.roomDL.bookedroomlist.Count - 1].Roomname;
            f.WriteLine(c.Name + "," + c.Idcardnumber + "," + roomnames);
            f.Flush();
            f.Close();
        }
        public static void storeorderedproductsinformation(customer c)
        {
            string path = "customer information for products.txt";
            StreamWriter f = new StreamWriter(path, true);
            string productnames = "";
            for (int x = 0; x < DL.productDL.orderedlist.Count - 1; x++)
            {
                productnames = productnames + DL.productDL.orderedlist[x].Productname + ";";
            }
            productnames = productnames + DL.productDL.orderedlist[DL.productDL.orderedlist.Count - 1].Productname;
            f.WriteLine(c.Name + "," + c.Idcardnumber + "," + productnames);
            f.Flush();
            f.Close();
        }
        public static void storeatonce()
        {
            string customerpath = "customer information for room booking.txt";
            StreamWriter f = new StreamWriter(customerpath);
            for(int i = 0; i < customerlist.Count; i++)
            {
                string roomnames = "";
                for (int x = 0; x < DL.roomDL.bookedroomlist.Count - 1; x++)
                {
                    roomnames = roomnames + DL.roomDL.bookedroomlist[x].Roomname + ";";
                }
                roomnames = roomnames + DL.roomDL.bookedroomlist[DL.roomDL.bookedroomlist.Count - 1].Roomname;
                f.WriteLine(customerlist[i].Name + "," + customerlist[i].Idcardnumber+ "," + roomnames);
            }
            f.Flush();
            f.Close();


        }
        public static bool readFromFileroom()
        {
            string path = "customer information for room booking.txt";
            string record;
            if (File.Exists(path))
            {
                StreamReader f = new StreamReader(path);

                while ((record = f.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string name = splittedRecord[0];
                    string idcardnumber = splittedRecord[1];
                    string[] splittedRecordForRoomdata = splittedRecord[2].Split(';');
                    for (int x = 0; x < splittedRecordForRoomdata.Length; x++)
                    {
                        room r = roomDL.isRoomExists(splittedRecordForRoomdata[x]);
                        if (r != null)
                        {
                            if (!(DL.roomDL.bookedroomlist.Contains(r)))
                               DL.roomDL.bookedroomlist.Add(r);


                        }

                    }
                    customer c = new customer(name, idcardnumber, DL.roomDL.bookedroomlist);
                    customerlist.Add(c);
                   
                }
                f.Close();
                return true;
            }
            else
                return false;
        }
        public static bool readFromFileproduct()
        {
            string path = "customer information for products.txt";
            string record;
            if (File.Exists(path))
            {
                StreamReader f = new StreamReader(path);

                while ((record = f.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string name = splittedRecord[0];
                    string idcardnumber = splittedRecord[1];
                    string[] splittedRecordForProductdata = splittedRecord[2].Split(';');
                    List<product> orderedlist = new List<product>();
                    for (int x = 0; x < splittedRecordForProductdata.Length; x++)
                    {
                        product p = productDL.isProductExists(splittedRecordForProductdata[x]);
                        if (p != null)
                        {
                            if (!(orderedlist.Contains(p)))
                                orderedlist.Add(p);
                        }
                    }
                    customer c = new customer(name, idcardnumber, orderedlist);
                    customerlist.Add(c);
                }
                f.Close();
                return true;
            }
            else
                return false;
        }

    }
}
