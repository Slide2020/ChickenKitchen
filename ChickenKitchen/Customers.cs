using System;
using System.Collections.Generic;
using System.Text;

namespace ChickenKitchen
{
    public class Customers
    {
        public string Name { get; set; }
        public string Allergic { get; set; }

        public Customers(string rowData)
        {
            string[] data = rowData.Split(',');
            this.Name = data[0];
            this.Allergic =data[1];
        }



    }



}
