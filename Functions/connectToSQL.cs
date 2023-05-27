using System.Linq;
using System.Data;
using System.Data.SqlClient;

namespace informationSystem
{
    public class connectToSQL
    {
        public T getFromDBItem<T>(string querry,string exectDataRow)

        ///<typeparam name="T">
        ///Тип, который используется при вызове функции и в возвращаемую переменную
        ///</typeparam>
        {
            string conn = "Data Source=localhost;Initial Catalog=Trade;Integrated Security=True";
            DataTable sqlDataTable = new DataTable();
            SqlConnection connect = new SqlConnection(conn);
            connect.Open();
            SqlCommand sqlCommand = new SqlCommand(querry,connect);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = sqlCommand;
            adapter.Fill(sqlDataTable);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            T value = (from DataRow dataRow in sqlDataTable.Rows select (T)dataRow[$"{exectDataRow}"]).FirstOrDefault();
            connect.Close();
            return value;
        }
    }
}
