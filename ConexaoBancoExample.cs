using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMelhorado
{
    internal class ConexaoBancoExample
    {
        public const string servidor1 = "localhost";
        public const string bancoDados1 = "";
        public const string porta1 = "3306";
        public const string usuario1 = "root";
        public const string senha1 = "";
        public static string BancoServidor1 = $"server={servidor1};port={porta1};user id={usuario1};password={senha1};database={bancoDados1};";
    }
}
