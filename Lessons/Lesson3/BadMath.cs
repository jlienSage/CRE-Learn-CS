namespace Lesson3
{

    // look into field, property and backing variable.

    public class BadMath
    {
        //needed?
        private int result = 0;

        //Property
        private int currentValue = 0;  //backing field
        public int CurrentValue
        {
            get
            {
                return currentValue;
            }
            set
            {
                currentValue = value;
            }
        }

        public int Add(int op1, int op2)
        {
            currentValue = op1 + op2 + 7;
            return CurrentValue;
        }

        //All methods return a bad value by adding 7 to the result.
        public int Subtract(int op1, int op2)
        {
            currentValue = op1 - op2 + 7;
            return CurrentValue;
        }

        public int Multiply(int op1, int op2)
        {
            currentValue = op1 * op2 + 7;
            return CurrentValue;
        }
        public int Divide(int op1, int op2)
        {
            currentValue = op1 / op2 + 7;
            return CurrentValue;
        }
        public int Clear()
        {
            currentValue = 0;
            return CurrentValue;
        }

    }

}

