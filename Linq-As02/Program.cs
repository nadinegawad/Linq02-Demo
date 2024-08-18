
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading;
using static Linq_As02.ListGenertor;
namespace Linq_As02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region LINQ - Restriction Operators
            #region Q01
            //var Result = ProductsList.Where(P => P.UnitsInStock == 0);
            #endregion

            #region Q02

            //var Result = ProductsList.Where(P => P.UnitsInStock> 0&& P.UnitPrice>3);

            #endregion

            #region Q03

            #endregion
            #endregion

            #region LINQ - Element Operators
            #region Q01
            //var Result = ProductsList.FirstOrDefault();
            #endregion

            #region Q02
            //var Result = ProductsList.FirstOrDefault(P =>P.UnitPrice>1000);
            #endregion

            #region Ex03
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = Arr.Where(P => P > 5).ElementAtOrDefault(1); 
            #endregion
            #endregion

            #region LINQ - Aggregate Operators
            #region Q01
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = Arr.Where(N => N % 2 != 0).Count();
            #endregion

            #region Q02
            //var Result = CustomersList.SelectMany(C => C.Orders).Count();
            #endregion

            #region Q03
            //var Result = ProductsList.Select((P, C) => new
            //{
            //    P.Category,
            //    Count= P.Category.Count()
            //});
            //Result = Result.Distinct(); 
            #endregion
            #region Q04
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = Arr.Sum(); 
            #endregion
            #region Q05
            //string[] str = File.ReadAllLines("dictionary_english.txt");
            //var Result = str.Select(S => S.Length).Sum(); 
            #endregion
            #region Q06
            //string[] str = File.ReadAllLines("dictionary_english.txt");
            //var Result = str.Select(S => S.Length).Min();
            #endregion

            #region Q07
            //string[] str = File.ReadAllLines("dictionary_english.txt");
            //var Result = str.Select(S => S.Length).Max();
            #endregion
            #region Q08
            //string[] str = File.ReadAllLines("dictionary_english.txt");
            //var Result = str.Select(S => S.Length).Average(); 
            #endregion

            #region Q09
            //var Result = ProductsList.Select(P => new
            //{
            //    P.Category,
            //    P.UnitsInStock
            //}); 
            #endregion
            #region Q10
            //var Result = ProductsList.Select(P => new
            //{
            //    P.Category,
            //    P.UnitPrice
            //});
            #endregion

            #endregion


            #region LINQ - Ordering Operators

            #region Q01
            //var Result = ProductsList.OrderBy(P => P.ProductName);
            #endregion
            #region Q03
            //var Result = ProductsList.OrderByDescending(P => P.UnitsInStock);

            #endregion

            #region Q04
            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            //var Result = Arr.OrderBy(P => P.Length).ThenBy(P=>P);
            #endregion
            #region Q05
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var Result = Arr.OrderBy(P => P.Length).ThenBy(word => word.ToLower());
            #endregion

            #region Q06
            //var Result = ProductsList.OrderBy(P => P.Category).ThenByDescending(P => P.UnitPrice);
            #endregion
            #region Q07
            //  String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //  var Result = Arr
            //.OrderBy(word => word.Length) 
            //.ThenByDescending(word => word.ToLower());
            #endregion


            #endregion

            #region LINQ – Transformation Operators

            #region Q01
            //var Result = ProductsList.Select(P => P.ProductName);
            #endregion
            #region Q02
            //String[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //var Result = words.Select(W => new
            //{
            //    Original = W,
            //    Upper = W.ToUpper(),
            //    Lower = W.ToLower(),
            //});
            #endregion
            #region Q03
            //var Result = ProductsList.Select(P => new
            //{
            //    P.ProductName,
            //    P.UnitsInStock,
            //    Price = P.UnitPrice
            //});
            #endregion

            #region Q04
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = Arr.Select((P, I) => new
            //{
            //    index = I,
            //    number = P
            //}).Where(P => P.index == P.number);

            #endregion

            #region Q05
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };
            //var Result = from A in numbersA
            //             from B in numbersB
            //             where A > B
            //             select new {A,B};
            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"{item.A} is less than {item.B}");
            //}
            #endregion

            #region Q06
            //var Result = CustomersList.SelectMany(C => C.Orders);
            #endregion

            #region Q07
            //var Result = CustomersList.SelectMany(C => C.Orders).Where(P=>P.OrderDate.Date.Year>= 1998);

            #endregion

            #endregion

            #region LINQ - Set Operators
            #region Q01
            //var Result = ProductsList.Select(P => P.Category).Distinct();
            #endregion

            #region Q02
            //var PName = ProductsList.Select(P => P.ProductName).FirstOrDefault();
            //var CName = CustomersList.Select(C => C.CustomerName).FirstOrDefault();
            //var Result=PName.Concat(CName);
            #endregion

            #region Q03
            //var PName = ProductsList.Select(P => P.ProductName).FirstOrDefault();
            //var CName = CustomersList.Select(C => C.CustomerName).FirstOrDefault();
            //var Result = PName.Intersect(CName);
            #endregion
            #region Q04
            //var PName = ProductsList.Select(P => P.ProductName).FirstOrDefault();
            //var CName = CustomersList.Select(C => C.CustomerName).FirstOrDefault();
            //var Result = PName.Except(CName);
            #endregion
            #region Q05
            //var PName = ProductsList.Select(P => P.ProductName.Length >= 3 ? P.ProductName.Substring(P.ProductName.Length - 3) : P.ProductName);
            //var CName = CustomersList.Select(C => C.CustomerName.Length >= 3 ? C.CustomerName.Substring(C.CustomerName.Length - 3) : C.CustomerName);
            //var Result = PName.Except(CName);
            #endregion
            #endregion

            #region LINQ - Partitioning Operators
            #region Q01
            //var Result = CustomersList.Where(C => C.City == "Washington").Take(5); 
            #endregion

            #region Q02
            //var Result = CustomersList.Where(C => C.City == "Washington").SelectMany(C=>C.Orders).Skip(2);

            #endregion

            #region Q03
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            #endregion

            #region Q4
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = numbers.TakeWhile(N=>N%3==0);
            #endregion
            #region Q5
            //  int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //  var Result = numbers
            //.Select((value, index) => new { value, index })
            //.SkipWhile(x => x.value >= x.index)
            //.Select(x => x.value);

            #endregion
            #endregion

            #region LINQ - Quantifiers
            #region Q01
            //string[] str = File.ReadAllLines("dictionary_english.txt");
            //var Result = str.Any(word => word.Contains("ei")); 
            #endregion
            #region Q02
            //var Result = ProductsList.Where(P => P.UnitsInStock >= 1).Select(P => P.Category).Distinct();
            #endregion
            #region Q03
            //var Result = ProductsList.Where(P => P.UnitsInStock > 0).Select(P => P.Category).Distinct();
            #endregion

            #endregion

            #region LINQ – Grouping Operators
            #region Q01
            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            //var Result = numbers.GroupBy(N => N % 5);
            #endregion
            #region Q02

            #endregion
            #endregion
            //Console.WriteLine(Result);
            foreach (var Product in Result)
            {
                Console.WriteLine(Product);
            }

        }
    }
}
