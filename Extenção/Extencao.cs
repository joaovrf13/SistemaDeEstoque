using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEstoque
{
    public static class Extencao
    {
        public static bool IsNull(this string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }

        public static bool IsNotNull(this string value)
        {
            return !string.IsNullOrWhiteSpace(value);
        }
    }
}
