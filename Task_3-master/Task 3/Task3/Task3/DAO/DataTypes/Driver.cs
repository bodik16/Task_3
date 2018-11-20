﻿namespace Task3.DAO.DataTypes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Driver
    {
        private uint id;
        private string surname;
        private string name;
        private uint age;
        private string carNumber;
        private uint experience;
        private uint costPerMinute;
        private double payCheck;

        public uint Id
        {
            get
            {
                return this.id;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Driver id can't be < 0");
                }

                this.id = value;
            }
        }
        public string Surname
        {
            get
            {
                return this.surname;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentOutOfRangeException("Drive surname can't be empty");
                }

                this.surname = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentOutOfRangeException("Drive name can't be empty");
                }

                this.name = value;
            }
        }

        public uint Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value < 18)
                {
                    throw new ArgumentOutOfRangeException("Driver is too young!");
                }

                this.age = value;
            }
        }

        public string CarNumber
        {
            get
            {
                return this.carNumber;
            }

            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentOutOfRangeException("Car Number can't be empty");
                }

                this.carNumber = value;
            }
        }

        public uint Experience
        {
            get
            {
                return this.experience;
            }

            set
            {
                if (value < 2)
                {
                    throw new ArgumentOutOfRangeException("Drive has a small experience");
                }

                this.experience = value;
            }
        }

        public uint CostPerMinute
        {
            get
            {
                return this.costPerMinute;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Cost per minute can't be less then 0");
                }

                this.costPerMinute = value;
            }
        }

        public double PayCheck
        {
            get
            {
                return this.payCheck;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("PayCheck can't be < than 0");
                }

                this.payCheck = value;
            }
        }

        public Driver()
        {
            PayCheck = 0;
        }

        public Driver(uint _id, string _surname, string _name, uint _age, string _carNumber, uint _experience, uint _cost, double _pay = 0)
        {
            Id = _id;
            Surname = _surname;
            Name = _name;
            Age = _age;
            CarNumber = _carNumber;
            Experience = _experience;
            CostPerMinute = _cost;
            PayCheck = _pay;
        }

        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3} {4} {5} {6} {7}", Id, Surname, Name, Age, CarNumber, Experience, CostPerMinute, PayCheck);
        }
    }
}
