using System.Globalization;

namespace SportClub.Aids 
{
    public class UseCulture
    {
        public static CultureInfo Current => CultureInfo.CurrentCulture;
        public static CultureInfo English => new CultureInfo("en-GB");
        public static CultureInfo Invariant => CultureInfo.InvariantCulture;
    }
}