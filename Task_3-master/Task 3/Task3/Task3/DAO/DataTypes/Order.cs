namespace Task3.DAO.DataTypes
{
    using System;

    /// <summary>
    /// Represents class Order
    /// </summary>
    public class Order
    {
        private uint id;
        private string dispatch;
        private string destination;
        private uint roadTime;
        private uint cost;

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
                    throw new ArgumentOutOfRangeException("Id can't be <0");
                }

                this.id = value;
            }
        }

        /// <summary>
        /// Gets variable client
        /// </summary>
        /// <value>The client</value>
        public Client Client
        {
            get
            {
                return this.Client1;
            }

            set
            {
                this.Client1 = value;
            }
        }

        /// <summary>
        /// Gets variable driver
        /// </summary>
        /// <value>The driver</value>
        public Driver Driver { get; set; }

        /// <summary>
        /// Gets variable arriveTime
        /// </summary>
        /// <value>The arriveTime</value>
        public DateTime ArriveTime { get; set; }

        /// <summary>
        /// Gets variable dispatch
        /// </summary>
        /// <value>The dispatch</value>
        public string Dispatch
        {
            get
            {
                return this.dispatch;
            }
            set
            {
                this.dispatch = value ?? throw new ArgumentOutOfRangeException("Dispatch is not set!");
            }
        }

        /// <summary>
        /// Gets variable destination
        /// </summary>
        /// <value>The destination</value>
        public string Destination
        {
            get
            {
                return this.destination;
            }

            set
            {
                if (value.Equals(dispatch))
                {
                    throw new ArgumentOutOfRangeException("Destination and dispatch are the same place!");
                }

                this.destination = value;
            }
        }

        /// <summary>
        /// Gets variable roadTime
        /// </summary>
        /// <value>The roadTime</value>
        public uint RoadTime
        {
            get
            {
                return this.roadTime;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Road time can only be >= than 0!");
                }

                this.roadTime = value;
            }
        }

        /// <summary>
        /// Gets variable cost
        /// </summary>
        /// <value>The cost</value>
        public uint Cost
        {
            get
            {
                return this.cost;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Cost must be >= than 0!");
                }

                this.cost = value;
            }
        }

        /// <summary>
        /// Gets variable isDone
        /// </summary>
        /// <value>The isDone</value>
        public bool IsDone { get; set; }

        /// <summary>
        /// Gets variable client1
        /// </summary>
        /// <value>The client1</value>
        public Client Client1 { get; set; }

        public Order() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Task3.DAO.DataTypes"/> class with specified id, client, driver, arrive, dispatch, destination, roadTime, cost, isDone
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="client">client</param>
        /// <param name="driver">driver</param>
        /// <param name="arrive">arrive</param>
        /// <param name="dispatch">dispatch</param>
        /// <param name="destination">destination</param>
        /// <param name="roadTime">roadTime</param>
        /// <param name="cost">cost</param>
        /// <param name="isDone">isDone</param>
        public Order(uint id, Client client, Driver driver, DateTime arrive, string dispatch, string destination, uint roadTime, uint cost = 0, bool isDone = false)
        {
            this.Id = id;
            this.Client = client;
            this.Driver = driver;
            this.ArriveTime = arrive;
            this.Dispatch = dispatch;
            this.Destination = destination;
            this.RoadTime = roadTime;
            this.Cost = cost;
            this.IsDone = isDone;
        }

        /// <summary>
        /// Returns a string that represents the current instance
        /// </summary>
        /// <returns><see cref="T:System.String"/></returns>
        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3} {4} {5} {6} {7} {8}", Id, Client.Id, Driver.Id, ArriveTime.ToString("yyyy-MM-dd_HH:mm"), Dispatch, Destination, RoadTime, Cost, IsDone);
        }
    }
}
