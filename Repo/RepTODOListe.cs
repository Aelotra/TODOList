using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using TODOList.Model;

namespace TODOList.Repo
{
    internal class RepTODOListe : IFiche
    {
        public List<TFiche> GetListe()
        {
            List<TFiche > list = new List<TFiche>();
            try
            {
                Connexion _con = new Connexion();
                using (SqlConnection connection = _con.GetConnection())
                {
                    String Q = "SELECT id, nom, dateCrea, descr FROM Listes";

                    using (SqlCommand command = new SqlCommand(Q, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                TFiche item = new TFiche(reader.GetInt32(0), reader.GetString(1), reader.GetDateTime(2), reader.GetString(3));
                                list.Add(item);
                            }
                        }
                        connection.Close();
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
            return (list);
        }

        public void AddListe(string nom, string text)
        {
            try
            {
                Connexion _con = new Connexion();
                using (SqlConnection connection = _con.GetConnection())
                {
                    String Q = "INSERT INTO Listes (nom, DateCrea, descr) VALUES (@nom, @DateCrea, @descr)";

                    using (SqlCommand command = new SqlCommand(Q, connection))
                    {
                        command.Parameters.AddWithValue("@nom", nom);
                        command.Parameters.AddWithValue("@DateCrea", DateTime.Now);
                        command.Parameters.AddWithValue("@descr", text);

                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.ReadLine();
        }

        public void DelListe(int id)
        {
            try
            {
                Connexion _con = new Connexion();
                using (SqlConnection connection = _con.GetConnection())
                {
                    String Q = "DELETE FROM Listes WHERE id = " + id;

                    using (SqlCommand command = new SqlCommand(Q, connection))
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.ReadLine();
        }

        public void clear()
        {

        }
        public void GetTacheById(int id)
        {

        }
    }
}
