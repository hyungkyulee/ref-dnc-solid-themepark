namespace SOLIDApp
{
    public class ThemeParkRide
    {
        private string Name { get; }
        private float Speed { get; }

        public static float? TotalSpeed = 0;

        public ThemeParkRide(string name, float speed)
        {
            Name = name;
            Speed = speed;
            TotalSpeed += speed;
        }

        public string RideDetails()
        {
            return $"{Name} which goes {Speed}\n";
        }

        // public float RideTotalSpeed()
        // {
        //     return TotalSpeed;
        // }
    }
}