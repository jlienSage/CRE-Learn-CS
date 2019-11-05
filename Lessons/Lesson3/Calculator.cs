
namespace Lesson3
{


    public class Calculator
    {
        protected decimal currentValue = 0;
        public decimal CurrentValue
        {
            get
            {
                return currentValue;
            }
        }


        public virtual void Add(int num)
        {
            currentValue = currentValue + num;
        }
        public virtual void Multiply(int num)
        {
            currentValue = currentValue * num;
        }

        public virtual void Subtract(int num)
        {
            currentValue = currentValue - num;
        }
        public virtual void Divide(int num)
        {
            currentValue = currentValue / num;
        }
        public void Clear()
        {
            currentValue = 0;
        }
    }

    
}
    
