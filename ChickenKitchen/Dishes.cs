using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ChickenKitchen
{
    public class Dishes
    {


        public static void DisplayListOfDishes()
        {

            string[] listOfDishesWithIngredients = File.ReadAllLines("FoodIngredients.csv");

            Console.WriteLine("---List of Dishes---");
            for (int i = 0; i < listOfDishesWithIngredients.Length; i++)
            {

                string[] eachIngredient = listOfDishesWithIngredients[i].Split(','); //[0] customer, [1] allergy
                Console.WriteLine($"{i + 1}.{eachIngredient[0]}");
            }
            Console.WriteLine();

        }
    }
}
