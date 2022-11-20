namespace FactoryDP
{
    public abstract class CreditCardFactory
    {
        public abstract ICreditCard GetCard(string cardType);
    }
}
