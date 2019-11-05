namespace Lesson3
{

    public class BrokenCalculator : Calculator
    {
          public override void Add(int num)
        {
            //currentValue = currentValue + num +1;
            base.Add(num +1);
        }
         public override void Multiply(int num)
        {
            //currentValue = currentValue * num +1;
            base.Multiply(num *2);
        }

         public override void Subtract(int num)
        {
           //currentValue = currentValue - num +1;
           base.Subtract(num +2);
        }
         public override void Divide(int num)
        {
            //currentValue = currentValue / num +1;
            base.Divide(num +5);
        }
        
    }
}

