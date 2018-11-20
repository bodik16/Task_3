namespace Task3.DAO.DataTypes
{
    using System;

    public class Order
    {
        private uint id;
        private string dispatch;
        private string destination;
        private uint roadTime;
        private uint cost;

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

        public Driver Driver { get; set; }

        public DateTime ArriveTime { get; set; }

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

        public bool IsDone { get; set; }

        public Client Client1 { get; set; }

        public Order() { }

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

        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3} {4} {5} {6} {7} {8}", Id, Client.Id, Driver.Id, ArriveTime.ToString("yyyy-MM-dd_HH:mm"), Dispatch, Destination, RoadTime, Cost, IsDone);
        }
    }
}
