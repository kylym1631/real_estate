using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_5
{
    public interface IData
    {
        string Name { set; get;}
        string Surname { set; get;}
        string AddressOwner { set; get;}
        string Email { set; get;}

        string Id { set; get;}

        string Address { set; get; }

        int Size { set; get;}
        string Birthday { set; get;}

        int Floor { set; get; }
        int Age { set; get; }
        long Phone { set; get; }

        int Rooms { set; get; }
        int Bathrooms { set; get; }
        int Price { set; get; }



        //properties
        string Furnished { set; get; }
        string WithOwner { set; get; }
        string Internet { set; get; }
        string Elevator { set; get; }
        string HotColdWater { set; get; }
        string BathTube { set; get; }
        string AirCon { set; get; }
        string Pool { set; get; }
        string Stove { set; get; }
        string Balcony { set; get; }
        string SecurityDesk { set; get; }
        string Gym { set; get; }


    }

}
