using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace Api04.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }  
        public int Year { get; set; }
        public Car(string manufacturer, string model, string color, int year)
        {
            Manufacturer = manufacturer;
            Model = model;
            Color = color;
            Year = year;
        }
    }
}
