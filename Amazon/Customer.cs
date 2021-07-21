using System;

namespace Amazon
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            var calculator = new RateCalculator();

            var rating = calculator.Calculate(this);
            // var rating = CalculateRating();

            Console.WriteLine(rating == 1 ? "Promote to 1" : "Promote to 2");
        }

        private int CalculateRating() => 1;
    }
}
