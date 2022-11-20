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
