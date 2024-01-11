using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V2_Biblioteca
{
    internal class ConexaoString
    {

        string serverName = "localhost"; // ou 127.0.0.1
        string port = "5432"; // porta default
        string userName = "postgres"; // nome da conta de administrador
        string password = "admin"; // senha do SGBD
        string dataBaseName = "dbBiblioteca"; // nome do BD

        public string ConnString()
        {
            //var connString = String.Format("Server = {0}; Port = {1}; Username = {2}; Password = {3}; Database = {4};", serverName, port, userName,
            //password, dataBaseName); 
            var connString = $"Server = {serverName};Port = {port};Username = {userName};Password = {password};Database = {dataBaseName};";

            return connString;
        }
    }
}
