using System.Collections;
using System.Net.WebSockets;
using System.Text.RegularExpressions;
using static Linq02_Demo.ListGenertor;

namespace Linq02_Demo
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            //Console.WriteLine(ListGenertor.ProductsList[0]);
            //Console.WriteLine(ListGenertor.CustomersList[0]);

            #region Filteration(where)

            #region Ex01
            //fluent
            //var Result = ProductsList.Where(P => P.UnitsInStock == 0);
            //query
            //Result = from P in ProductsList
            //         where P.UnitsInStock == 0
            //         select P;

            #endregion
            #region Ex02
            // fluent
            //var Result = ProductsList.Where(P => P.UnitsInStock == 0 && P.Category == "Condiments");
            //query
            //Result = from P in ProductsList
            //         where P.UnitsInStock == 0 && P.Category == "Condiments"
            //         select P; 
            #endregion
            #region Ex03
            //var Result = ProductsList.Where((P, I) => I < 10 && P.UnitsInStock == 0); 
            #endregion
            #endregion

            #region Transformation(Select-SelectMany)
            #region Ex01
            //var Result = ProductsList.Select(P => P.ProductName);
            //Result = from P in ProductsList
            //         select P.ProductName; 
            #endregion
            #region Ex02

            //var Result = CustomersList.SelectMany(C => C.Orders);
            //Result = from C in CustomersList
            //         from O in C.Orders
            //         select O; 
            #endregion
            #region Ex03
            //var Result = ProductsList.Select(P => new
            //{
            //     P.ProductID,
            //     P.ProductName
            //});
            //Result = from P in ProductsList
            //         select new
            //         {
            //             P.ProductID,
            //             P.ProductName
            //         }; 
            #endregion
            #region Ex04
            //var Result = ProductsList.Where(P => P.UnitsInStock == 0)
            //                         .Select(P => new
            //                         {
            //                             P.ProductID,
            //                             P.ProductName,
            //                             OldPrice = P.UnitPrice,
            //                             NewPrice = P.UnitPrice * 0.90M
            //                         }); 
            #endregion
            #region Ex05
            //var Result = ProductsList.Select((P, I) => new
            //{
            //    Index = I,
            //    P.ProductName
            //}); 
            #endregion
            #endregion

            #region Ording


            #region Ex01
            //var Result = ProductsList.OrderBy(P => P.UnitPrice);
            // //Result = ProductsList.OrderByDescending (P => P.UnitPrice);
            //Result = from P in ProductsList
            //         orderby P.UnitPrice descending
            //         select P; 
            #endregion
            #region EX02
            //var Result = ProductsList.OrderBy(P => P.UnitPrice)
            //                         .ThenByDescending (P => P.UnitsInStock); 
            #endregion

            #region Ex03
            //var Result = ProductsList.Where(P => P.UnitsInStock == 0).Reverse();

            #endregion
            #endregion

            #region Elements

            #region Ex01
            //var Result = ProductsList.First();
            // Result = ProductsList.Last();
            //Result = ProductsList.FirstOrDefault();
            //Result = ProductsList.LastOrDefault(); 
            #endregion
            #region Ex02
            //var Result = ProductsList.First(P =>P.UnitsInStock==0);
            // Result = ProductsList.FirstOrDefault(P =>P.UnitsInStock==0); 
            #endregion
            #region Ex03
            //var Result = ProductsList.ElementAt(0);
            // Result = ProductsList.ElementAtOrDefault (0); 
            #endregion
            #region Ex04
            //var Result = ProductsList.Single();
            //var Result = ProductsList.Single(P => P.UnitPrice == 0);
            // Result = ProductsList.SingleOrDefault(P => P.UnitPrice == 0); 
            #endregion

            #region Ex05
            //var Result = (from P in ProductsList
            //              where P.UnitsInStock == 0
            //              select new
            //              {
            //                  P.ProductID,
            //                  P.ProductName,
            //                  P.UnitPrice
            //              }).FirstOrDefault(); 
            #endregion
            #endregion

            #region Aggregate
            #region Count
            //var Result = ProductsList.Count();
            //var Result = ProductsList.Count;
            //var Result = ProductsList.Count(P =>P.UnitsInStock==0); 
            #endregion
            #region Max-Min
            //var Result = ProductsList.Max();
            //Result = ProductsList.Min();
            //var Result = ProductsList.Max(P => P.ProductName.Length); 
            #endregion
            #region Sum -Average
            //var Result = ProductsList.Sum(P => P.UnitPrice);
            //var Result = ProductsList.Average(P => P.UnitPrice);
            #endregion
            #endregion

            #region Casting
            //var Result = ProductsList.Where(P => P.UnitsInStock==0).ToList();
            //var Result = ProductsList.Where(P => P.UnitsInStock==0).ToArray();
            //var Result = ProductsList.ToDictionary(P => P.ProductID);
            //var Result = ProductsList.ToDictionary(P => P.ProductID, P =>P.ProductName);
            //var Result = ProductsList.Where(P => P.UnitsInStock == 0).ToHashSet();

            //ArrayList arr = new ArrayList() { "Ahmed", "amr", 9, 3, 2, 7, "aya" };
            //var Result = arr.OfType<int>(); 
            #endregion

            #region Generation
            //var Result = Enumerable.Range(1, 100);
            //var Result = Enumerable.Repeat(2, 50);
            //var Result= Enumerable.Empty<Product>(); 
            #endregion

            #region Set
            //var Sq01 = Enumerable.Range(1, 100);
            //var Sq02 = Enumerable.Range(50, 100);
            //var Result = Sq01.Union(Sq02);
            //var Result = Sq01.Concat(Sq02);
            //var result= Result.Distinct();
            //var Result = Sq01.Intersect(Sq02);
            //var Result = Sq01.Except(Sq02); 
            #endregion

            #region Quentifier
            //var Result= ProductsList.Any();
            // Result= ProductsList.Any(P =>P.UnitPrice>500);
            // Result= ProductsList.All(P =>P.UnitPrice>3); 
            #endregion

            #region Zip
            //string[] Names = { "Ahmed", "amr", "Aya", "omar", "Kareem" };
            //int[] NUmbers = { 1, 2, 3, 4, 5 };
            //char[] Chars = { 'a', 'b', 'c', 'd' };

            //var Result = Names.Zip(NUmbers);
            //var Result = Names.Zip(NUmbers, Chars);
            //var Result = Names.Zip(NUmbers, (I, N) => new
            //{
            //    I=NUmbers,
            //    N=Names
            //}); 
            #endregion

            #region Group By
            #region Ex01
            //var Result = from P in ProductsList
            //             group P by P.Category;

            //Result = ProductsList.GroupBy(P => P.Category); 
            #endregion

            #region Ex02
            //var Result = from P in ProductsList
            //             where P.UnitsInStock > 10
            //             group P by P.Category
            //             into C
            //             where C.Count() > 10
            //             select C;
            //var Result = ProductsList.Where(P => P.UnitsInStock > 10).GroupBy(P => P.Category).Where(P => P.Count() > 10); 
            #endregion
            #endregion

            #region Partition
            //var Result = ProductsList.Take(10);
            //var Result = ProductsList.Skip(10);
            //var Result = ProductsList.TakeLast(10);
            //var Result = ProductsList.SkipLast(10);

            //int[] Numbers = { 1, 8, 7, 9, 3, 2, 5, 4, 6, 8 };
            //var Result = Numbers.TakeWhile(N => N <9);
            //var Result = Numbers.SkipWhile(N => N <9); 
            #endregion

            #region Let and Into
            //string[] Names = { "Ahmes", "OMar", "aya", "maye", "Kareem" };

            //var Result = from N in Names
            //             select Regex.Replace(N, "[AEOIUaeiou]", string.Empty)
            //             into Vowel
            //             where Vowel.Length > 0
            //             select Vowel; 
            //using let
            //var Result = from N in Names
            //             let Vowel= Regex.Replace(N, "[AEOIUaeiou]", string.Empty)
            //             where Vowel.Length > 0
            //             select Vowel;
            #endregion



            //foreach (var item in Result)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine(Result);
            //foreach (var Product in Result)
            //{
            //    Console.WriteLine(Product);
            //}
            //foreach (var Category in Result)
            //{
            //    Console.WriteLine(Category.Key);
            //    foreach(var Product in Category)
            //    {
            //        Console.WriteLine(Product);
            //    }
            //}
        }
    }
}
