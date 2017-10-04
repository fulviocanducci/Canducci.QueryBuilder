using Canducci.QueryBuilder.Dapper.SQLServer;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Canducci.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            using (IDbConnection connection =
                            new SqlConnection("Server=.\\SQLExpress;Database=Test;User Id=sa;Password=senha;"))
            {
                //var a1 = connection.Build()
                //    .From("Pessoas")
                //    .Insert(new string[] { "Nome" }, new object[] { "Zeze de Souza" })
                //    .SaveOrUpdate();

                var a2 = connection.Build()
                    .From("Pessoas")
                    .Update(new string[] { "Nome" }, new object[] { "Hugo Leonardo Canducci Dias" })
                    .Where("Id", 10)
                    .SaveOrUpdate();



                var result = connection.Build()
                    .Select("*")
                    .From("Pessoas")
                    .Where(q => q.Where("Id", ">", 0).Where("Id", "<>", 0))
                    .OrderBy("Nome")
                    .List<Pessoa>();

                foreach(var item in result)
                {
                    System.Console.WriteLine("{0:000} - {1}", item.Id, item.Nome);
                }
            }

            System.Console.ReadKey();
        }
    }
}
