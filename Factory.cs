namespace FactoryMethod
{
    public class Factory
    {
        public static CardType GetCard(string type)
        {
            return type switch
            {
                "Silver" => new SilverCard(),
                "Gold" => new GoldCard(),
                "Platinum" => new PlatinumCard(),
                _ => null
            };
        }

        public static CardType GetCard(double salary)
        {
            return salary switch
            {
                < 10000 => new SilverCard(),
                < 50000 and >= 10000 => new GoldCard(),
                >= 50000 => new PlatinumCard(),
                _ => null
            };
        }
    }
}