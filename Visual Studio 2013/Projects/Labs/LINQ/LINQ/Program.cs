using System;
using System.Data.Common;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;

namespace LINQ
{
    class Program
    {
        /* Practice your LINQ!
         * You can use the methods in Data Loader to load products, customers, and some sample numbers
         * 
         * NumbersA, NumbersB, and NumbersC contain some ints
         * 
         * The product data is flat, with just product information
         * 
         * The customer data is hierarchical as customers have zero to many orders
         */
        static void Main()
        {
            //foreach (Product p in DataLoader.LoadProducts())
            //{
            //    Console.WriteLine(p.ProductName);
            //}

            //foreach (Customer c in DataLoader.LoadCustomers())
            //{
            //    Console.WriteLine(c.CompanyName);
            //}
            //PrintOutOfStock_1();
            //OutOfStockMoreThanThree_2();
            //AllCustInWash_3();
            //NewSequence_4();
            //ProductAndUnit_5();
            //ProductNameUpperCase_6();
            //ProductEvenNumbers_7();
            //PnameCategoryRename_8();
            //PairsOfNumbrs_9();
            //CustomerOrderIDTotalLess500_10();
            //FirstThreeElements_11();
            //FirstThreeOrdersInWash_12();
            //SkipFirstThree_13();
            //FirstTwoOrdersInWash_14();
            //ElementsInCFromBeg_15();
            //BegNumberCLessPosition_16();
            //NumbersCFromFirstDiv3_17();
            //OrderByName_18();
            //ProductsByInStock_19();
            //CategoryUnitPriceHighToLow_20();
            //ReverseNumbersC_21();
            //NumbersCGroupByR5_22();
            //ProductsByCategory_23();
            //OrderByYearMonth_24();
            //ListByUniqueProduct_25();
            //ListByUniqueValue_26();
            //ListBySharedValue_27();
            //ListByNotSharedValue_28();
            //FirstProduct12_29();
            //Product789_30();
            //OutOfStockCat_31();
            //NumbersBLess9_32();
            CategoryInStock_33();
        


            //Console.ReadLine();
        }

        //static void PrintOutOfStock_1()
        //{
        //    var products = DataLoader.LoadProducts();

        //    var outOfStock = products.Where(p => p.UnitsInStock == 0);

        //    Console.WriteLine("Out of stock: ");
        //    foreach (var p in outOfStock)
        //    {
        //        Console.WriteLine(p.ProductName);
        //    }

        //    Console.Write("Press enter to continue");
        //    Console.ReadLine();
        //}

        //static void OutOfStockMoreThanThree_2()
        //{
        //    var products = DataLoader.LoadProducts();

        //    var inStock = products.Where(p => p.UnitsInStock != 0 && p.UnitPrice > 3.00M);

        //    Console.WriteLine("In stock and over $3 ");
        //    foreach (var p in inStock)
        //    {
        //        Console.WriteLine(p.ProductName);
        //    }

        //    Console.Write("Press enter to continue");
        //    Console.ReadLine();
        //}

        //static void AllCustInWash_3()
        //{
        //    var products = DataLoader.LoadProducts();

        //    var result = customers.Where(c => c.Region =="WA");

        //        Console.WriteLine("Here are the Washington Customers and their orders ");
        //        foreach (var order in result)
        //        {
        //            Console.WriteLine(c.CompanyName);
        //            foreach (var  in )
        //            {
        //                Console.WriteLine();
        //            }
        //            Console.WriteLine(order.OrderID);
        //        }
        //        Console.WriteLine("*********************");

        //    Console.Write("Press enter to continue");
        //    Console.ReadLine();
        //}

        //static void NewSequence_4()
        //{
        //    var products = DataLoader.LoadProducts();

        //    var result = products.Select(p => new
        //    {
        //        p.ProductName
        //    });

        //    foreach (var r in result)
        //    {
        //        Console.WriteLine(r.ProductName);
        //    }


