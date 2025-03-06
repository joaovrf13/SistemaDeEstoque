namespace SistemaMelhorado.Conexão_Banco
{
    internal class ConexaoBanco
    {
        public const string servidor1 = "";
        public const string bancoDados1 = "dbProdutos";
        public const string porta1 = "3306";
        public const string usuario1 = "root";
        public const string senha1 = "";
        public static string BancoServidor1 = $"server={servidor1};port={porta1};user id={usuario1};password={senha1};database={bancoDados1};";


        
        public const string bancoDados2 = "dbClientes";
        public static string BancoServidor2 = $"server={servidor1};port={porta1};user id={usuario1};password={senha1};database={bancoDados2};";

       
    }
}   
