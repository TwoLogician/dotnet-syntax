using System;

namespace InitOnly {
    public class WeatherObservation {
        public DateTime RecoredAt { get; init; }
        public decimal TemperatureInCelsius { get; init; }
        public decimal PressureInMillibars { get; init; }
    }

    class Program {
        static void Main(string[] args) {
            var w = new WeatherObservation() {
                RecoredAt = DateTime.Now
            };
        }
    }
}
