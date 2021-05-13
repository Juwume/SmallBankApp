using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;

namespace SmallBankApp
{
    public class DGVDataSourceChanger
    {
        private const string conString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=SmallBank.mdb";
        public static DataTable getNewDGVDataSource(string query)
        {
            OleDbConnection connection = new OleDbConnection(conString);
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            connection.Open();
            OleDbCommand command = new OleDbCommand(query, connection);
            connection.Close();
            adapter.SelectCommand = command;
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            adapter.Update(dataSet);
            return dataSet.Tables[0];
        }
    }
}
