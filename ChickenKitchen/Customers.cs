using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ChickenKitchen
{
    public class Customers
    {



        public static void DisplayListOfCustomers()
        {
            string[] listOfCustomersWithALlergies = File.ReadAllLines("CustomersAllergies.csv");
            Console.WriteLine("---List of Customers---");
            for (int i = 0; i < listOfCustomersWithALlergies.Length; i++)
            {
                string[] customerData = listOfCustomersWithALlergies[i].Split(','); //[0] customer, [1] allergy
                Console.WriteLine($"{i + 1}.{customerData[0]}");
            }
            Console.WriteLine();

        }

    }



}
