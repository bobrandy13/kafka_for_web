using System.Security.Cryptography;

namespace Kafka_for_web.DataAccess;

public static class HashFunction
{
   private static readonly HashAlgorithm Sha = SHA256.Create();

   public static long Hash<T> (T key)
   {
      // hash over the generic type T
      if (key == null)
      {
         return -1; 
      }
      // * return a key from 0 to 2^32 - 1
      var data = Sha.ComputeHash(System.Text.Encoding.UTF8.GetBytes(key.ToString() ?? throw new InvalidOperationException()));
      
      Console.WriteLine(data);
      
      return BitConverter.ToInt64(data); 
   }
}