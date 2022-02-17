using System;
using System.Linq;

namespace Partition
{
    class Program
    {
 
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var tws = new Tws();
            

            tws.SortTwoWay(arr, arr.Length);

            Console.WriteLine(String.Join(" ", arr));
        }
    }


}
