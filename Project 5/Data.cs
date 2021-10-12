using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_5
{
    class Data:IData
    {
        string name, surname, addressOwner, email, id, address,conType, birthday,imagePath = "img\\image_not_available.png", furnished, withOwner, internet, elevator, hotColdWater, bathTube, airCon, pool, stove, balcony, securityDesk, gym;
        int size, floor, age, rooms, bathrooms, price;
        long phone;

        public string ImagePath
        {
            set
            {
                imagePath = value;
            }
            get
            {
                return imagePath;
            }
        }
        public string ConType
        {
            set
            {
                conType = value;
            }
            get
            {
                return conType;
            }
        }
        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
        public string Surname
        {
            set
            {
                surname = value;
            }
            get
            {
                return surname;
            }
        }
        public string AddressOwner
        {
            set
            {
                addressOwner = value;
            }
            get
            {
                return addressOwner;
            }
        }
        public string Email
        {
            set
            {
                email = value;
            }
            get
            {
                return email;
            }
        }

        public string Id
        {
            set
            {
                id = value;
            }
            get
            {
                return id;
            }
        }

        public string Address
        {
            set
            {
                address = value;
            }
            get
            {
                return address;
            }
        }

        public int Size
        {
            set
            {
                size = value;
            }
            get
            {
                return size;
            }
        }

        public string Birthday
        {
            set
            {
                birthday = value;
            }
            get
            {
                return birthday;
            }
        }

        public int Floor
        {
            set
            {
                floor = value;
            }
            get
            {
                return floor;
            }
        }
        public int Age
        {
            set
            {
                age = value;
            }
            get
            {
                return age;
            }
        }
        public long Phone
        {
            set
            {
                phone = value;
            }
            get
            {
                return phone;
            }
        }

        public int Rooms
        {
            set
            {
                rooms = value;
            }
            get
            {
                return rooms;
            }
        }
        public int Bathrooms
        {
            set
            {
                bathrooms = value;
            }
            get
            {
                return bathrooms;
            }
        }
        public int Price
        {
            set
            {
                price = value;
            }
            get
            {
                return price;
            }
        }

        //properties

        public string Furnished 
        {
            set
            {
                furnished = value;
            }
            get
            {
                return furnished;
            }
        }
        public string WithOwner
        {
            set
            {
                withOwner = value;
            }
            get
            {
                return withOwner;
            }
        }
        public string Internet
        {
            set
            {
                internet = value;
            }
            get
            {
                return internet;
            }
        }
        public string Elevator
        {
            set
            {
                elevator = value;
            }
            get
            {
                return elevator;
            }
        }
        public string HotColdWater
        {
            set
            {
                hotColdWater = value;
            }
            get
            {
                return hotColdWater;
            }
        }
        public string BathTube
        {
            set
            {
                bathTube = value;
            }
            get
            {
                return bathTube;
            }
        }
        public string AirCon
        {
            set
            {
                airCon = value;
            }
            get
            {
                return airCon;
            }
        }
        public string Pool
        {
            set
            {
                pool = value;
            }
            get
            {
                return pool;
            }
        }
        public string Stove
        {
            set
            {
                stove = value;
            }
            get
            {
                return stove;
            }
        }
        public string Balcony
        {
            set
            {
                balcony = value;
            }
            get
            {
                return balcony;
            }
        }
        public string SecurityDesk
        {
            set
            {
                securityDesk = value;
            }
            get
            {
                return securityDesk;
            }
        }
        public string Gym
        {
            set
            {
                gym = value;
            }
            get
            {
                return gym;
            }
        }
        

    }
}
