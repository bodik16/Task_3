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
        /// <summary>
        /// Variable id
        /// </summary>
        private uint id;

        /// <summary>
        /// Variable name
        /// </summary>
        private string name;

        /// <summary>
        /// Variable phoneNumber
        /// </summary>
        private string phoneNumber;

        public Client()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Client"/> class with specified id, name, phoneNumber
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="name">name</param>
        /// <param name="phoneNumber">phone number</param>
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
                    throw new ArgumentOutOfRangeException("Name can't be empty");
                }

                this.name = value;
            }
        }

        /// <summary>
        /// Gets variable phoneNumber
        /// </summary>
        /// <value>The phoneNumber</value>
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

        /// <summary>
        /// Returns a string that represents the current instance
        /// </summary>
        /// <returns><see cref="T:System.String"/></returns>
        public override string ToString()
        {
            return String.Format("{0} {1} {2}", this.Id, this.Name, this.PhoneNumber);
        }
    }
}
