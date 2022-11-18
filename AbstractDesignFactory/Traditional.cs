using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDesignFactory
{
    public class Traditional:IProduct
    {
        public string GetProductDetails(string gender)
        {
            if (gender == "Male")
            {
                return "Men traditional wear.";
            }
            else if (gender == "Female")
            {
                return "Women traditonal wear";
            }
            else
            {
                return "Traditional Wear";
            }
        }
    }
}
