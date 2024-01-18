using System;

namespace Domain.Entities
{
    public class Drink
    {
        public int Id { get; set; }
        public string? Type { get; set; }
        public double? Amount { get; set; }
        public DateTime? Date { get; set; }
        public ICollection<Person>? People { get; set; }

        public Drink() { }
    }
}
