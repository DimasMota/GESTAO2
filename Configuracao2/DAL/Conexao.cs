
namespace DAL
{
    public static class Conexao
    {
        public static string StringDeConexao
        {
            get // funçao de apenas pegar dados e nao colocar
            {
               // return @"User ID=SA;Initial Catalog=GESTAO;Data Source=.\SQLEXPRESS2019;Password=Senailab02";
                return @"Server=localhost\SQLEXPRESS;Database=GESTAO;Trusted_Connection=True";
            }
        }
    }
}