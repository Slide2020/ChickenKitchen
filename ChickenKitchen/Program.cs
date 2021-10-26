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



            string[] CustomerLine = File.ReadAllLines("CustomersAllergies.csv");
            string[] CustomerData = CustomerLine[0].Split(',');
            string[] DishLine = File.ReadAllLines("FoodIngredients.csv");
            string[] DishData = DishLine[0].Split(',');

            Console.WriteLine($"{CustomerData[0]} , {DishData[0]} ");

            if (CustomerData[1] != DishData[1] )
            {
                Console.WriteLine("Success: Order completed ");
            }
            else
            {
                Console.WriteLine($"Failed:{CustomerData[0]} cant order this dish, allergy for {DishData[1]}");
            }
            


            //Customers customer1 = new Customers(csvLines[0]);

            //Console.WriteLine(customer1.Allergic);

            //var listOfCustomers = new List<Customers>();


            //for (int i = 0; i < csvLines.Length; i++)
            //{
            //    Customers cs = new Customers(csvLines[i]);
            //    listOfCustomers.Add(cs);

            //}



        }

        public static void CheckAllergy()
        {

        }

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