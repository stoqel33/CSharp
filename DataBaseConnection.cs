using System;
using System.Collections.Generic;
using System.Text;

namespace DataBaseConnection_1
{
    class Program
    {
        static void Main(string[] args)
        {
            DbCommand sqlCommand = new DbCommand(new SqlConnection("pif"), "dzialaj");
            sqlCommand.Execute();

            DbCommand oracleCommand = new DbCommand(new OracleConnection("paf"), "dzialaj kurwa");
            oracleCommand.Execute();
        }
    }

    public abstract class DbConnection
    {
        public string ConnectionString { get; private set; }
        public TimeSpan Timeout { get; private set; }

        public DbConnection(string dbconnection)
        {
            if (string.IsNullOrEmpty(dbconnection))
                throw new ArgumentException("Connection string is empty!");
            else
                ConnectionString = dbconnection;
        }

        public abstract void Open();
        public abstract void Close();


    }

    public class DbCommand
    {
        public string DbInstruction { get; private set; }
        public DbConnection DbConnection { get; set; }

        public DbCommand(DbConnection dbConnection, string command)
        {
            if (string.IsNullOrEmpty(command))
                throw new ArgumentException("Invalid, command and connection is necessary");
            else
            {
                DbInstruction = command;
                DbConnection = dbConnection;
            }
        }

        public void Execute()
        {
            DbConnection.Open();
            Console.WriteLine("Command being executed {0}", DbInstruction);
            DbConnection.Close();
        }
    }

    public class SqlConnection : DbConnection
    {
        public SqlConnection(string dbconnection)
            : base(dbconnection)
        {

        }

        public override void Open()
        {
            Console.WriteLine("SQL connection is opened with string {0}", ConnectionString);
        }

        public override void Close()
        {
            Console.WriteLine("SQL server is closed");
        }
    }

    public class OracleConnection : DbConnection
    {
        public OracleConnection(string dbconnection)
            : base(dbconnection)
        {

        }

        public override void Open()
        {
            Console.WriteLine("Oracle server is open with strin {0}", ConnectionString);
        }

        public override void Close()
        {
            Console.WriteLine("Oracle server is closed");
        }
    }
}
