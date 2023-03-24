
namespace Delegate_Event_Lambda.Model
{
    internal class ArrayHandler
    {
       
        public IEnumerable<int> SquareRoots(Func<double, bool> lambda)
        {
            foreach (int number in numbers)
            {
                if (number.Root() % 1 == 0)
                    Notify?.Invoke(this, new ArrayEventArgs(number));

                if (lambda(number))
                    yield return number;
            }
        }

        public IEnumerable<int> numbers = new int[] { };
        public ArrayHandler(params int[] numbers)
        {
            this.numbers = numbers;
        }

        public delegate void ArrayDelegate(ArrayHandler sender, ArrayEventArgs e);
        public event ArrayDelegate Notify;
        
    }
}
