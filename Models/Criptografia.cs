using System.Security.Cryptography;
using System.Text;
using System;

namespace Biblioteca.Models
{
    public static class Criptografia
    {
        public static string CriptografarTexto (string texto)
        {
            MD5 MD5Hasher = MD5.Create();

            byte[] By = Encoding.Default.GetBytes(texto);
            byte[] bytesCriptografado = MD5Hasher.ComputeHash (By);

            StringBuilder SB = new StringBuilder();

            foreach (byte b in bytesCriptografado)
            {
                string DebugB = b.ToString("X2");
                SB.Append(DebugB);
            }

            return SB.ToString();
        }
    }
}