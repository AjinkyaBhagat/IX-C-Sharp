using System;
using System.Collections.Generic;
namespace GenericCollection
{
    internal class Program
    {
        class Car
        {
            public int Id { get; set; }
            public string CarName { get; set; }
            public int Price { get; set; }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("*List*");
            Console.WriteLine("-------------------------");
            //Creating List Of String type
            List<string> bike = new List<string>();
            bike.Add("Yamaha");
            bike.Add("Honda");
            bike.Add("Hero");
            bike.Add("Ather");
            bike.Add("Ola");
            bike.Add("RoyalEnfield");
            bike.Add(null);
            
            foreach (string s in bike)
            {
                Console.WriteLine(s);
            }
            //Sort
            bike.Sort();
            foreach (string s in bike)
            {
                Console.WriteLine(s);
            }
            //Contains
            Console.WriteLine(bike.Contains("Honda"));

            //Object Creation
            Car car1 = new Car()
            {
                Id = 1,
                CarName = "Swift",
                Price = 1000000,
            };
            Car car2 = new Car()
            {
                Id = 2,
                CarName = "Verna",
                Price = 2000000,
            };
            Car car3 = new Car()
            {
                Id = 3,
                CarName = "Ciaz",
                Price = 3000000,
            };
            
            //Object Type List
            List<Car> carlist = new List<Car>();
            carlist.Add(car1);
            carlist.Add(car2);  
            carlist.Add(car3);

            //Accessing list with Indexing
            Car c1 = carlist[0];
            Car c2 = carlist[1];
            Console.WriteLine("ID={0}, Carname={1}, Price={2}",c1.Id,c1.CarName,c1.Price);
           
            //Accessing list with foreach loop
            foreach(Car car in carlist)
            {
                Console.WriteLine("ID={0}, Carname={1}, Price={2}",car.Id,car.CarName,car.Price);
            }

            //Insert 
            carlist.Insert(0,car3);
            foreach (Car car in carlist)
            {
                Console.WriteLine("ID={0}, Carname={1}, Price={2}", car.Id, car.CarName, car.Price);
            }

            //IndexOf
            Console.WriteLine(carlist.IndexOf(car3));

            //Remove
             carlist.Remove(car3);
            foreach (Car car in carlist)
            {
                Console.WriteLine("ID={0}, Carname={1}, Price={2}", car.Id, car.CarName, car.Price);
            }
            //RemoveAt
            carlist.RemoveAt(2);
            foreach (Car car in carlist)
            {
                Console.WriteLine("ID={0}, Carname={1}, Price={2}", car.Id, car.CarName, car.Price);
            }
            //Add Range
            List<Car> newList = new List<Car>();
            newList.Add(car1);
            newList.Add(car2);
            carlist.AddRange(newList);
            foreach (Car car in carlist)
            {
                Console.WriteLine("ID={0}, Carname={1}, Price={2}", car.Id, car.CarName, car.Price);
            }

            ////RemoveRange
            //carlist.RemoveRange(0,3);
            //foreach (Car car in carlist)
            //{
            //    Console.WriteLine("ID={0}, Carname={1}, Price={2}", car.Id, car.CarName, car.Price);
            //}

            //Dictionary
            Console.WriteLine("----------------------------");
            Console.WriteLine("*Dictionary*");
            Console.WriteLine("----------------------------");
            Dictionary<int,string> bikeModels = new Dictionary<int,string>();
            bikeModels.Add(101, "Shine");
            bikeModels.Add(102, "Pulser");
            bikeModels.Add(103, "Apache");
            bikeModels.Add(104, "Dominar");

            //Accessing using key
            Console.WriteLine(bikeModels[104]);
            
            foreach(KeyValuePair<int,string> bmObj in bikeModels)
            {
                Console.WriteLine("key={0}, Value={1}",bmObj.Key,bmObj.Value);
            }

            //ContainsKey
            Console.WriteLine(bikeModels.ContainsKey(102));

            //TryGetValue
            string isPresent;
            if(bikeModels.TryGetValue(104, out isPresent)){
                Console.WriteLine(isPresent);
            }

            //Remove
            bikeModels.Remove(103);
            foreach (KeyValuePair<int, string> bmObj in bikeModels)
            {
                Console.WriteLine("key={0}, Value={1}", bmObj.Key, bmObj.Value);
            }
            //Update the value of the key
            bikeModels[102] ="KTM-200";
            foreach (KeyValuePair<int, string> bmObj in bikeModels)
            {
                Console.WriteLine("key={0}, Value={1}", bmObj.Key, bmObj.Value);
            }

            Console.WriteLine("--------------------------");
            Console.WriteLine("*SortedList*");
            Console.WriteLine("--------------------------");
            SortedList<int,string> food = new SortedList<int,string>();
            food.Add(30, "Pasta");
            food.Add(10, "Burgur");
            food.Add(20, "Pizza");
            food.Add(40, "Momos");

            foreach(KeyValuePair<int,string> foodObj in food)
            {
                Console.WriteLine(foodObj);
            }
            //Accesing all elements
            food.Add(50,"Biryani");
            foreach (KeyValuePair<int, string> foodObj in food)
            {
                Console.WriteLine("key={0}, Food={1}",foodObj.Key,foodObj.Value);
            }
            //Accessing using key
            Console.WriteLine(food[30]);

            //ContainsKey
            if (food.ContainsKey(10))
            {
                Console.WriteLine(food[10]);
            }
            //TryGetValue
            string r;
            if (food.TryGetValue(80, out r))
            {
                Console.WriteLine(r);
            }
            else
            {
                Console.WriteLine("Sorry key not found");
            }
            //Remove
            var val=food.Remove(20);
            Console.WriteLine(val);
            foreach (KeyValuePair<int, string> foodObj in food)
            {
                Console.WriteLine("key={0}, Food={1}", foodObj.Key, foodObj.Value);
            }
            //RemoveAt
            food.RemoveAt(2);
            foreach (KeyValuePair<int, string> foodObj in food)
            {
                Console.WriteLine("key={0}, Food={1}", foodObj.Key, foodObj.Value);
            }


            Console.WriteLine("--------------------------");
            Console.WriteLine("*Stack*");
            Console.WriteLine("--------------------------");
            Stack<string> Brands = new Stack<string>();
            //Push
            Brands.Push("Nike");
            Brands.Push("Puma");
            Brands.Push("UCB");
            Brands.Push("Adidas");
            Brands.Push("H&M");

            foreach(string brandname in Brands)
            {
                Console.WriteLine(brandname);
            }

            //Pop
            Console.WriteLine(Brands.Pop());
            //Peek
            Console.WriteLine(Brands.Peek());
            //Contains
            Console.WriteLine(Brands.Contains("Nike"));
            //Count
            Console.WriteLine(Brands.Count);


            Console.WriteLine("--------------------------");
            Console.WriteLine("*Queue*");
            Console.WriteLine("--------------------------");
            Queue<string> Animals = new Queue<string>();
            //Enqueue
            Animals.Enqueue("Dog");
            Animals.Enqueue("Cat");
            Animals.Enqueue("Tiger");
            Animals.Enqueue("Lion");
            Animals.Enqueue("Cow");
            foreach(string name in Animals)
            {
                Console.WriteLine(name);
            }
            //Dequeue
            Console.WriteLine(Animals.Dequeue());
            //Peek
            Console.WriteLine(Animals.Peek());
            //Contains
            Console.WriteLine(Animals.Contains("Lion"));
            //Count
            Console.WriteLine(Animals.Count);
            //Clear
            Animals.Clear();
            Console.WriteLine(Animals.Count);

        }
    }
}
