using System;
using System.Collections.Generic;
using System.Linq;


namespace _18.LinqAgain
{ 
    class Program
    {
        static void Main(string[] args)
        {
            // Linq- > Language integrated native query ->
            // processing the data regardless where it comes from, user, DataBase, collections!
            List<int> list = new List<int>();
            list.Add(5);
            list.Add(6);
            list.Add(2);

            int[] array = new int[] {5, 6, 2 };
            //list.Min();  //Linq  works on  collections -Linq always attaches methods, works  on objects
            array.Min();  //Linq  attaches Methods, it extends the Objects with additional functionality!
            // Linq works on collectons, it atttaches methods, Linq extends the Objects functionality
            //Linq work on collections, it attaches methods , Linq extends the objects functionality !
            // Linq attaches methods to the objects  Linq attaches methods to the collestions, 
            // linq works on the collections, it attaches methods to the collections, 
            //it extends the  Objects functionality !
            // in order to work array.Min() , List.Min()-> we neesd to use namespace using System.Linq ~!!!
            //We use Linq to attache methods to the collections, so we extend the Objects, collelctions functionality!
        }
    }
}
