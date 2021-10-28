using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Channels;


namespace ChickenKitchen
{
    class Program
    {
        static void Main(string[] args)

        {


            //wersja z  szukaniem w petlach foreach na obiektach

            //czyta zawartość i dzieli na wiersze(potrawa, skladnik, skladnik, skladnik)
            List<string> listOfDishesWithIngredients = File.ReadAllLines("FoodIngredients.csv").ToList();
            List<string> listOfBaseIngrients = File.ReadAllLines("BaseIngredients.csv").ToList();
            List<string> listOfCustomers = File.ReadAllLines("CustomersAllergies.csv").ToList();

            //listy obiektowe
            List<Dishes> listOfObjectDishes = new List<Dishes>();
            List<BaseIngriends> listOfObjectIngrients = new List<BaseIngriends>();
            List<Customers> listOfObjectCustomers = new List<Customers>();


            for (int i = 0; i < listOfDishesWithIngredients.Count; i++)
            {
                Dishes dish = new Dishes(listOfDishesWithIngredients[i]);
                listOfObjectDishes.Add(dish);
            }

            for (int i = 0; i < listOfBaseIngrients.Count; i++)
            {
                BaseIngriends ingriend = new BaseIngriends(listOfBaseIngrients[i]);
                listOfObjectIngrients.Add(ingriend);
            }

            for (int i = 0; i < listOfCustomers.Count; i++)
            {
                Customers customer = new Customers(listOfCustomers[i]);
                listOfObjectCustomers.Add(customer);
            }


            //////////////////////////////////////////////////////////////////////
            Console.WriteLine("---------------------List of dishes--------------------");
            foreach (var eachdish in listOfObjectDishes)
            {

                Console.WriteLine(eachdish.Dish);
            }

            Console.WriteLine("Please write Full name of dish");
            var selectedDish = Console.ReadLine();


            List<string> ListOfSeletedIngrients = new List<string>();



            do
            {
                foreach (var eachdish in listOfObjectDishes)
                {
                    if (selectedDish == eachdish.Dish)
                    {
                        selectedDish = eachdish.Dish;
                        for (int i = 0; i < eachdish.Ingredients.Count; i++)
                        {
                            ListOfSeletedIngrients.Add(eachdish.Ingredients[i]);
                        }

                        break;
                    }

                }

                if (selectedDish == listOfObjectDishes[0].Dish.ToString()
                    || selectedDish == listOfObjectDishes[1].Dish.ToString()
                    || selectedDish == listOfObjectDishes[2].Dish.ToString()
                    || selectedDish == listOfObjectDishes[3].Dish.ToString()
                    || selectedDish == listOfObjectDishes[4].Dish.ToString()
                    || selectedDish == listOfObjectDishes[5].Dish.ToString()
                    || selectedDish == listOfObjectDishes[6].Dish.ToString()
                    || selectedDish == listOfObjectDishes[7].Dish.ToString()
                    || selectedDish == listOfObjectDishes[8].Dish.ToString()
                    || selectedDish == listOfObjectDishes[9].Dish.ToString()
                    || selectedDish == listOfObjectDishes[10].Dish.ToString()
                    || selectedDish == listOfObjectDishes[11].Dish.ToString()
                    || selectedDish == listOfObjectDishes[12].Dish.ToString()) break;
                Console.WriteLine("There is no such dish, please try again");
                selectedDish = Console.ReadLine();
            } while (selectedDish != listOfObjectDishes[0].Dish.ToString()
                     || selectedDish != listOfObjectDishes[1].Dish.ToString()
                     || selectedDish != listOfObjectDishes[2].Dish.ToString()
                     || selectedDish != listOfObjectDishes[3].Dish.ToString()
                     || selectedDish != listOfObjectDishes[4].Dish.ToString()
                     || selectedDish != listOfObjectDishes[5].Dish.ToString()
                     || selectedDish != listOfObjectDishes[6].Dish.ToString()
                     || selectedDish != listOfObjectDishes[7].Dish.ToString()
                     || selectedDish != listOfObjectDishes[8].Dish.ToString()
                     || selectedDish != listOfObjectDishes[9].Dish.ToString()
                     || selectedDish != listOfObjectDishes[10].Dish.ToString()
                     || selectedDish != listOfObjectDishes[11].Dish.ToString()
                     || selectedDish != listOfObjectDishes[12].Dish.ToString());

            //////////////////////////////////////////////////////////////////////
            Console.WriteLine("---------------------List of names--------------------");
            foreach (var eachCustomer in listOfObjectCustomers)
            {

                Console.WriteLine(eachCustomer.FullName);
            }

            Console.WriteLine("Please write Full name of customer");
            var selectedCustomer = Console.ReadLine();


            string seletedAllergic = "";



            do
            {
                foreach (var eachCustomer in listOfObjectCustomers)
                {
                    if (selectedCustomer == eachCustomer.FullName)
                    {
                        selectedCustomer = eachCustomer.FullName;
                        seletedAllergic = eachCustomer.Allergic;
                        break;
                    }

                }

                if (selectedCustomer == listOfObjectCustomers[0].FullName.ToString()
                    || selectedCustomer == listOfObjectCustomers[1].FullName.ToString()
                    || selectedCustomer == listOfObjectCustomers[2].FullName.ToString()
                    || selectedCustomer == listOfObjectCustomers[3].FullName.ToString()
                    || selectedCustomer == listOfObjectCustomers[4].FullName.ToString()
                    || selectedCustomer == listOfObjectCustomers[5].FullName.ToString()
                    || selectedCustomer == listOfObjectCustomers[6].FullName.ToString()) break;
                Console.WriteLine("There is no such customer, please try again");
                selectedCustomer = Console.ReadLine();
            } while (selectedCustomer != listOfObjectCustomers[0].FullName.ToString()
                     || selectedCustomer != listOfObjectCustomers[1].FullName.ToString()
                     || selectedCustomer != listOfObjectCustomers[2].FullName.ToString()
                     || selectedCustomer != listOfObjectCustomers[3].FullName.ToString()
                     || selectedCustomer != listOfObjectCustomers[4].FullName.ToString()
                     || selectedCustomer != listOfObjectCustomers[5].FullName.ToString()
                     || selectedCustomer != listOfObjectCustomers[6].FullName.ToString());


            Console.WriteLine(seletedAllergic);

            int y = 0;
            int z = 0;

            foreach (var selectedIng in listOfObjectIngrients)
            {
                      for (int i = 0; i < ListOfSeletedIngrients.Count; i++)
                {
                    if (String.Equals(ListOfSeletedIngrients[i], selectedIng.Ingrient))

                        for (y = 0; y < ListOfSeletedIngrients.Count; y++)
                        {
                            if (ListOfSeletedIngrients[y] == seletedAllergic)
                            {
                                Console.WriteLine("Nie można! alergia");
                                break;
                            }
                       
                        }
                    if(y==3)continue;
                    if (ListOfSeletedIngrients[y] == seletedAllergic) break;

                }

                      z++;
                if(z== listOfObjectIngrients.Count-1) Console.WriteLine("Udało się zamówić!");
                if (y == 3) continue;
                if (ListOfSeletedIngrients[y] == seletedAllergic) break;
       
               ;
            }


          


        }
          


