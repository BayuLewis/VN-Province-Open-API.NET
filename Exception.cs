namespace OpenProvinceVN.NET
{
    public class Exception : System.Exception
    {
        public Exception(string message) : base(message)
        {
        }
        
        public override string StackTrace => "";
    }
}