namespace Task3.DAO.IOTypes
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using Task3.DAO.DataTypes;

    /// <summary>
    /// Represents class ClientsDB
    /// </summary>
    public class ClientsDB
    {
        /// <summary>
        /// Variable fileName
        /// </summary>
        private readonly string fileName;

        /// <summary>
        /// List of all clients
        /// </summary>
        private List<Client> allClients;

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientsDB"/> class with specified fileName
        /// </summary>
        /// <param name="fileName">file name</param>
        public ClientsDB(string fileName)
        {
            this.allClients = new List<Client>();
            this.fileName = fileName;
        }

        /// <summary>
        /// Gets variable allClients
        /// </summary>
        /// <value>The allClients</value>
        public List<Client> AllClients
        {
            get
            {
                return this.allClients;
            }

            set
            {
                if (value.Count == 0)
                {
                    throw new ArgumentOutOfRangeException("ClientsDB is empty!");
                }

                this.allClients = value;
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
                this.allClients.Add(new Client(Convert.ToUInt32(lineElems[0]), lineElems[1], lineElems[2]));
            }
        }

        /// <summary>
        /// Write to file
        /// </summary>
        public void WriteToFile()
        {
            using (StreamWriter writer = new StreamWriter(this.fileName))
            {
                foreach (Client client in this.allClients)
                {
                    writer.WriteLine(client);
                }
            }
        }

        /// <summary>
        /// Gets clients by id
        /// </summary>
        /// <param name="clientId">client id</param>
        /// <returns>search result</returns>
        public Client GetClientById(uint clientId)
        {
            Client searchResult = new Client();
            foreach (Client client in this.allClients)
            {
                if (client.Id == clientId)
                {
                    searchResult = client;
                    break;
                }
            }

            return searchResult;
        }
    }
}
