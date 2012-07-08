using System;
using ObliqueStrategies.Properties;

namespace ObliqueStrategies.Classes
{
    public static class StrategiesDecks
    {
        private static Random random;

        static StrategiesDecks()
        {
            random=new Random((int)DateTime.Now.Ticks);
        }

        public static string GetStrategy()
        {
            var strDecks = new[] {Resources.Edition1, Resources.Edition2,
                Resources.Edition3, Resources.Edition4, Resources.Edition5};

            var iDeckNumber = random.Next(0, strDecks.Length);
            var strDeck = strDecks[iDeckNumber];

            var strStrategies = strDeck.Split(new[] { "\r\n" }, StringSplitOptions.None);
            var iStrategyNumber = random.Next(0, strStrategies.Length);
            var strStrategy = strStrategies[iStrategyNumber];

            return strStrategy;
        }
    }
}
