using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testprojekt
{
    class Shop
    {
        
        private List<string> shoppingCart = new List<string>();
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
    }
}
