namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)//task23
        {
            var lista = new string[] { "x", "y", "z" };
            var listb = new string[] { "1", "2", "3" };


            var carteslist = lista.SelectMany(x => listb.Select(y => new { letter = x, num = y }));

            foreach (var item in carteslist)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("========================================================================================");
            //task24

            var lista1 = new string[] { "x", "y", "z" };
            var listb1 = new string[] { "1", "2","3"};
            var listc1 = new string[] { "yellow", "green", "blue" };


            var carteslist1 = lista1.SelectMany(x => listb1.SelectMany(y=>listc1.Select(z=> new { letter = x, num = y, color=z }          )));

            foreach (var item in carteslist1)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("========================================================================================");
            //task25



            var items = new[] {
    
                   new  { ItemId = 1, ItemDes = "Biscuit  " },
           new  { ItemId = 2, ItemDes = "Chocolate" },
           new  { ItemId = 3, ItemDes = "Butter   " },
           new  { ItemId = 4, ItemDes = "Brade    " },
           new  { ItemId = 5, ItemDes = "Honey    " }

                            };


            var purchases = new[]
                {
            new  { InvNo=100, ItemId = 3,  PurQty = 800 },
           new  { InvNo=101, ItemId = 2,  PurQty = 650 },
           new  { InvNo=102, ItemId = 3,  PurQty = 900 },
           new  { InvNo=103, ItemId = 4,  PurQty = 700 },
           new  { InvNo=104, ItemId = 3,  PurQty = 900 },
           new  { InvNo=105, ItemId = 4,  PurQty = 650 },
           new { InvNo=106, ItemId = 1,  PurQty = 458 }

                                 };


            var results = items.Join(purchases,
                                arg => arg.ItemId, 
                                arg=>arg.ItemId ,      
                                (items,purchases) => new { items.ItemId,items.ItemDes,purchases.PurQty });
            foreach (var item in results)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("========================================================================================");

            //task26
            var results1 = items.GroupJoin(purchases,

                              arg => arg.ItemId,
                            arg => arg.ItemId,
                              (items, purchases) => new { item=items, Purchase=purchases }).SelectMany(arg => arg.Purchase.DefaultIfEmpty(), (items, purchases) => new { items.item,Purchase=purchases });
                                                                                         
            foreach (var item in results1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("========================================================================================");
            //task27

            var rightOuterJoin = (items.GroupJoin(purchases, left => left.ItemId, right => right.ItemId, (left, right) => new {
                TableA = right,
                TableB = left
            }).SelectMany(p => p.TableA.DefaultIfEmpty(), (x, y) => new {
                Item = y,
                Purchase = x.TableB
            }));

            foreach(var item in rightOuterJoin)
            { Console.WriteLine(item); }
            Console.WriteLine("========================================================================================");

            //task28
            string[] cities =
            {
                "ROME","LONDON","NAIROBI","CALIFORNIA","ZURICH","NEW DELHI","AMSTERDAM","ABU DHABI", "PARIS"
            };

             var citiesChanged= cities.OrderBy(cities => cities.Length).ThenBy(cities => cities);

            foreach(var item in citiesChanged)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("========================================================================================");
            //task29

            int chunksize = 2;
            var citiesGroups=cities.Select((x, i) => new { Index = i, Value = x })
            .GroupBy(x => x.Index / chunksize)
            .Select(x => x.Select(v => v.Value).ToList())
            .ToList();


            foreach (var item in citiesGroups)
            {
                Console.WriteLine(string.Join(',',item));

            }

            Console.WriteLine("========================================================================================");
            //task30
            var listelem = new List<string>()
            {
                "brock","apple","brock","bomb","appollo","certificate","elephat","appollo","mapping","biscuit","cake","cake","bomb","elephat"
            };


            var disctelems = listelem.OrderBy(x => x).Distinct();

            foreach(var item in disctelems)
            {
                Console.WriteLine(item);
            }
        }




    }
}