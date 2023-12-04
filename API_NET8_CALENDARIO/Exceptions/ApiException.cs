using System.Globalization;

namespace API_NET8_CALENDARIO.Exceptions
{
    public class ApiException: Exception
    {
        public ApiException():base (){}
        public ApiException(string message) : base(message) { }
        public ApiException(string message, params object[] args) : base(String.Format(CultureInfo.CurrentCulture, message, args)) { 
        
            
        }
    }
}
