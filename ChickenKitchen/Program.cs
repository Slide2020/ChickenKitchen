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

            //array gdzie [0] row z customerem i aleregia
            var listOfCustomersWithALlergies = File.ReadAllLines("CustomersAllergies.csv");


            //array gdzie [0] to klient, a każdy kolejny to alergia
            var customerData = new List<string>();

            var listOfDishesWithIngredients = File.ReadAllLines("FoodIngredients.csv");
            var eachIngredient = new List<string>();

            var selectedCustomerList = new List<string>();
            var selectedDishList = new List<string>();



            Customers.DisplayListOfCustomers();
            Dishes.DisplayListOfDishes();
            Console.WriteLine("---Make Order---");


            Console.WriteLine("Please write Full name of customer");
            var selectedCustomer = Console.ReadLine();
            selectedCustomerList.Add(selectedCustomer);

            while (selectedCustomerList != customerData)
            {
                for (int i = 0; i < listOfCustomersWithALlergies.Length; i++)
                {
                    customerData = listOfCustomersWithALlergies[i].Split(',').ToList(); //[0] customer, [1] allergy
                    if (selectedCustomer == customerData[0])
                    {
                        selectedCustomer = customerData[0];
                        break;

                    }
                }

                if (selectedCustomer == customerData[0])
                {
                    break;
                }
                Console.WriteLine("There is no such customer, please try again");
                selectedCustomer = Console.ReadLine();
            }


            Console.WriteLine("Please write Full name of dish");
            var selectedDish = Console.ReadLine();
            selectedDishList.Add(selectedDish);

            while (selectedDishList != eachIngredient)
            {
                for (int i = 0; i < listOfDishesWithIngredients.Length; i++)
                {
                    eachIngredient = listOfDishesWithIngredients[i].Split(',').ToList(); //[0] customer, [1] allergy
                    if (selectedDish == eachIngredient[0])
                    {
                        selectedDish = eachIngredient[0]; 
                        break;

                    }
                }

                if (selectedDish == eachIngredient[0])
                {
                    break;
                }
                Console.WriteLine("There is no such dish, please try again");
                selectedDish = Console.ReadLine();
            }

            for (int i = 0; i < listOfDishesWithIngredients.Length; i++)
            {
                int y;
                eachIngredient = listOfDishesWithIngredients[i].Split(',').ToList(); // [0] = main dish
                customerData = listOfCustomersWithALlergies[1].Split(',').ToList(); //[0] customer, [1] allergy

                for (y = 1; y < eachIngredient.Count; y++)
                {
                    if (customerData[1] == eachIngredient[y])
                    {
                        Console.WriteLine(
                            $"{selectedCustomer} - {selectedDish}: can't order, allergic to: {eachIngredient[y]} \n");
                        break;
                    }
                    else if (y == eachIngredient.Count - 1)
                    {

                        Console.WriteLine($"{selectedCustomer} - {selectedDish}: success \n");
                        break;
                    }

                }
                if (y == eachIngredient.Count - 1)
                {
                    break;
                }
            }




            //---------------------------------------

            //int i = 0;

            //    customerData = listOfCustomersWithALlergies[i].Split(','); //[0] customer, [1] allergy




            //while (selectedCustomer != customerData[i])
            //{
            //    Console.WriteLine("There is no such customer, please try again");
            //    selectedCustomer = Console.ReadLine();
            //    i++;
            //    if (selectedCustomer == customerData[0])
            //    {
            //        selectedCustomer = customerData[0];
            //        Console.WriteLine("sukces");
            //        break;

            //    }

            //}


            //for (int i = 0; i < listOfCustomersWithALlergies.Length; i++)
            //{

            //    // na odwrót ta pętla...

            //    customerData = listOfCustomersWithALlergies[i].Split(','); //[0] customer, [1] allergy

            //    Console.WriteLine("Please write Full name of customer");
            //    var selectedCustomer = Console.ReadLine();
            //    while (selectedCustomer != customerData[i])
            //    {
            //        Console.WriteLine("There is no such customer, please try again");
            //        selectedCustomer = Console.ReadLine();
            //    }

            //    selectedCustomer = customerData[i];

            //    Console.WriteLine(selectedCustomer);
            //}

            //Console.WriteLine("Please write Full name dish");
            //var selectedDish = Console.ReadLine();












            //string[] eachIngredient;
            //string[] customerData;


            //string[] listOfCustomersWithALlergies = File.ReadAllLines("CustomersAllergies.csv");

            //string[] listOfDishesWithIngredients = File.ReadAllLines("FoodIngredients.csv");



            //for (int y = 0; y < listOfDishesWithIngredients.Length; y++)
            //{
            //    eachIngredient = listOfDishesWithIngredients[y].Split(','); // [0] = main dish



            //    Console.WriteLine($"{customerData[0]} , {eachIngredient[0]} ");

            //    for (int i = 1; i < eachIngredient.Length; i++)
            //    {
            //        if (customerData[1] == eachIngredient[i])
            //        {
            //            Console.WriteLine(
            //                $"{customerData[0]} - {eachIngredient[0]}: can't order, allergic to: {eachIngredient[i]} \n");
            //            break;
            //        }
            //        else if (i == eachIngredient.Length - 1)
            //        {

            //            Console.WriteLine($"{customerData[0]} - {eachIngredient[0]}: success \n");

            //        }

            //    }
            //}
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