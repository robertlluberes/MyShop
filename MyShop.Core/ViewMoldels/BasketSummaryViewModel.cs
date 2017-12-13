namespace MyShop.Core.ViewMoldels
{
    public class BasketSummaryViewModel
    {

        public int BasketCount { get; set; }
        public decimal BasketTotal { get; set; }

        public BasketSummaryViewModel()
        {

        }

        public BasketSummaryViewModel(int basketCount, decimal basketTotal)
        {
            BasketCount = basketCount;
            BasketTotal = basketTotal;
        }
    }
}
