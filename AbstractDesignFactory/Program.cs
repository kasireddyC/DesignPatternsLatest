using System;

namespace AbstractDesignFactory
{
    class Program
    {
        public static void PrintOutputDetails(IProduct product, StylingManufacturingFactory stylingFactory, string gender)
        {
            Console.WriteLine("Factory type : " + stylingFactory.GetType().Name);
            Console.WriteLine("Product Type : " + product.GetType().Name);
            Console.WriteLine(product.GetType().Name + " Product : " + product.GetProductDetails(gender));
            Console.WriteLine("----------------------------------------------------");
        }
        static void Main(string[] args)
        {
             IProduct _product;
             StylingManufacturingFactory _stylingFactory;
            // Create the Sea Factory object by passing the factoryType
            _stylingFactory = StylingManufacturingFactory.CreateStylingFactory("Men");
            // Get traditional object by passing the productType
            _product = _stylingFactory.GetProduct("Traditional");
            PrintOutputDetails(_product, _stylingFactory,"Male");

            _stylingFactory = StylingManufacturingFactory.CreateStylingFactory("Men");
            _product = _stylingFactory.GetProduct("Westren");
            PrintOutputDetails(_product, _stylingFactory,"Male");

            _stylingFactory = StylingManufacturingFactory.CreateStylingFactory("Women");
            _product = _stylingFactory.GetProduct("Traditional");
            PrintOutputDetails(_product, _stylingFactory,"Female");

            _stylingFactory = StylingManufacturingFactory.CreateStylingFactory("Women");
            _product = _stylingFactory.GetProduct("Shoe");
            PrintOutputDetails(_product, _stylingFactory,"Female");

            Console.ReadLine();
        }
    }
}
