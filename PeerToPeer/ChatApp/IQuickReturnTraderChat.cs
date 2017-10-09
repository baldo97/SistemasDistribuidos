using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp
{
    [ServiceContract]
    public interface IQuickReturnTraderChat
    {
        [OperationContract(IsOneWay = true)]
        void Say(string user, string message);

        // TODO: Add your service operations here
    }

}
