using System;
using System.Collections.Generic    ;

namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 5;
            //boxing like int -> Integer etc
            var o = (object) i;

            var s = 5;
            //casting != boxing
            var o2 = (object)s;
            int? j  = 5;
            Console.WriteLine(j.GetType().Name);

            var roe = new ReadOnlyEnumerator(new List<int>{1,2});
            roe.PrintTheFirstElement();
            roe.PrintTheFirstElement();
        }
    }

    //code sample taken from : https://blogs.msdn.microsoft.com/seteplia/2018/03/07/the-in-modifier-and-the-readonly-structs-in-c/
    internal class ReadOnlyEnumerator
    {
        private readonly List<int>.Enumerator _readOnlyEnumerator;
        
        private List<int>.Enumerator _nonReadOnlyEnumerator;
 
        public ReadOnlyEnumerator(List<int> list)
        {
            _readOnlyEnumerator = list.GetEnumerator();
            _nonReadOnlyEnumerator = list.GetEnumerator();
        }
 
        public void PrintTheFirstElement()
        {
            _readOnlyEnumerator.MoveNext(); // readonly is defined, thus you cannot move to the next, always 0
            _nonReadOnlyEnumerator.MoveNext();
            Console.WriteLine($"Read only: {_readOnlyEnumerator.Current}, non read only: {_nonReadOnlyEnumerator.Current}");
        }

    }
    
  
  
  
    
}
