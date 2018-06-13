using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace VillaTracking.Web.data
{
    public class Encryptation
    {
        // Llamada al proveedor de encriptados 3DES

        private TripleDESCryptoServiceProvider m_des = new TripleDESCryptoServiceProvider();

        // Define en controlador de cadenas de texto

        private UTF8Encoding m_utf8 = new UTF8Encoding();

        // Propiedades de los arrays

        private byte[] m_key;

        private byte[] m_iv;

        // Llave local y vector de bytes

        private readonly byte[] key = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24 };

        private readonly byte[] iv = { 41, 16, 38, 35, 24, 32, 87, 14 }; // Cambiar los valores numéricos por unos diferentes ya que es parte de la llave de codificación y decodificación.

        public Encryptation()
        {
            m_key = key;
            m_iv = iv;
        }

        public byte[] Encrypt(byte[] input)
        {
            return Transform(input, m_des.CreateEncryptor(m_key, m_iv));
        }

        public byte[] Decrypt(byte[] input)
        {
            return Transform(input, m_des.CreateDecryptor(m_key, m_iv));
        }

        // FUNCION PARA ENCRIPTAR

        public string Encrypt(string text)
        {
            byte[] input = m_utf8.GetBytes(text);

            byte[] output = Transform(input, m_des.CreateEncryptor(m_key, m_iv));

            return Convert.ToBase64String(output);
        }

        // FUNCION PARA DESENCRIPTAR

        public string Decrypt(string text)
        {
            byte[] input = Convert.FromBase64String(text);

            byte[] output = Transform(input, m_des.CreateDecryptor(m_key, m_iv));

            return m_utf8.GetString(output);
        }

        private byte[] Transform(byte[] input, ICryptoTransform CryptoTransformar)
        {

            // Crea los streams necesarios

            MemoryStream memStream = new MemoryStream();

            CryptoStream cryptStream = new CryptoStream(memStream, CryptoTransformar, CryptoStreamMode.Write);

            // transforma la peticion en bytes

            cryptStream.Write(input, 0, input.Length);

            cryptStream.FlushFinalBlock();

            // Lee la posicion de memoria y lo convierte en arreglo de bytes

            memStream.Position = 0;

            byte[] result = new byte[memStream.Length - 1 + 1];

            memStream.Read(result, 0, result.Length);

            // Libera y cierra los streams

            memStream.Close();

            cryptStream.Close();

            return result;
        }
    }

}

