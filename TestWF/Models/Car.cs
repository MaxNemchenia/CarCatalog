namespace TestWF.Models
{
    public class Car
    {
        public int Id { get; set; }
        public int? MarkId { get; set; }
        public virtual Mark Mark { get; set; }
        public int Cost { get; set; }
        public string Color { get; set; }
        public int Date { get; set; }
        public int Mileage { get; set; }
        public byte[] Image { get; set; }
    }
}