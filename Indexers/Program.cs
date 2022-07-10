using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.udemy.com/course/csharp-intermediate-classes-interfaces-and-oop/learn/lecture/2205248#content
namespace Indexers
{
    // if you're working with a class that has a semantic of a collection or a list
    // or a dictionary you can improve your code by declaring an indexer
    class Program
    {
        static void Main(string[] args)
        {
            var cookie = new HttpCookie();
            cookie["name"] = "Abe";
            Console.WriteLine(cookie["name"]);
        }
    }
}