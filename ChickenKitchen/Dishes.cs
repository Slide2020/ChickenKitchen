using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace ChickenKitchen
{
    public class Dishes
    {

        public string Dish;
        public List<string> Ingredients = new List<string>();

        public Dishes(string rowDish)
        {
            List<string> data = rowDish.Split(',').ToList();

            this.Dish = data[0];

            for (int i = 1; i < data.Count; i++)
            {
                this.Ingredients.Add(data[i]);
            }
        }

        public Dishes(int i, string dish)
        {
            this.Dish = dish;
            
        }

     

































        //private List<string> _listOfBaseIngredients;
        //private List<string> _listOfDishesWithIngredients;
        //private List<string> _eachIngredient = new List<string>();

        //public static void DisplayListOfDishes()
        //{

        //    string[] listOfDishesWithIngredients = File.ReadAllLines("FoodIngredients.csv");

        //    Console.WriteLine("---List of Dishes---");
        //    for (int i = 0; i < listOfDishesWithIngredients.Length; i++)
        //    {

        //        string[] eachIngredient = listOfDishesWithIngredients[i].Split(','); //[0] customer, [1] allergy
        //        Console.WriteLine($"{i + 1}.{eachIngredient[0]}");
        //    }
        //    Console.WriteLine();

        //}

        ////public List<string> IngredientsExtractor(List<string> list)
        ////{
        ////    _listOfBaseIngredients = File.ReadAllLines("BaseIngredients.csv").ToList();
        ////    _listOfDishesWithIngredients = File.ReadAllLines("FoodIngredients.csv").ToList();
        ////    _eachIngredient = _listOfDishesWithIngredients[0].Split(',').ToList();



        ////    if (_eachIngredient[1] == _listOfBaseIngredients[0])  //Fat Cat Chicken == Chicken
        ////    {
        ////        break;
        ////    }
        ////    else
        ////    {
        ////        if(_eachIngredient[1] ==  )
        ////    }

        ////    return
        ////}

        //public string[,] CreateListWithFoodAndBaseIngredients()
        //{

        //    _listOfBaseIngredients = File.ReadAllLines("BaseIngredients.csv").ToList();
        //    _listOfDishesWithIngredients = File.ReadAllLines("FoodIngredients.csv").ToList();
        //    _eachIngredient = _listOfDishesWithIngredients[0].Split(',').ToList();

        //    List<Array> list = new List<Array>();
        //    list.Add(File.ReadAllLines("BaseIngredients.csv"));
        //    list.Add(File.ReadAllLines("FoodIngredients.csv"));
        //    Console.WriteLine(list[1,0]);
        //}

    }
}
