namespace SOLIDApp
{
    public class Restaurant
    {
        private string Name { get; }
        private float Income { get; }
        private float Loss { get; }
        public static float TotalIncome;
        public static float TotalLoss;

        public Restaurant(string name, float income, float loss)
        {
            Name = name;
            Income = income;
            Loss = loss;
            TotalIncome += income;
            TotalLoss += loss;
        }

        public string RestaurantDetails()
        {
            return $"{Name} which generates {Income} in income and {Loss} in loss. \n";
        }
    }
}