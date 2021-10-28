using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChickenKitchen
{
    class BaseIngriends
    {
        public string Ingrient;


        public BaseIngriends(string rowIngrient)
        {
            List<string> data = rowIngrient.Split(',').ToList();

            this.Ingrient = data[0];
        }

    }
}
