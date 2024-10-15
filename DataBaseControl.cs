using Dapper;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;


namespace Expenses_Control
{
    internal class DataBaseControl
    {
        private readonly string _connectionString;

        public DataBaseControl()
        {
            var basePath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;

            var configuration = new ConfigurationBuilder()
            .SetBasePath(basePath)
            .AddJsonFile("appsettings.json")
            .Build();

            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public void AddExpense(decimal amount, DateTime date, int idCategory)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                // SQL de inserção
                string sql = "INSERT INTO all_expenses (amount, idCategory, date) VALUES (@Amount, @idCat, @Date)";

                // Executando a consulta
                var rowsAffected = connection.Execute(sql, new { Amount = amount, Date = date , idCat = idCategory }); //Este é um objeto anônimo que fornece valores para os parâmetros do comando SQL. O Dapper usa esses valores para substituir os parâmetros no comando SQL, representados por @Description, @Amount e @Date.

                Console.WriteLine($"{rowsAffected} rows were inserted.");
            }
        }

        public int selectCategoryID (string category)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT id FROM all_categories WHERE category = @category";

                try
                {
                    int idCategory = connection.QueryFirstOrDefault<int>(query, new {Category = category});
                    return idCategory;
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message );
                    return -1;
                }

            }
        }

    }
}
