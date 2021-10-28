using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;

namespace ChickenKitchen
{
    public class Orders
    {
        private List<string> _listOfCustomersWithAllergies; 
        private List<string> _customerData;
        private List<string> _listOfDishesWithIngredients;
        private List<string> _eachIngredient = new List<string>();
        private List<string> _selectedCustomerList;
        private List<string> _selectedDishList; 
        private string _selectedCustomer;
        private string _selectedDish;
        
        public void MakeOrder()
        {
            _listOfCustomersWithAllergies = File.ReadAllLines("CustomersAllergies.csv").ToList();
            _listOfDishesWithIngredients = File.ReadAllLines("FoodIngredients.csv").ToList();
            _selectedCustomerList = new List<string>();
            _selectedDishList = new List<string>();

            Console.WriteLine("---Make Order---");
            Console.WriteLine("Please write Full name of customer");
            _selectedCustomer = Console.ReadLine();
            _selectedCustomerList.Add(_selectedCustomer);

            while (_selectedCustomerList != _customerData)
            {
                for (int i = 0; i < _listOfCustomersWithAllergies.Count; i++)
                {
                    _customerData = _listOfCustomersWithAllergies[i].Split(',').ToList(); //[0] customer, [1] allergy
                    if (_selectedCustomer == _customerData[0])
                    {
                        _selectedCustomer = _customerData[0];
                        break;

                    }
                }

                if (_selectedCustomer == _customerData[0])
                {
                    break;
                }
                Console.WriteLine("There is no such customer, please try again");
                _selectedCustomer = Console.ReadLine();
            }
            
            Console.WriteLine("Please write Full name of dish");
             _selectedDish = Console.ReadLine();
            _selectedDishList.Add(_selectedDish);

            while (_selectedDishList != _eachIngredient)
            {
                for (int i = 0; i < _listOfDishesWithIngredients.Count; i++)
                {
                    _eachIngredient = _listOfDishesWithIngredients[i].Split(',').ToList(); //[0] customer, [1] allergy
                    if (_selectedDish == _eachIngredient[0])
                    {
                        _selectedDish = _eachIngredient[0];
                        break;

                    }
                }

                if (_selectedDish == _eachIngredient[0])
                {
                    break;
                }
                Console.WriteLine("There is no such dish, please try again");
                _selectedDish = Console.ReadLine();
            }
            CompareAllergy();
        }

        public void CompareAllergy()
        {
            _listOfCustomersWithAllergies = File.ReadAllLines("CustomersAllergies.csv").ToList();
            _listOfDishesWithIngredients = File.ReadAllLines("FoodIngredients.csv").ToList();
            _selectedCustomerList = new List<string>();
            _selectedDishList = new List<string>();

            for (int i = 0; i < _listOfDishesWithIngredients.Count; i++)
            {
                int y;
                _eachIngredient = _listOfDishesWithIngredients[i].Split(',').ToList(); // [0] = main dish
                _customerData = _listOfCustomersWithAllergies[1].Split(',').ToList(); //[0] customer, [1] allergy

                for (y = 1; y < _eachIngredient.Count; y++)
                {
                    if (_customerData[1] == _eachIngredient[y])
                    {
                        Console.WriteLine(
                            $"{_selectedCustomer} - {_selectedDish}: can't order, allergic to: {_eachIngredient[y]} \n");
                        break;
                    }
                    else if (y == _eachIngredient.Count - 1)
                    {

                        Console.WriteLine($"{_selectedCustomer} - {_selectedDish}: success \n");
                        break;
                    }
                }
                if (y == _eachIngredient.Count - 1)
                {
                    break;
                }
            }
        }
    }
}
