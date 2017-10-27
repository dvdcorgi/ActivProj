using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TestUpdater
{
    public class ClassHash
    {
        public String sha256_hash(String value)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return String.Concat(hash
                  .ComputeHash(Encoding.UTF8.GetBytes(value))
                  .Select(item => item.ToString("X2")));
            }
        }

        public string sha512(string val)
        {
            var bytes = System.Text.Encoding.UTF8.GetBytes(val);

            foreach (var item in bytes)
            {
                Console.WriteLine("Bytes: " + item);
            }

            using (var hash = System.Security.Cryptography.SHA512.Create())
            {
                var hashedInputBytes = hash.ComputeHash(bytes);
                Console.Write("Hashed Input Bytes: " + hash.HashSize + "\n");
                foreach (var item in hashedInputBytes)
                {
                    Console.Write(item + " ");
                }
                // StringBuilder Capacity is 128, because 512 bits / 8 bits in byte * 2 symbols for byte 
                var hashedInputStringBuilder = new System.Text.StringBuilder(128);
                foreach (var b in hashedInputBytes) {
                    hashedInputStringBuilder.Append(b.ToString("X2"));
                }
                    
                return hashedInputStringBuilder.ToString();
            }
        }
    }
}
