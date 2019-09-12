
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
            currentValue = currentValue + num;
        }
        public void Multiply(int num)
        {
            currentValue = currentValue * num;
        }

        public void Subtract(int num)
        {
            currentValue = currentValue - num;
        }
        public void Divide(int num)
        {
            currentValue = currentValue / num;
        }
    }
}
