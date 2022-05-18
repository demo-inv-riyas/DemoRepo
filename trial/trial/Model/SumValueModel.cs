namespace trial.Model
{
    public class SumValueModel
    {
        public double FirstNumber { get; set; }
        public double SecondNumber { get; set; }
        public double Sum { get; set; } = 0;

        public override string ToString()
        {

            return (FirstNumber + SecondNumber).ToString();
        }

    }
}
