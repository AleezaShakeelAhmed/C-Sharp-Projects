using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelwithforms.BL
{
    class room
    {
        private string roomname;
        private string roomprice;
        private int numberofdays;

        public string Roomname { get => roomname; set => roomname = value; }
        public string Roomprice { get => roomprice; set => roomprice = value; }
        public int Numberofdays { get => numberofdays; set => numberofdays = value; }

        public room(string roomname, int numberofroom,int index)
        {
            this.Roomname = roomname;
            this.Numberofdays = numberofdays;
        }
        public room(string roomname)
        {
            this.Roomname = roomname;
        }
        public room(int days,string Roomprice)
        {
            this.Roomprice = Roomprice;
        }
        public room(string roomname, string roomprice)
        {
            this.Roomname = roomname;
            this.Roomprice = roomprice;
        }
        public room(int numberofdays)
        {
            this.Numberofdays = numberofdays;
        }
        public room()
        {

        }
    }
}
