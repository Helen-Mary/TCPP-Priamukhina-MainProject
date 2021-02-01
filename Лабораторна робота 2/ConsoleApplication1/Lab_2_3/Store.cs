using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_3
{
    class Store
    {
        private Article[] articles;

        public Store()
        {
            articles = new Article[5]
            {
                new Article("truck"),
                new Article("car", "vehicles", 23.45),
                new Article("vheel", "vehicles", 45.23),
                new Article("truck", "vehicles", 333.23),
                new Article("hover", "vehicles", 5.23)
            };
        }
        public Article this[int index]
        {
            get
            {
                articles[index].Print();
                return articles[index];
            }
            set
            {
                articles[index] = value;
            }   
        }

        public string this[string temp]
        {
            
            get
            {
                string result="There is no this product";
                for (int i = 0; i < articles.Length; i++)
                {
                    if (articles[i].Name_of_Product == temp)
                    {
                        result = articles[i].Name_of_Store + " " + Convert.ToString(articles[i].Cost);
                    }
                    else
                        continue;
                }
                return result;

            }
        }

        public void Set_to_store(string name_of_product, int index)
        {
            articles[index] = new Article(name_of_product);
        }


        public void Set_to_store(string name_of_product, string name_of_store, double cost, int index)
        {
            articles[index] = new Article(name_of_product, name_of_product, cost);
        }

        public void Print_All()
        {
            for(int i=0;i<articles.Length;i++)
            {
                string output;
                if (articles[i].Name_of_Store != null)
                    output = articles[i].Name_of_Store + " " + articles[i].Name_of_Product + " " + Convert.ToString(articles[i].Cost);
                else
                    output = articles[i].Name_of_Product;
                Console.WriteLine( output);
            }
        }
    }
}
