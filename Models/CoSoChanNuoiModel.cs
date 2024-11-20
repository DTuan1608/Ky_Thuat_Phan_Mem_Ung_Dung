using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTPMUD.Models
{
    public class CoSoChanNuoiModel
    {
        private readonly string connectionString = "Data Source=local_host;Initial Catalog=DATABASE_NAME;Integrated Security=True";
        public List<Record> GetAll()
        {
            var records = new List<Record>();
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var command = new SqlCommand("SELECT Id, Name, Address, Phone FROM CoSoChanNuoi", connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    records.Add(new Record
                    {
                        Id = (int)reader["Id"],
                        Name = reader["Name"].ToString(),
                        Address = reader["Address"].ToString(),
                        Phone = reader["Phone"].ToString()
                    });
                }
            }
            return records;
        }
        public void Insert(Record record)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var command = new SqlCommand("INSERT INTO CoSoChanNuoi (Name, Address, Phone) VALUES (@Name, @Address, @Phone)", connection);
                command.Parameters.AddWithValue("@Name", record.Name);
                command.Parameters.AddWithValue("@Address", record.Address);
                command.Parameters.AddWithValue("@Phone", record.Phone);
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var command = new SqlCommand("DELETE FROM CoSoChanNuoi WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);
                command.ExecuteNonQuery();
            }
        }

        public void Update(Record record)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var command = new SqlCommand("UPDATE CoSoChanNuoi SET Name = @Name, Address = @Address, Phone = @Phone WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Name", record.Name);
                command.Parameters.AddWithValue("@Address", record.Address);
                command.Parameters.AddWithValue("@Phone", record.Phone);
                command.Parameters.AddWithValue("@Id", record.Id);
                command.ExecuteNonQuery();
            }
        }
    }
    public class Record
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }
}
