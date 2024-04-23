using System.Linq; //is a name space which has all LinQ related classes. 
using System.Collections.Generic;
using System;
class Q{
    
 static void QueryOverStrings()
        {
            // Assume we have an array of strings.
           int[] numbers = { 12,9,15,8,6};

            // Build a query expression to find the items in the array
            // that have an embedded space.

            IEnumerable<int> subset =numbers.Where(n=>n<10).OrderBy(n=>n).Select(n=>n);
            
            var subsets =from num in  numbers
            where num<10
            orderby num descending
            select num;
                                


            // Print out the results.
            foreach (int s in subsets)
                Console.WriteLine("Item: {0}", s);
        }
    static void Main(string [] args){
        QueryOverStrings();
    }

}