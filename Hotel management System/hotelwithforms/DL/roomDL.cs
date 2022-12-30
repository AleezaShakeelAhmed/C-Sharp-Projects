using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using hotelwithforms.BL;

namespace hotelwithforms.DL
{
    class roomDL
    {
        public static List<room> roomlist = new List<room>();
        public static List<room> bookedroomlist = new List<room>();

        public static bool readFromFile()
        {
            string path = "rooms information.txt";
            string record;
            if (File.Exists(path))
            {
                StreamReader f = new StreamReader(path);
                while ((record = f.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string roomname = splittedRecord[0];
                    string roomprice = splittedRecord[1];
                    room r = new room(roomname, roomprice);
                    roomlist.Add(r);
                }
                f.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void storeintofile()
        {
            string path = "rooms information.txt";
            StreamWriter f = new StreamWriter(path);
            for (int i = 0; i < roomlist.Count; i++)
            {
                f.WriteLine(roomlist[i].Roomname + "," + roomlist[i].Roomprice);
            }
            f.Flush();
            f.Close();
        }
       
        public static bool CheckNameOfRoom(string name)
        {
            for (int i=0;i<roomlist.Count;i++)
            {
                if (name == roomlist[i].Roomname)
                {
                    return true;
                }
            }
            return false;
        }
        public static room isRoomExists(string splittedRecordForRoomdata)
        {

            foreach (room r in roomlist)
            {
                if (r.Roomname == splittedRecordForRoomdata)
                {
                    return r;
                }


            }
            return null;

        }

    }
}
