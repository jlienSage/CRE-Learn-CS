
namespace Lesson3
{


    public class Calculator : ICalculator
    {
        protected decimal currentValue = 0;
        public decimal CurrentValue
        {
            get
            {
                return currentValue;
            }
        }


        public virtual void Add(decimal num)
        {
            currentValue = currentValue + num;
        }
        public virtual void Multiply(decimal num)
        {
            currentValue = currentValue * num;
        }

        public virtual void Subtract(decimal num)
        {
            currentValue = currentValue - num;
        }
        public virtual void Divide(decimal num)
        {
            currentValue = currentValue / num;
        }
        public void Clear()
        {
            currentValue = 0;
        }
    }

    
}
    
