using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp8Features.Demos
{
    public static class UsingStatement
    {
        /// <summary>
        /// Explicitly disposes at the end of the using block
        /// </summary>
        public static void Demo1()
        {
            using (var src = new ResourceHog("source"))
            {
                using (var dest = new ResourceHog("destination"))
                {
                    dest.CopyFrom(src);
                }
                Console.WriteLine("After closing dest block");
            }
            Console.WriteLine("After closing source block");
        }

        /// <summary>
        /// Implicitly disposes at the end of the function or current block (e.g if statement)
        /// </summary>
        public static void Demo2()
        {
            using var src = new ResourceHog("source");
            using var dest = new ResourceHog("destination");
            dest.CopyFrom(src);
            Console.WriteLine("After closing dest block");
            Console.WriteLine("After closing source block");
        }
    }

    public class ResourceHog : IDisposable
    {
        private readonly string resource;

        public ResourceHog(string resource)
        {
            this.resource = resource;
        }
        public void CopyFrom(ResourceHog src) { }

        public void Dispose()
        {
            Console.WriteLine($"Disposing {resource}");
        }
    }
}
