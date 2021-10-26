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



            string[] customerLine = File.ReadAllLines("CustomersAllergies.csv");
            string[] customerData = customerLine[0].Split(',');
            string[] dishLine = File.ReadAllLines("FoodIngredients.csv");
            string[] dishData = dishLine[0].Split(',');

            Console.WriteLine($"{customerData[0]} , {dishData[0]} ");


            for (int i = 1; i < dishData.Length; i++)
            {
                if (customerData[1] == dishData[i])
                {
                    Console.WriteLine($"{ customerData[0]} - { dishData[0]}: can't order, allergic to: {dishData[i]} ");
                    break;
                }
                else if (i == dishData.Length - 1)
                {
                    
                        Console.WriteLine($"{ customerData[0]} - { dishData[0]}: success");
                    
                }
                    
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