        //    Console.Write("Press enter to continue");
        //    Console.ReadLine();
        //}

        //static void ProductAndUnit_5()
        //{
        //    var products = DataLoader.LoadProducts();

        //    var result = products.Select(p => new
        //    {
        //        p.ProductName, UnitPrice = p.UnitPrice*1.25M
        //    });

        //    foreach (var r in result)
        //    {
        //        Console.WriteLine("The new price of {0} is {1:C}", r.ProductName, r.UnitPrice);
        //    }
        //    Console.Write("Press enter to continue");
        //    Console.ReadLine();
        //}

        //static void ProductNameUpperCase_6()
        //{
        //    var products = DataLoader.LoadProducts();

        //    var result = products.Select(p => new {ProductName = p.ProductName.ToUpper()});

        //    var caps = products;

        //    foreach (var r in result)
        //    {
        //        Console.WriteLine(r.ProductName);
        //    }
        //    Console.Write("Press enter to continue");
        //    Console.ReadLine();
        //}

        //static void ProductEvenNumbers_7()
        //{
        //    var products = DataLoader.LoadProducts();

        //    var result = products.Where(p => p.UnitsInStock%2 ==0);

        //    foreach (var r in result)
        //    {
        //        Console.WriteLine(r.ProductName);
        //    }
        //    Console.Write("Press enter to continue");
        //    Console.ReadLine();
        //}



        //static void PnameCategoryRename_8()
        //{
        //    var products = DataLoader.LoadProducts();

        //    var result = products.Select(p => new {p.ProductName, p.Category, Price = p.UnitPrice});

        //    foreach (var r in result)
        //    {
        //        Console.WriteLine(r.Price);
        //    }
        //    Console.Write("Press enter to continue");
        //    Console.ReadLine();
        //}


        // 9. Make a query that returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.
        //static void PairsOfNumbrs_9()
        //{
        //    var pairs = from num in DataLoader.NumbersA
        //                 from num2 in DataLoader.NumbersB
        //                 where num < num2 select new {num, num2};

        //    foreach (var num in pairs)
        //    {
        //        Console.WriteLine(num);
        //    }
        //    Console.Write("Press enter to continue");
        //    Console.ReadLine();
        //}

        //10. Select CustomerID, OrderID, and Total where the order total is less than 500.00.
        //static void CustomerOrderIDTotalLess500_10()
        //{
        //    var customers = DataLoader.LoadCustomers();

        //    var result = from c in customers
        //                 from o in c.Orders
        //                 where o.Total < 500
        //                 select new { c.CustomerID, o.OrderID, o.Total };

        //    foreach (var entry in result)
        //    {
        //        Console.WriteLine(entry);
        //    }
        //    Console.ReadLine();
        //}

        //11. Write a query to take only the first 3 elements from NumbersA.
        //static void FirstThreeElements_11()
        //{
        //    var result = DataLoader.NumbersA.Take(3);

        //    foreach (var r in result)
        //    {
        //        Console.WriteLine(r);
        //    }
        //    Console.ReadLine();
        //}

        //12. Get only the first 3 orders from customers in Washington.
        //static void FirstThreeOrdersInWash_12()
        //{
        //    var customers = DataLoader.LoadCustomers();

        //    var set = (from c in customers
        //              from o in c.Orders
        //              where c.Region == "WA"
        //              select new {o.OrderID}).Take(3);

        //    foreach (var s in set)
        //    {
        //        Console.WriteLine(s);
        //    }
        //    Console.ReadLine();
        //}

        //13. Skip the first 3 elements of NumbersA.
        //static void SkipFirstThree_13()
        //{
        //    var result = DataLoader.NumbersA.Skip(3);

        //    foreach (var r in result)
        //    {
        //        Console.WriteLine(r);
        //    }
        //    Console.ReadLine();
        //}

