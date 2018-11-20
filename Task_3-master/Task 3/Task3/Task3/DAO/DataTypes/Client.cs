namespace Task3.DAO.DataTypes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents class Client
    /// </summary>
    public class Client
    {
        private uint id;
        private string name;
        private string phoneNumber;

        public Client()
        { }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Task3.DAO.DataTypes"/> class with specified id, name, phoneNumber
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="phoneNumber"></param>
        public Client(uint id, string name, string phoneNumber)
        {
            this.Id = id;
            this.Name = name;
            this.PhoneNumber = phoneNumber;
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
                    throw new ArgumentOutOfRangeException("Client Id can't be < than 0");
                }

                this.id = value;
            }
        }

        /// <summary>
        /// Gets variable name
        /// <value>The name</value>
        /// </summary>
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
                    throw new ArgumentOutOfRangeException("Name can't be empty");
                }

                this.name = value;
            }
        }

        /// <summary>
        ///  Gets variable phoneNumber
        ///  <value>The phoneNumber</value>
        /// </summary>
        public string PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }

            set
            {
                if (value.Length < 10 || value.Length > 13)
                {
                    throw new ArgumentOutOfRangeException("Phone number is incorrect");
                }

                this.phoneNumber = value;
            }
        }

        public override string ToString()
        {
            return String.Format("{0} {1} {2}", this.Id, this.Name, this.PhoneNumber);
        }
    }
}
