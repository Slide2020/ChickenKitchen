using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace ChickenKitchen
{
    public class Orders
    {
        string selectedCustomer { get; set;}
        string selectedDish { get; set;}

        public void MakeOrder()
        {


            //dokodzić porównywanie z listą>> musi pasować inaczej niech leci wyjątek

            Console.WriteLine("---Make Order---");
            Console.WriteLine("Please write Full name of customer");
            selectedCustomer = Console.ReadLine();
            Console.WriteLine("Please write Full name dish");
            selectedDish = Console.ReadLine();

        }

        public static void CompareAllergy()
        {
            Console.WriteLine();
        }

    }
}
