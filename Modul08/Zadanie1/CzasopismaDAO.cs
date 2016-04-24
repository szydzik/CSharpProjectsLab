using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    public class CzasopismaDAO : InterfaceDAO<Czasopismo>
    {

        SqlConnection connection = DBConnection.GetConnection();

        public void delete(int id)
        {
            try
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("DELETE FROM Czasopisma WHERE ID = '" + id + "'", connection))
                {
                    command.ExecuteNonQuery();
                }
            }
            catch (SystemException ex)
            {
                Console.WriteLine(string.Format("An error occurred: {0}", ex.Message));
            }
            finally
            {
                connection.Close();
            }

        }

        public void insert(Czasopismo obj)
        {
            try
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("INSERT INTO Czasopisma OUTPUT Inserted.* VALUES (@tytul, @numer, @rokwydania, @rodzaj)", connection))
                {
                    command.Parameters.Add(new SqlParameter("tytul", obj.Tytul));
                    command.Parameters.Add(new SqlParameter("numer", obj.Numer));
                    command.Parameters.Add(new SqlParameter("rokwydania", obj.RokWydania));
                    command.Parameters.Add(new SqlParameter("rodzaj", obj.Rodzaj));
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    obj.ID = reader.GetInt32(0);
                    Console.WriteLine("Dodano rekord: {0} ", obj);
                }   
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        public Czasopismo select(int id)
        {
            Czasopismo czasopismo = null;
            try
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM Czasopisma WHERE ID = '" + id + "'", connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    czasopismo = new Czasopismo(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), (RODZAJ)reader.GetInt32(4));
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return czasopismo;
        }

        public List<Czasopismo> selectAll()
        {
            List<Czasopismo> list = new List<Czasopismo>();
            try
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM Czasopisma", connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Czasopismo czasopismo = new Czasopismo(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), (RODZAJ)reader.GetInt32(4));
                        list.Add(czasopismo);
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return list;
        }

        public void update(Czasopismo obj)
        {  
            try
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("UPDATE Czasopisma SET TYTUL = @tytul, NUMER = @numer, ROKWYDANIA = @rokwydania, RODZAJ = @rodzaj WHERE ID = @id", connection))
                {
                    command.Parameters.Add(new SqlParameter("tytul", obj.Tytul));
                    command.Parameters.Add(new SqlParameter("numer", obj.Numer));
                    command.Parameters.Add(new SqlParameter("rokwydania", obj.RokWydania));
                    command.Parameters.Add(new SqlParameter("rodzaj", obj.Rodzaj));
                    command.Parameters.Add(new SqlParameter("id", obj.ID));
                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