            //Orders order = new Orders();

            //Customers.DisplayListOfCustomers();
            //Dishes.DisplayListOfDishes();
            //order.MakeOrder();

            //static List<Customers> GetCustomersList()
            //{
            //    return new List<Customers>
            //    {


            //    };
            //}


        }

    }










//ENUM MOZE?


//IN -> CustomersAllerg.csv, Food – Ingredients.csv, Base Ingredient List.csv, cosnole input 

//Implementation

//OUT -> console answer succes or fail


/*CheckIfPersonHasAllergy(person, Alldishes)   //Julie Mirage – Fish in Water: success
 //FAZA I
//{
pickNameFromCustomers(customerFile)
pickDishFromDishes(dishFile)
CompareAllergic(customerfile, dishes)
    pickAlergic
    picksSkładniki
    Compare everyone
    return succes or faile 
petla w petli
//

rozbic dishes na skladni jakims rozbijaczem

FAZAII
//{
pickNameFromCustomers(customerFile)
    readfilefromCSV
    SplitToKolumns
    getkolumn0.0
    putKolumn0.0 jako jeden z parametrow i wrzuc na konsole
pickDishFromDishes(dishFile)
 readfilefromCSV
    SplitToKolumns
    getkolumn0.0
    putKolumn0.0 jako jeden z parametrow i wrzuc na konsole
CompareAllergic(customerfile, dishes)
    pickAlergic
        readfilefromCSV
        SplitToKolumns
        getkolumn0.1
    picksSkładniki
         readfilefromCSV
         SplitToKolumnsAlenawszstkieskladniki
        getkolumnFromDO
    Compare everyone
    return succes or faile 
petla w petli
//

rozbic dishes na skladni jakims rozbijaczem


}*/