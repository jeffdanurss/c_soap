using System.ServiceModel;

namespace soap.BusinessLogic
{
    
    public class SoapService : ISoapService
    {
        public string Sum(int num1, int num2)
        {
            return $"Sum={num1 + num2}";
        }
    }
    [ServiceContract]
    public interface ISoapService

    {
        [OperationContract]
        string Sum(int num1, int num2);
    }
}
