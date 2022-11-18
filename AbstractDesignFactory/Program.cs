using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDesignFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IProduct _product;
            StylingManufacturingFactory stylingFactory;
            string itemName;
            // Create the Sea Factory object by passing the factoryType
            stylingFactory = StylingManufacturingFactory.CreateStylingFactory("Men");
            Console.WriteLine("Factory type : " + stylingFactory.GetType().Name);
            // Get traditional object by passing the productType
            _product = stylingFactory.GetProduct("Traditional");
            Console.WriteLine("Product Type : " + _product.GetType().Name);
            itemName = _product.GetProductDetails("Male");
            Console.WriteLine(_product.GetType().Name + " Product : " + itemName);
            Console.WriteLine("----------------------------------------------------");
            stylingFactory = StylingManufacturingFactory.CreateStylingFactory("Men");
            Console.WriteLine("Factory type : " + stylingFactory.GetType().Name);
            _product = stylingFactory.GetProduct("Westren");
            Console.WriteLine("Product Type : " + _product.GetType().Name);
            itemName = _product.GetProductDetails("Male");
            Console.WriteLine(_product.GetType().Name + " Product : " + itemName);
            Console.WriteLine("----------------------------------------------------");
            stylingFactory = StylingManufacturingFactory.CreateStylingFactory("Women");
            Console.WriteLine("Factory type : " + stylingFactory.GetType().Name);
            _product = stylingFactory.GetProduct("Westren");
            Console.WriteLine("Product Type : " + _product.GetType().Name);
            itemName = _product.GetProductDetails("Female");
            Console.WriteLine(_product.GetType().Name + " Product : " + itemName);
            Console.WriteLine("----------------------------------------------------");
            stylingFactory = StylingManufacturingFactory.CreateStylingFactory("Women");
            Console.WriteLine("Factory type : " + stylingFactory.GetType().Name);
            _product = stylingFactory.GetProduct("Shoe");
            Console.WriteLine("Product Type : " + _product.GetType().Name);
            itemName = _product.GetProductDetails("Female");
            Console.WriteLine(_product.GetType().Name + " Product : " + itemName);
            Console.ReadLine();
        }
    }
}
