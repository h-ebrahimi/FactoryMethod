namespace FactoryMethod
{
    public class SilverCard : CardType
    {
        public SilverCard()
        {
            setCreditLimit();
        }
        public override void setCreditLimit()
        {
            CreditLimit = 10000;
        }
    }
}