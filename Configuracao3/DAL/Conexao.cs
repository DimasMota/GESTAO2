
namespace DAL
{
    public static class Conexao
    {
        public static string StringDeConexao
        {
            get // funçao de apenas pegar dados e nao colocar
            {
                return @"Server=localhost\SQLEXPRESS;Database=GESTAO;Trusted_Connection=True";
            }
        }
    }
}