namespace CSharpIntermediate
{
    public class Calculator
    {
        public static int Add(params int[] numbers)
        {
            var sum = 0;
            foreach (var number in numbers)
                sum += number;

            return sum;
        }
    }
}
