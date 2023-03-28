using System.Reflection;

namespace OOP4._2
{
    public class Model
    {
        int firstValue;
        int secondValue;
        int thirdValue;
        public EventHandler observers;
        public Model() 
        {
            firstValue = Properties.Settings.Default.FirstValue;
            secondValue = Properties.Settings.Default.SecondValue;
            thirdValue = Properties.Settings.Default.ThirdValue;
        }
        public int FirstValue
        {
            get
            {
                return firstValue;
            }
            set
            {
                if (value <= thirdValue)
                {
                    firstValue = value;
                    if (firstValue > secondValue)
                    {
                        secondValue = value;
                        if (firstValue > thirdValue)
                        {
                            thirdValue = value;
                        }
                    }
                    observers.Invoke(this, EventArgs.Empty);
                }
            }
        }
        public int SecondValue
        {
            get
            {
                return secondValue;
            }
            set
            {
                if (value >= firstValue && value <= thirdValue)
                    secondValue = value;
                observers.Invoke(this, EventArgs.Empty);
            }
        }
        public int ThirdValue
        {
            get
            {
                return thirdValue;
            }
            set
            {
                if (value >= firstValue)
                {
                    thirdValue = value;
                    if (thirdValue < secondValue)
                    {
                        secondValue = value;
                        if (thirdValue < firstValue)
                        {
                            firstValue = value;
                        }
                    }
                    observers.Invoke(this, EventArgs.Empty);
                }
            }
        }
    }
}
