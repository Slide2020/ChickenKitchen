using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ChickenKitchen
{
    public class Customers
    {


        public string FullName;
         public string Allergic;

        public Customers(string rowCustomer)
        {
            List<string> data = rowCustomer.Split(',').ToList();

            this.FullName = data[0];
            this.Allergic = data[1];

        }




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
