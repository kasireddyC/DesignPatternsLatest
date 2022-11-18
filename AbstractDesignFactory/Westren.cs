using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDesignFactory
{
    public class Westren:IProduct
    {
        public string GetProductDetails(string gender)
        {
            if (gender == "Male")
            {
                return "Men westren wear.";
            }
            else if (gender == "Female")
            {
                return "Women westren wear";
            }
            else
            {
                return "Westren Wear";
            }
        }
    }
}
