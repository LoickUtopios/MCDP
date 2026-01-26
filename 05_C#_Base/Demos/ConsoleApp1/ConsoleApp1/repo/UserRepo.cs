
using ConsoleApp1.entity;
using MySql.Data.MySqlClient;

namespace ConsoleApp1.repo
{
    internal class UserRepo
    {
        public static string connectionString = "Server=localhost;Uid=root;Pwd=;Database=ado";

        public static List<User> GetAll()
        {
            List<User> Users = new List<User>();
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM User";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        MySqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            Users.Add(new User(
                                    reader.GetInt32("id"),
                                    reader.GetString("name"),
                                    reader.GetString("email"),
                                    reader.GetInt32("age")
                                ));
                        }
                    }
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Erreur MySQL : " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Erreur inattendue : " + e.Message);
            }

            return Users;
        }

        public static User? GetById(int id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM User WHERE id=@id";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        MySqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            return new User(
                                    reader.GetInt32("id"),
                                    reader.GetString("name"),
                                    reader.GetString("email"),
                                    reader.GetInt32("age")
                                );
                        }
                    }
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Erreur MySQL : " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Erreur inattendue : " + e.Message);
            }

            return null;
        }

        public static User? GetByName(string name)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM User WHERE name=@name";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@name", name);
                        MySqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            return new User(
                                    reader.GetInt32("id"),
                                    reader.GetString("name"),
                                    reader.GetString("email"),
                                    reader.GetInt32("age")
                                );
                        }
                    }
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Erreur MySQL : " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Erreur inattendue : " + e.Message);
            }

            return null;
        }

        public static void Insert(User User)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO User (name, email, age) VALUES (@name, @email, @age)";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@name", User.Name);
                    cmd.Parameters.AddWithValue("@email", User.Email);
                    cmd.Parameters.AddWithValue("@age", User.Age);
                    int nbRows = cmd.ExecuteNonQuery();
                    Console.WriteLine("Element(s) ayant été inséré : " + nbRows);
                }
            }
        }

        public static void Update(User User)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE User SET name=@name, email=@email, age=@age WHERE id=@id";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", User.Id);
                    cmd.Parameters.AddWithValue("@name", User.Name);
                    cmd.Parameters.AddWithValue("@email", User.Email);
                    cmd.Parameters.AddWithValue("@age", User.Age);
                    int nbRows = cmd.ExecuteNonQuery();
                    Console.WriteLine("Element(s) ayant été inséré : " + nbRows);
                }
            }
        }

        public static void DeleteById(int id)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM User WHERE id=@id";

                using (MySqlTransaction transaction = connection.BeginTransaction())
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    if (cmd.ExecuteNonQuery() == 1)
                        transaction.Commit();
                    else
                        transaction.Rollback();
                }
            }
        }

        public static int GetMaxAge()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT MAX(age) FROM User";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    int ageMax = (int)cmd.ExecuteScalar();
                    return ageMax;
                }
            }
        }
    }
}
