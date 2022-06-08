namespace garaget
{
    public class Vehicle 
    {
        public string Type { get; set; }
        public string Make { get; set; }
        public string Color { get; set; }
        public string Capacity { get; set; }
        public Vehicle (string type, string make, string color, string capacity)
        {
            Type = type;
            Make = make;
            Color = color;
            Capacity = capacity;
        }
    }
}