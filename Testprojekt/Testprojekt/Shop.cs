using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testprojekt
{
    class Shop
    {
       // private List<StoreStructure> assortmentMaxi = new List<StoreStructure>();

        private List<string> shoppingCart = new List<string>();
        private List<StoreStructure> assortment = new List<StoreStructure>();


        public List <string> ShoppingCart
        {
            get
            {
                return shoppingCart;
            }
        }
        public void AddProductToCart(string input)
        {
            shoppingCart.Add(input);
        }
        public List<string> LoadAllItemsToList()
        {
            return shoppingCart;
        }
        public static List<string> SortInMaxiOrder( List<string> ShoppingCart, List<StoreStructure> assortment)
        {
            List<string> assortmentMax = StoreStructure.CreateMaxiSortimentOrder(assortment);
            var  maxiList = new List<string>();
            foreach (string m in assortmentMax)
            {
                foreach(string s in ShoppingCart)
                {
                    if(s == m)
                    {
                        maxiList.Add(s);
                    }
                }
            }
            return maxiList;
        }
        public static List<string> SortInCityGrossOrder(List<string> ShoppingCart, List<StoreStructure> assortment)
        {
            List<string> assortmentCity = StoreStructure.CreateCityGrossSortimentOrder(assortment);
            var cityGrossList = new List<string>();
            foreach (string m in assortmentCity)
            {
                foreach (string s in ShoppingCart)
                {
                    if (s == m)
                    {
                       cityGrossList.Add(s);
                    }
                }
            }
            return cityGrossList;
        }
        public static List<string> SortInWillysOrder(List<string> ShoppingCart, List<StoreStructure> assortment)
        {
            List<string> assortmentWillys = StoreStructure.CreateWillysSortimentOrder(assortment);
            var willysList = new List<string>();
            foreach (string m in assortmentWillys)
            {
                foreach (string s in ShoppingCart)
                {
                    if (s == m)
                    {
                        willysList.Add(s);
                    }
                }
            }
            return willysList;
        }
    }
}
