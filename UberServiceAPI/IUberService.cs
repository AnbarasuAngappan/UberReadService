using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace UberServiceAPI
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IUberService" in both code and config file together.
    [ServiceContract]
    public interface IUberService
    {
        [OperationContract]
        DataTable GetHousdetails(string _houseID, string _apiKey);

        [OperationContract]
        DataTable GetHouseDetails();
    }
}
