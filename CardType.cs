namespace FactoryMethod
{
    public abstract class CardType
    {
        protected double CreditLimit;
        public abstract void setCreditLimit();
        public override string ToString()
        {
            return "Your card is " + this.GetType().Name + " & your credit limit is " + CreditLimit;
        }
    }
}
