using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_3
{
    class Article
    {
        private string name_of_product;
        private string name_of_store;
        private double cost { get; set; }

        public string  Name_of_Product
        {
            get { return name_of_product; }
            set { name_of_product = value; }
        }

        public string Name_of_Store
        {
            get { return name_of_store; }
            set { name_of_store = value; }
        }

        public double Cost
        {
            get { return cost; }
            set { cost = value; }
        }



        public Article(string name_of_product)
        {
            this.name_of_product = name_of_product;
        }

        public Article (string name_of_product, string name_of_store, double cost)
        {
            this.name_of_product = name_of_product;
            this.name_of_store = name_of_store;
            this.cost = cost;
        }

        public string Print()
        {
            string output;
            if (name_of_store != "")
                output = name_of_store + " " + name_of_product + " " + Convert.ToString(cost);
            else
                output = name_of_product;
            return output;

        }
    }
}
