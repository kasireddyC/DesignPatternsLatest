using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDesignFactory
{
    public interface IProduct
    {
        string GetProductDetails(string gender);
    }
}
