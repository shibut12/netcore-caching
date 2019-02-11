using System;
using Microsoft.Extensions.Caching.Memory;

namespace netcore_caching
{
    class Program
    {
        static void Main(string[] args)
        {
            IMemoryCache cache = new MemoryCache(new MemoryCacheOptions());

            var result = cache.Set("key", "value");

            Console.WriteLine($"cached value is {cache.Get("key")}");
            
            Console.Read();
        }
    }
}
