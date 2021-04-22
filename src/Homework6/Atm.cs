namespace Homework6
{
    public class Atm
    {
        public delegate void AccountHandler(string message);

        public event AccountHandler Notify;

        public Atm(int sum)
        {
            Sum = sum;
        }

        public int Sum { get; private set; }

        public void Put(int sum)
        {
            Sum += sum;
            Notify?.Invoke($"Your account has recived {sum} BYN");
        }

        public void Take(int sum)
        {
            if (Sum >= sum)
            {
                Sum -= sum;
                Notify?.Invoke($"Whithdrawn from your account {sum} BYN");
            }
            else
            {
                Notify?.Invoke($"Sum unavailable. Current balance: {Sum} BYN");
            }
        }
    }
}
