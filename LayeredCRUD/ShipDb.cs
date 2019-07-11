using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LayeredCRUD
{
    class ShipDb
    {
        string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True";
        public List<Ship> GetAll()
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Ship", con);
                SqlDataReader reader = cmd.ExecuteReader();
                List<Ship> shipList = new List<Ship>();

                while (reader.Read())
                {
                    Ship s = new Ship();
                    s.Id = (int)reader["Id"];
                    s.Manufacturer = (string)reader["Manufacturer"];
                    s.Line = (string)reader["Line"];
                    s.Model = (string)reader["Model"];
                    s.Class = (string)reader["Class"];

                    shipList.Add(s);
                }
                return shipList;
            }
        }

        public void Add(Ship ship)
        {
          using(SqlConnection con = new SqlConnection(conString))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Ship (Manufacturer, Line, Model, Class) VALUES (@Manufacturer, @Line, @Model, @Class);", con);
                cmd.Parameters.AddWithValue("Manufacturer", ship.Manufacturer);
                cmd.Parameters.AddWithValue("Line", ship.Line);
                cmd.Parameters.AddWithValue("Model", ship.Model);
                cmd.Parameters.AddWithValue("Class", ship.Class);

                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ship added, commander");
            }
        }

        public void Update(Ship ship)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                SqlCommand cmd = new SqlCommand("UPDATE Ship SET Manufacturer = @Manufacturer, Line = @Line, Model = @Model, Class = @Class WHERE Id = @Id;", con);
                cmd.Parameters.AddWithValue("Id", ship.Id);
                cmd.Parameters.AddWithValue("Manufacturer", ship.Manufacturer);
                cmd.Parameters.AddWithValue("Line", ship.Line);
                cmd.Parameters.AddWithValue("Model", ship.Model);
                cmd.Parameters.AddWithValue("Class", ship.Class);

                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ship updated, commander");
            }
        }

        public void Delete(int Id)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Ship WHERE Id = @Id", con);
                cmd.Parameters.AddWithValue("Id", Id);

                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ship deleted, commander");
            }
        }
    }
}
