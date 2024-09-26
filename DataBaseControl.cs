using Dapper;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;


namespace Expenses_Control
{
    internal class DataBaseControl
    {
        private readonly string _connectionString;

        public DataBaseControl(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public void AddExpense(decimal amount, DateTime date, Category category)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                // SQL de inserção
                string sql = "INSERT INTO Expenses (Description, Amount, Date) VALUES (@Amount, @Date, @Category)";

                // Executando a consulta
                var rowsAffected = connection.Execute(sql, new { Amount = amount, Date = date , Category = category}); //Este é um objeto anônimo que fornece valores para os parâmetros do comando SQL. O Dapper usa esses valores para substituir os parâmetros no comando SQL, representados por @Description, @Amount e @Date.

                Console.WriteLine($"{rowsAffected} rows were inserted.");
            }
        }

    }
}
