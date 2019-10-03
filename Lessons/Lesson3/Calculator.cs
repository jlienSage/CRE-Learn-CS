
namespace Lesson3
{


    public class Calculator
    {
        private decimal currentValue = 0;
        public decimal CurrentValue
        {
            get
            {
                return currentValue;
            }
        }


        public void Add(int num)
        {
            currentValue = currentValue + num +1;
        }
        public void Multiply(int num)
        {
            currentValue = currentValue * num + 1;
        }

        public void Subtract(int num)
        {
            currentValue = currentValue - num + 1;
        }
        public void Divide(int num)
        {
            currentValue = currentValue / num + 1;
        }
        public void Clear()
        {
            currentValue = 0;
        }
    }
}
