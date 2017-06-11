using System.Linq;

namespace GigHub.ViewModels
{
    public class LuhnAlgorithmRefactor
    {
        public bool IsValid(object value)
        {
            if (value == null)
                return true;
            string creditCardNumber = value.ToString();
            if (!string.IsNullOrEmpty(creditCardNumber) && creditCardNumber.Length == 16)
            {
                int sumOfDigits = creditCardNumber.Where((e) => e >= '0' && e <= '9')
                .Reverse()
                .Select((e, i) => ((int)e - 48) * (i % 2 == 0 ? 1 : 2))
                .Sum((e) => e / 10 + e % 10);
                return sumOfDigits % 10 == 0;
            }
            return false;
        }
    }
}