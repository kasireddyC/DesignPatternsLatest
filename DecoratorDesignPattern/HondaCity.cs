namespace DecoratorDesignPattern
{
    public class HondaCity:IVehicle
    {
        public string Make
        {
            get { return "HondaCity"; }
        }
        public string Model
        {
            get { return "CNG"; }
        }
        public double Price
        {
            get { return 1000000; }
        }
    }
}