        //14. Get all except the first two orders from customers in Washington.
        //static void FirstTwoOrdersInWash_14()
        //{
        //    var customers = DataLoader.LoadCustomers();

        //    var set = (from c in customers
        //               from o in c.Orders
        //               where c.Region == "WA"
        //               select new { o.OrderID }).Skip(2);

        //    foreach (var s in set)
        //    {
        //        Console.WriteLine(s);
        //    }
        //    Console.ReadLine();
        //}

        //15. Get all the elements in NumbersC from the beginning until an element is greater or equal to 6.
        //static void ElementsInCFromBeg_15()
        //{
        //    var result = DataLoader.NumbersC.TakeWhile(n => n < 6);

        //    foreach (var n in result)
        //    {
        //        Console.WriteLine(n);
        //    }
        //    Console.ReadLine();
        //}

        //16. Return elements starting from the beginning of NumbersC until a number is hit that is less than its position in the array.
        //static void BegNumberCLessPosition_16()
        //{
        //    var result = DataLoader.NumbersC.TakeWhile(n => n > Array.IndexOf(DataLoader.NumbersC, n));

        //    foreach (var n in result)
        //    {
        //        Console.WriteLine(n);
        //    }
        //    Console.ReadLine();
        //}

        //17. Return elements from NumbersC starting from the first element divisible by 3.
        //static void NumbersCFromFirstDiv3_17()
        //{
        //    var result = DataLoader.NumbersC.SkipWhile(num => num%3 != 0);

        //    foreach (var r in result)
        //    {
        //        Console.WriteLine(r);
        //    }
        //    Console.ReadLine();
        //}

        //18. Order products alphabetically by name.
        //static void OrderByName_18()
        //{
        //    var products = DataLoader.LoadProducts();

        //    var result = products.OrderBy(x => x.ProductName);

        //    foreach (var r in result)
        //    {
        //        Console.WriteLine(r.ProductName);
        //    }
        //    Console.ReadLine();
        //}

        //19. Order products by UnitsInStock descending.
        //static void ProductsByInStock_19()
        //{
        //    var products = DataLoader.LoadProducts();

        //    var result = products.OrderByDescending(p => p.ProductName);

        //    foreach (var r in result)
        //    {
        //        Console.WriteLine(r.ProductName);
        //    }
        //    Console.ReadLine();
        //}

        //20. Sort the list of products, first by category, and then by unit price, from highest to lowest.
        //static void CategoryUnitPriceHighToLow_20()
        //{
        //    var products = DataLoader.LoadProducts();

        //    var result = ((products.OrderBy(x => x.Category)).ThenByDescending(x => x.UnitPrice));

        //    foreach (var r in result)
        //    {
        //        Console.WriteLine(r.Category + "  " + r.UnitPrice);
        //    }
        //    Console.ReadLine();
        //}

        //21. Reverse NumbersC.
        //static void ReverseNumbersC_21()
        //{
        //    var result = DataLoader.NumbersC.Reverse();

        //    foreach (var r in result)
        //    {
        //        Console.WriteLine(r);
        //    }
        //    Console.ReadLine();
        //}

        //22. Display the elements of NumbersC grouped by their remainder when divided by 5.
        //static void NumbersCGroupByR5_22()
        //{
        //    var result = DataLoader.NumbersC.GroupBy(num => num%5);

        //    foreach (var group in result)
        //    {
        //        Console.WriteLine(group);
        //    }
        //    Console.ReadLine();
        //}

        //23. Display products by Category
        //static void ProductsByCategory_23()
        //{
        //    var products = DataLoader.LoadProducts();

        //    var result = products.GroupBy(x => x.Category);

        //    foreach (var group in result)
        //    {
        //        foreach (var g in group)
        //        {
        //            Console.WriteLine(g.Category + "  " + g.ProductName);
        //        }
        //    }
        //    Console.ReadLine();
        //}

        //24. Group customer orders by year, then by month.
        //static void OrderByYearMonth_24()
        //{
        //    var customer = DataLoader.LoadCustomers();

