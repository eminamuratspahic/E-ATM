using System;
using System.Data.SqlClient;
using Dapper;
using System.Collections.Generic;
using System.Linq;


namespace E_ATM
{

    public class DBManager
    {
        private readonly string dbConnection = "Server=40.85.84.155;Database=Student8;User=Student8;Password=zombie-virus@2020;";


        public string GetPlayers()
        {
            using (SqlConnection connection = new SqlConnection(dbConnection))
            {
                var evento = connection.Query<Player>("SELECT Id, FirstName FROM F8");
                var test = "";

                foreach (var myEvent in evento)
                {
                   test += myEvent.Id + " : " + myEvent.FirstName + "\n";
                }
                return test;

            }
        }
    }
     public class Player
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
    
}