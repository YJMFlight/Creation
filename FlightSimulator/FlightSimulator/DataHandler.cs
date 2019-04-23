using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace FlightSimulator
{
    class DataHandler
    {
        string conString = "Data Source=LAPTOP-8UCKBDRP;Initial Catalog=db_Aircraft_Simulation;Integrated Security=True";

        SqlConnection conn = null;
        SqlDataAdapter adapter = null;
        DataSet DataSet = null;


        public DataSet ReadOne()
        {
            try
            {
                DataSet = new DataSet();
                conn = new SqlConnection(conString);
                conn.Open();

                string Invselect = "SELECT * FROM tbl_User";


                adapter = new SqlDataAdapter(Invselect, conn);



                adapter.Fill(DataSet, "tbl_User");

            }
            catch (Exception e)
            {

                System.Windows.Forms.MessageBox.Show("DataSet ReadOne()" + e.Message);

            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return DataSet;
        }

        public void AddData(Obstacles newObstacles)
        {
            DataSet dataset = null;
            try
            {
                conn = new SqlConnection(conString);
                conn.Open();
                DataSet dataSet = new DataSet();
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                DataTable userTable = dataset.Tables["Obstacles"];
                DataRow row = userTable.NewRow();
                row["CoordinatesY"] = newObstacles.CoordinatesY;
                row["CoordinatesX"] = newObstacles.CoordinatesX;

                string insert = "INSERT   INTO tbl_Obstacles", VALUES ("'XCo_Ordinate'", +"'YCo_Ordinate'") ;
                userTable.Rows.Add(row);
          
                adapter.Update(dataset, "Obstacles");

            }
            catch (Exception e)
            {

             

            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }


        }


    }
}