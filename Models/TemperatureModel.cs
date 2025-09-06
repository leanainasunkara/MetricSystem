using System.ComponentModel.DataAnnotations;

namespace MetricSystem.Models
{
    public class TemperatureModel
    {
        [Required(ErrorMessage = "Fahrenheit Value is required.")]
        public decimal? FahrenheitValue { get; set; }

        public decimal? CelsiusValue
        {
            get
            {
                if (FahrenheitValue.HasValue)
                    return (FahrenheitValue - 32) * 5 / 9;
                return null;
            }
        }
    }
}