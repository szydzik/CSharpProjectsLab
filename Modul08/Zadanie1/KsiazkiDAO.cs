using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    public class KsiazkiDAO : InterfaceDAO<Ksiazka>
    {

        SqlConnection connection = DBConnection.GetConnection();

        public void delete(int id)
        {
            try
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("DELETE FROM Ksiazki WHERE ID = '" + id + "'", connection))
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

        public void insert(Ksiazka obj)
        {
            try
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("INSERT INTO Ksiazki OUTPUT Inserted.* VALUES (@autorzy, @tytul, @rokwydania, @wydawnictwo, @isbn)", connection))
                {
                    command.Parameters.Add(new SqlParameter("autorzy", obj.Autorzy));
                    command.Parameters.Add(new SqlParameter("tytul", obj.Tytul));
                    command.Parameters.Add(new SqlParameter("rokwydania", obj.RokWydania));
                    command.Parameters.Add(new SqlParameter("wydawnictwo", obj.Wydawnictwo));
                    command.Parameters.Add(new SqlParameter("isbn", obj.ISBN));
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

        public Ksiazka select(int id)
        {
            Ksiazka ksiazka = null;
            try
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM Ksiazki WHERE ID = '" + id + "'", connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    ksiazka = new Ksiazka(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), reader.GetString(4), reader.GetString(5));
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
            return ksiazka;
        }

        public List<Ksiazka> selectAll()
        {
            List<Ksiazka> list = new List<Ksiazka>();
            try
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM Ksiazki", connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Ksiazka ksiazka = new Ksiazka(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), reader.GetString(4), reader.GetString(5));
                        list.Add(ksiazka);
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

        public void update(Ksiazka obj)
        {
            try
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("UPDATE Ksiazka SET AUTORZY = @autorzy, TYTUL = @tytul, ROKWYDANIA = @rokwydania, WYDAWNICTWO = @wydawnictwo, ISBN = @isbn WHERE ID = @id", connection))
                {
                    command.Parameters.Add(new SqlParameter("autorzy", obj.Autorzy));
                    command.Parameters.Add(new SqlParameter("tytul", obj.Tytul));
                    command.Parameters.Add(new SqlParameter("rokwydania", obj.RokWydania));
                    command.Parameters.Add(new SqlParameter("wydawnictwo", obj.Wydawnictwo));
                    command.Parameters.Add(new SqlParameter("isbn", obj.ISBN));
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