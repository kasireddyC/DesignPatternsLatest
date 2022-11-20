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
