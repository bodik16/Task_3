namespace Task3.DAO.DataTypes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents class Driver
    /// </summary>
    public class Driver
    {
        /// <summary>
        /// Variable id
        /// </summary>
        private uint id;

        /// <summary>
        /// Variable surname
        /// </summary>
        private string surname;

        /// <summary>
        /// Variable name
        /// </summary>
        private string name;

        /// <summary>
        /// Variable age
        /// </summary>
        private uint age;

        /// <summary>
        /// Variable carNumber
        /// </summary>
        private string carNumber;

        /// <summary>
        /// Variable experience
        /// </summary>
        private uint experience;

        /// <summary>
        /// Variable costPerMinute
        /// </summary>
        private uint costPerMinute;

        /// <summary>
        /// Variable payCheck
        /// </summary>
        private double payCheck;

        /// <summary>
        /// Initializes a new instance of the <see cref="Driver"/> class
        /// </summary>
        public Driver()
        {
            this.PayCheck = 0;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Driver"/> class with specified id, surname, name, age, carNumber, experience, cost, pay
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="surname">surname</param>
        /// <param name="name">name</param>
        /// <param name="age">age</param>
        /// <param name="carNumber">carNumber</param>
        /// <param name="experience">experience</param>
        /// <param name="cost">cost</param>
        /// <param name="pay">pay</param>
        public Driver(uint id, string surname, string name, uint age, string carNumber, uint experience, uint cost, double pay = 0)
        {
            this.Id = id;
            this.Surname = surname;
            this.Name = name;
            this.Age = age;
            this.CarNumber = carNumber;
            this.Experience = experience;
            this.CostPerMinute = cost;
            this.PayCheck = pay;
        }

        /// <summary>
        /// Gets variable id
        /// </summary>
        /// <value>The id</value>
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

        /// <summary>
        /// Gets variable surname
        /// </summary>
        /// <value>The surname</value>
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

        /// <summary>
        /// Gets variable name
        /// </summary>
        /// <value>The name</value>
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

        /// <summary>
        /// Gets variable age
        /// </summary>
        /// <value>The age</value>
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

        /// <summary>
        /// Gets variable carNumber
        /// </summary>
        /// <value>The carNumber</value>
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

        /// <summary>
        /// Gets variable experience
        /// </summary>
        /// <value>The experience</value>
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

        /// <summary>
        /// Gets variable costPerMinute
        /// </summary>
        /// <value>The costPerMinute</value>
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

        /// <summary>
        /// Gets variable payCheck
        /// </summary>
        /// <value>The payCheck</value>
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

        /// <summary>
        /// Returns a string that represents the current instance
        /// </summary>
        /// <returns><see cref="T:System.String"/></returns>
        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3} {4} {5} {6} {7}", this.Id, this.Surname, this.Name, this.Age, this.CarNumber, this.Experience, this.CostPerMinute, this.PayCheck);
        }
    }
}
