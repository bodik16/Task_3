namespace Taxi_Driver_WPF.IOTypes
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using Task3.DAO.DataTypes;

    /// <summary>
    /// Represents class DriversDB
    /// </summary>
    public class DriversDB
    {
        /// <summary>
        /// Variable fileName
        /// </summary>
        private string fileName;

        /// <summary>
        /// List of drivers
        /// </summary>
        private List<Driver> allDrivers;

        /// <summary>
        /// Initializes a new instance of the <see cref="DriversDB"/> class with specified fileName
        /// </summary>
        /// <param name="fileName">file name</param>
        public DriversDB(string fileName)
        {
            this.allDrivers = new List<Driver>();
            this.fileName = fileName;
        }

        /// <summary>
        /// Gets variable allDrivers
        /// </summary>
        /// <value>The allDrivers</value>
        public List<Driver> AllDrivers
        {
            get
            {
                return this.allDrivers;
            }

            set
            {
                if (value.Count == 0)
                {
                    throw new ArgumentOutOfRangeException("DriversDB is empty");
                }

                this.allDrivers = value;
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
                this.allDrivers.Add(new Driver(Convert.ToUInt32(lineElems[0]), lineElems[1], lineElems[2], Convert.ToUInt32(lineElems[3]), lineElems[4], Convert.ToUInt32(lineElems[5]), Convert.ToUInt32(lineElems[6]), Convert.ToDouble(lineElems[7])));
            }
        }

        /// <summary>
        /// Update driver
        /// </summary>
        /// <param name="driverToUpdate">driver to update</param>
        public void UpdateDriver(Driver driverToUpdate)
        {
            for (int i = 0; i < this.allDrivers.Count; ++i)
            {
                if (this.allDrivers[i].Id == driverToUpdate.Id)
                {
                    this.allDrivers[i] = driverToUpdate;
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
                foreach (Driver driver in this.allDrivers)
                {
                    writer.WriteLine(driver);
                }
            }
        }

        /// <summary>
        /// Find driver
        /// </summary>
        /// <param name="surname">surname</param>
        /// <param name="name">name</param>
        /// <returns>search result</returns>
        public Driver FindDriver(string surname, string name)
        {
            Driver searchResult = new Driver();
            foreach (Driver driver in this.allDrivers)
            {
                if (driver.Surname == surname && driver.Name == name)
                {
                    searchResult = driver;
                    break;
                }
            }

            return searchResult;
        }

        /// <summary>
        /// Get driver by id
        /// </summary>
        /// <param name="driverId">driver id</param>
        /// <returns>search result</returns>
        public Driver GetDriverById(uint driverId)
        {
            Driver searchResult = new Driver();
            foreach (Driver driver in this.allDrivers)
            {
                if (driver.Id == driverId)
                {
                    searchResult = driver;
                    break;
                }
            }

            return searchResult;
        }
    }
}