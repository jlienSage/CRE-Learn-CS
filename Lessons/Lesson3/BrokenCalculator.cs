namespace Lesson3
{

    public class BrokenCalculator : ICalculator
    {

        protected decimal currentValue = 0;
        public decimal CurrentValue
        {
            get
            {
                return currentValue;
            }
        }
          public void Add(decimal num)
        {
            currentValue = currentValue + num +1;
            //base.Add(num +1);
        }
         public void Multiply(decimal num)
        {
            currentValue = currentValue * num +1;
            //base.Multiply(num *2);
        }

         public void Subtract(decimal num)
        {
           currentValue = currentValue - num +1;
           //base.Subtract(num +2);
        }
         public void Divide(decimal num)
        {
            currentValue = currentValue / num +1;
            //base.Divide(num +5);
        }

        public void Clear()
        {
            currentValue = 0;
        }
        
    }
}

