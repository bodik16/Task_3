namespace Taxi_Driver_WPF.IOTypes
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using Task3.DAO.DataTypes;
    using Task3.DAO.IOTypes;

    /// <summary>
    /// Represents class OrdersDB
    /// </summary>
    public class OrdersDB
    {
        /// <summary>
        /// Variable fileName
        /// </summary>
        private string fileName;

        /// <summary>
        /// List of orders
        /// </summary>
        private List<Order> allOrders;

        /// <summary>
        /// Instance ClientsDB
        /// </summary>
        private ClientsDB clientsInfo;

        /// <summary>
        /// Instance DriversDB
        /// </summary>
        private DriversDB driversInfo;

        /// <summary>
        /// Initializes a new instance of the <see cref="OrdersDB"/> class with specified fileName, clientsInfo, driversInfo
        /// </summary>
        /// <param name="fileName">file name</param>
        /// <param name="clientsInfo">clients info</param>
        /// <param name="driversInfo">drivers info</param>
        public OrdersDB(string fileName, ClientsDB clientsInfo, DriversDB driversInfo)
        {
            this.allOrders = new List<Order>();
            this.fileName = fileName;
            this.clientsInfo = clientsInfo;
            this.driversInfo = driversInfo;
        }

        /// <summary>
        /// Gets variable allOrders
        /// </summary>
        /// <value>The allOrders</value>
        public List<Order> AllOrders
        {
            get
            {
                if (this.allOrders.Count == 0)
                {
                    throw new ArgumentOutOfRangeException("Orders are empty!");
                }

                return this.allOrders;
            }

            set
            {
                if (value.Count == 0)
                {
                    throw new ArgumentOutOfRangeException("Orders are empty!");
                }

                this.allOrders = value;
            }
        }

        /// <summary>
        /// Read from file
        /// </summary>
        public void ReadFromFile()
        {
            string[] allLines = File.ReadAllLines(this.fileName);
            foreach (string line in allLines)
            {
                string[] lineElems = line.Split(' ');
                this.allOrders.Add(new Order(Convert.ToUInt32(lineElems[0]), this.clientsInfo.GetClientById(Convert.ToUInt32(lineElems[1])), this.driversInfo.GetDriverById(Convert.ToUInt32(lineElems[2])), DateTime.Parse(lineElems[3].Replace("_", " ")), lineElems[4], lineElems[5], Convert.ToUInt32(lineElems[6]), Convert.ToUInt32(lineElems[7]), Convert.ToBoolean(lineElems[8])));
            }
        }

        /// <summary>
        /// Update order
        /// </summary>
        /// <param name="orderToUpdate">order to update</param>
        public void UpdateOrder(Order orderToUpdate)
        {
            for (int i = 0; i < this.allOrders.Count; ++i)
            {
                if (this.allOrders[i].Id == orderToUpdate.Id)
                {
                    this.allOrders[i] = orderToUpdate;
                    break;
                }
            }
        }

        /// <summary>
        /// Write to file
        /// </summary>
        public void WriteToFile()
        {
            using (StreamWriter writer = new StreamWriter(this.fileName))
            {
                foreach (Order order in this.allOrders)
                {
                    writer.WriteLine(order);
                }
            }
        }
    }
}