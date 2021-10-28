using System;
using System.Collections.Generic;
using System.Text;

namespace ChickenKitchen
{
    class Sandbox
    {
        ////wersja z  szukaniem w petlach foreach na obiektach

        ////czyta zawartość i dzieli na wiersze (potrawa, skladnik, skladnik, skladnik)
        //List<string> listOfDishesWithIngredients = File.ReadAllLines("FoodIngredients.csv").ToList();
        //List<string> listOfBaseIngrients = File.ReadAllLines("BaseIngredients.csv").ToList();

        //List<Dishes> listOfObjectDishes = new List<Dishes>();
        //List<BaseIngriends> listOfObjectIngrients = new List<BaseIngriends>();



        //for (int i = 0; i < listOfDishesWithIngredients.Count; i++)
        //{
        //    Dishes dish = new Dishes(listOfDishesWithIngredients[i]);
        //    listOfObjectDishes.Add(dish);
        //}

        //for (int i = 0; i < listOfBaseIngrients.Count; i++)
        //{
        //    BaseIngriends ingriend = new BaseIngriends(listOfBaseIngrients[i]);
        //    listOfObjectIngrients.Add(ingriend);
        //}

        //foreach (var ins in listOfObjectIngrients)
        //{
        //    Console.WriteLine(ins.Ingrient);
        //}

        //Console.WriteLine($"ten{listOfObjectDishes[0].Ingredients[0]}");
        //int m = 0;
        //int n = 0;


        //foreach (var singleing in listOfObjectIngrients)
        //{
        //    Console.WriteLine($"tamtenn{listOfObjectDishes[0].Ingredients[0]}");
        //    if (singleing.Ingrient.ToString().Equals(listOfObjectDishes[0].Ingredients[0].ToString())) break;
        //    else
        //    {
        //        foreach (var singledish in listOfObjectDishes)
        //        { 

        //            if(singledish.Dish[0].ToString() == listOfObjectDishes[1].Dish[0].ToString())  
        //            {
        //                listOfObjectDishes[0].Ingredients.RemoveAt(0); //usun wtedy golden chicken <<< skoncz

        //              break;

        //            }
        //        }
        //    }
        //}

        //while(listOfObjectDishes[0].Ingredients[0].ToString() != listOfObjectIngrients[0].ToString()) //dopóki golden -! ktorys ze skladnikow
        //{
        //    m++;
        //   if(m == listOfObjectIngrients.Count){


        //    while (listOfObjectIngrients[n].ToString() != listOfObjectDishes[1].ToString()) //golden chicken == arrayofdishes  -> powiedzmy ze tak 0 = 1
        //    {
        //        n++;

        //    }
        //    listOfObjectDishes[0].Ingredients.RemoveAt(0); //usun wtedy golden chicken
        //    listOfObjectDishes[0].Ingredients
        //        .Add(listOfObjectDishes[1].Ingredients[1]); //skladnik 1 ale tez cala reszte w petli
        //    }

        //}

        //foreach (var line in listOfDishesWithIngredients)
        //{
        //    line.Split(',');

        //}


    }
}
