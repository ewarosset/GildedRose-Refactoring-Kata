using GildedRoseKata;

namespace GildedRose
{
    public class UpdateProcess
    {
        public class AgedBrieProcess
        {
            public static void Update(Item item)
            {
                if (item.Quality < 50)
                {
                    item.Quality += 1;
                }

                item.SellIn -= 1;

                if (item.SellIn < 0)
                {
                    if (item.Quality < 50)
                    {
                        item.Quality += 1;
                    }
                }
            }
        }
    }
}