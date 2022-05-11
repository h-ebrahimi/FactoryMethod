namespace FactoryMethod
{
    public class PlatinumCard : CardType
    {
        public PlatinumCard()
        {
            setCreditLimit();
        }
        public override void setCreditLimit()
        {
            CreditLimit = 50000;
        }
    }
}