        //    var result = (from c in customer
        //                 from o in c.Orders 
        //                 select new {c.CustomerID, o.OrderDate}).OrderBy(x => x.OrderDate.Year).ThenBy(x => x.OrderDate.Month);              

        //    foreach (var r in result)
        //    {
        //        Console.WriteLine(r.CustomerID + "  "  + r.OrderDate);
        //    }
        //    Console.ReadLine();
        //}

        //25. Create a list of unique product category names.
        //static void ListByUniqueProduct_25()
        //{
        //    var products = DataLoader.LoadProducts();

        //    var result = (from p in products
        //                  select p.Category).Distinct();

        //    foreach (var r in result)
        //    {
        //        Console.WriteLine(r);
        //    }
        //    Console.ReadLine();
        //}

        //26. Get a list of unique values from NumbersA and NumbersB.
        //static void ListByUniqueValue_26()
        //{
        //    var result = (DataLoader.NumbersA.Union(DataLoader.NumbersB)).Distinct();

        //    foreach (var r in result)
        //    {
        //        Console.WriteLine(r);
        //    }
        //    Console.ReadLine();
        //}

        //27. Get a list of the shared values from NumbersA and NumbersB.
        //static void ListBySharedValue_27()
        //{
        //    var result = (DataLoader.NumbersA.Intersect( DataLoader.NumbersB));

        //    foreach (var r in result)
        //    {
        //        Console.WriteLine(r);
        //    }
        //    Console.ReadLine();
        //}

        //28. Get a list of values in NumbersA that are not also in NumbersB.
        //static void ListByNotSharedValue_28()
        //{
        //    var result = DataLoader.NumbersA.Intersect(DataLoader.NumbersB);

        //    foreach (var r in result)
        //    {
        //        Console.WriteLine(r);
        //    }
        //    Console.ReadLine();
        //}

        //29. Select only the first product with ProductID = 12 (not a list).
        //static void FirstProduct12_29()
        //{
        //    var products = DataLoader.LoadProducts();

        //    var result = products.First(x => x.ProductID == 12);
            
        //    Console.WriteLine(result.ProductName);
            
        //    Console.ReadLine();
        //}

        //30. Write code to check if ProductID 789 exists.
        //static void Product789_30()
        //{
        //    var products = DataLoader.LoadProducts();

        //    var result = products.Exists(x => x.ProductID == 789);

        //    Console.WriteLine(result);
            
        //    Console.ReadLine();
        //}

        //31. Get a list of categories that have at least one product out of stock.
        //static void OutOfStockCat_31()
        //{
        //    var products = DataLoader.LoadProducts();

        //    var result = (from p in products
        //                  where p.UnitsInStock.Equals(0)
        //                  select p);
            
        //    foreach (var r in result)
        //    {
        //        Console.WriteLine(r.UnitsInStock + r.ProductName);
        //    }
            
        //    Console.ReadLine();
        //}

        //32. Determine if NumbersB contains only numbers less than 9.
        //static void NumbersBLess9_32()
        //{
        //    var result = DataLoader.NumbersB.Where(i => i <= 9);
               
        //    foreach (var r in result)
        //    {
        //        Console.WriteLine(r);
        //    }

        //    Console.ReadLine();
        //}

        //33. Get a grouped a list of products only for categories that have all of their products in stock.
        static void CategoryInStock_33()
        {
            var products = DataLoader.LoadProducts();

            var result = from p in products
                group p by p.Category
                into g
                where g.All(pr => pr.UnitsInStock > 0)
                select new
                {
                    categoryName = g.Key, products = g
                };
               

           foreach (var r in result)
            {
                Console.WriteLine(r.categoryName);
                foreach (var product in r.products)
                {
                    Console.WriteLine("  " + product.ProductName);
                }
            }

            Console.ReadLine();
        }
       

    }
}
