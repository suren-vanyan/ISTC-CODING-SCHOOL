using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace OOP.LINQToObjects.BoxHeavyweight
{
    class Program
    {
        public static void GetTallBoxers(List<Boxer> boxersList)
        {
            // deferred execution
            var boxerSortingByHeight = from i in boxersList where i.Height > 200 select i;//Sorting boxer by Height 

            // immediate execution
            List<Boxer> boxerSortingByHeightToList = boxersList.Where(n => n.Height > 200).ToList<Boxer>();//ToList();
            foreach (var item in boxerSortingByHeightToList)
            {
                Console.WriteLine($"FirstName:{item.FirstName},LastName:{item.LastName},Height:{item.Height}");
            }
            Console.WriteLine();
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static void SortBoxersByAge(List<Boxer> boxersList)
        {
            //Sorting by Age,start sort by  ascending (by default),after descending
            // deferred execution
            var boxerSortingByAge = boxersList.Where(n => n.Age > 50).OrderBy(n => n.FirstName).OrderByDescending(n=>n.LastName);

            //immediate execution
            Boxer[] boxerSortingByAgeToArray = boxersList.Where(n => n.Age > 55).OrderBy(n => n.Age).ToArray<Boxer>();
            foreach (var item in boxerSortingByAgeToArray)
            {
                Console.WriteLine($"FirstName:{item.FirstName},LastName:{item.LastName},Age:{item.Age}");
            }
            Console.WriteLine();

            //use static Metod
            var boxerSorting = Enumerable.Select(boxersList, (n => n.Age > 60 && n.Died == false));
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public static void NonGenericCollection()
        {
            ArrayList boxersList = new ArrayList()
           {
               new Boxer{FirstName="Muhammad",LastName="Ali",Age=74,Died=true,Height=191,Nationality="USA",Wins=56},
               new Boxer{FirstName="George",LastName="Foreman",Age=69,Died=false,Height=192,Nationality="USA",Wins=76},
               new Boxer{FirstName="Joe",LastName="Frazier",Age=67,Died=true,Height=182,Nationality="USA",Wins=32},
               new Boxer{FirstName="Mike",LastName="Tyson",Age=52,Died=false,Height=178,Nationality="USA",Wins=50},
               new Boxer{FirstName="Evander",LastName="Holyfield",Age=56,Died=false,Height=189,Nationality="USA",Wins=44},
              
           };

            IEnumerable<Boxer> boxers = boxersList.OfType<Boxer>();
            var boxerSortingByWins = boxers.Where(n => n.Wins > 40);
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        public static Array  GetNewAnonymousDataTypes(List<Boxer> boxersList)
        {

            var boxers = (from boxer in boxersList select new { boxer.FirstName, boxer.LastName, boxer.Nationality }).ToArray();
           
            return boxers;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public static void GetCountFromQuery(List<HeavyweightChampions> heavyweightChampionsList)
        {
            int countbyNationality = (from champ in heavyweightChampionsList where champ.Nationality == "USA" select champ).Count();
            Console.WriteLine(countbyNationality);

           
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////       
        public static void DisplayDiffAndIntersection(List<Boxer> boxersList,List<HeavyweightChampions> championsList)
        {
            //Array newchampionsList =( from champ in championsList select new { champ.FirstName, champ.LastName, champ.Nationality }).ToArray();
            //Array newBoxersList = (from boxer in boxersList select new { boxer}).ToArray();
            //var diff = (from boxer in newBoxersList select boxer).C(from champion in newchampionsList select champion);
            List<Boxer> firstBoxersList = new List<Boxer> { boxersList[0], boxersList[1], boxersList[2] };
            List<Boxer> secondBoxersList = new List<Boxer> { boxersList[3], boxersList[0], boxersList[4] };
    
            var except = (from n in firstBoxersList select n).Except(from n in secondBoxersList select n);//result Forman,Freizer
          
            var except2 = (from n in secondBoxersList select n).Except(from n in firstBoxersList select n);
           
            var intersect = firstBoxersList.Select(n => n).Intersect(secondBoxersList.Select(n => n));
            intersect.ToList().ForEach(n => Console.WriteLine(n));

            var union = (from n in firstBoxersList select n).Union(from n in secondBoxersList select n);



        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public static void AggregateFunctions(List<Boxer> boxers)
        {

        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        static void Main(string[] args)
        {
            List<Boxer> boxersList = new List<Boxer>
           {
               new Boxer{FirstName="Muhammad",LastName="Ali",Age=74,Died=true,Height=191,Nationality="USA",Wins=56},
               new Boxer{FirstName="George",LastName="Foreman",Age=69,Died=false,Height=192,Nationality="USA",Wins=76},
               new Boxer{FirstName="Joe",LastName="Frazier",Age=67,Died=true,Height=182,Nationality="USA",Wins=32},
               new Boxer{FirstName="Mike",LastName="Tyson",Age=52,Died=false,Height=178,Nationality="USA",Wins=50},
               new Boxer{FirstName="Evander",LastName="Holyfield",Age=56,Died=false,Height=189,Nationality="USA",Wins=44},
                new Boxer{FirstName="Riddick",LastName="Bowe",Age=56,Died=false,Height=196,Nationality="USA",Wins=43},
               new Boxer{FirstName="Lennox",LastName="Lewis",Age=53,Died=false,Height=196,Nationality="Canada",Wins=41},
               new Boxer{FirstName="Vladimir",LastName="Klitschko",Age=42,Died=false,Height=198,Nationality="Ukraine",Wins=64},
               new Boxer{FirstName="Deontay",LastName="Wilder",Age=33,Died=false,Height=201,Nationality="USA",Wins=40},
               new Boxer{FirstName="Tyson",LastName="Fury",Age=30,Died=false,Height=205,Nationality="UK",Wins=27},
               new Boxer{FirstName="Anthony",LastName="Joshua",Age=29,Died=false,Height=198,Nationality="UK",Wins=22},

           };

            List<HeavyweightChampions> championsList = new List<HeavyweightChampions>
            {
                 new HeavyweightChampions{FirstName="Muhammad",LastName="Ali",Nationality="Ukraine",
                    SancBody =new List<SanctioningBody>{SanctioningBody.WBC,SanctioningBody.WBA,SanctioningBody.NYSAC}},
                new HeavyweightChampions{FirstName="Vladimir",LastName="Klitschko",Nationality="Ukraine",
                    SancBody =new List<SanctioningBody>{SanctioningBody.WBA,SanctioningBody.IBF,SanctioningBody.WBO}},
                new HeavyweightChampions{FirstName="Lennox",LastName="Lewis",Nationality="Canada",
                    SancBody =new List<SanctioningBody>{SanctioningBody.WBA,SanctioningBody.WBC,SanctioningBody.IBF}},
                new HeavyweightChampions{FirstName="Evander",LastName="Holyfield",Nationality="USA",
                    SancBody =new List<SanctioningBody>{SanctioningBody.WBA,SanctioningBody.IBF,SanctioningBody.WBC}},
                new HeavyweightChampions{FirstName="Vladimir",LastName="Klitschko",Nationality="Ukraine",
                    SancBody =new List<SanctioningBody>{SanctioningBody.WBA,SanctioningBody.IBF,SanctioningBody.WBO}},
                new HeavyweightChampions{FirstName="Joe",LastName="Frazier",Nationality="Ukraine",
                    SancBody =new List<SanctioningBody>{SanctioningBody.WBA,SanctioningBody.NYSAC,SanctioningBody.WBC}},
                  new HeavyweightChampions{FirstName="Mike",LastName="Tyson",Nationality="Ukraine",
                    SancBody =new List<SanctioningBody>{SanctioningBody.WBA,SanctioningBody.WBC,SanctioningBody.IBF}},

            };


            // Query expressions
            //Sort boxersList
            GetTallBoxers(boxersList);

            SortBoxersByAge(boxersList);

            NonGenericCollection();

            ////this is a bad approach
            var boxersListToArray = GetNewAnonymousDataTypes(boxersList);
            foreach (var item in boxersListToArray)
            {
                Console.WriteLine(item);
            }

            GetCountFromQuery(championsList);

            DisplayDiffAndIntersection(boxersList, championsList);


            // The truth of the matter, however, is that when compiled, 
            //the C# compiler actually translates all C# LINQ  operators into calls on methods of the Enumerable class.

            // LINQ Query Statements
            QueryStringsWithEnumerableAndLambdas(boxersList,championsList);
        }

        public static void QueryStringsWithEnumerableAndLambdas(List<Boxer> boxersList,List<HeavyweightChampions> championsList)
        {
            var newBoxersList = boxersList.Where(n => n.Age > 50).OrderBy(n => n.FirstName).Select(n=>new {  n.FirstName,n.LastName });//create anonymous

            var boxersgroupBy = from boxer in boxersList
                                where boxer.Age > 20 && boxer.Age < 40
                                group boxer by boxer.Nationality;

            var boxersgroupBy2 = boxersList.Where(n => n.Age < 40).GroupBy(n => n.Nationality);

            foreach (IGrouping<string,Boxer> group in boxersgroupBy)
            {
                Console.WriteLine(group.Key);
                foreach (var item in group)
                {
                    Console.WriteLine(item);//need override Tostring
                }
            }

            //cretaet new anonymous type Use Join and into keyword
            var jointwoLists = from boxer in boxersList
                            join champ in championsList
                            on boxer.LastName equals champ.LastName
                            select new { boxer.FirstName, champ.LastName, champ.SancBody, boxer.Wins }
                         into temp
                            where temp.Wins > 40
                            select temp;

           

        }
    }
}
