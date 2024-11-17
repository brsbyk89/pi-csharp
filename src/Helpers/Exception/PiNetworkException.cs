using PiNetworkNet.src.Dto;

namespace PiNetworkNet.src.Helpers.Exception
{
    public class PiNetworkException : System.Exception
    {
        public PiNetworkError PiError { get; set; }
    }
}
