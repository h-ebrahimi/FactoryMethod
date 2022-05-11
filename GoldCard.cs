namespace FactoryMethod
{
    public class GoldCard : CardType
    {
        public GoldCard()
        {
            setCreditLimit();
        }
        public override void setCreditLimit()
        {
            CreditLimit = 25000;
        }
    }
}