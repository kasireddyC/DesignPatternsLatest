namespace AbstractDesignFactory
{
    public class Shoes:IProduct
    {
        public string GetProductDetails(string gender)
        {
            if (gender == "Male")
            {
                return "Men shoes.";
            }
            else if (gender == "Female")
            {
                return "Women shoes";
            }
            else
            {
                return "Shoes";
            }
        }
    }
}
