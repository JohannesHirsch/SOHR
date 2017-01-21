//***********************************************************//
// File:    IClientService
// Project: SOHR.Shared
// Date:    29.12.2016
// Comment: Vertrag für das ClientService
//***********************************************************//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Collections.ObjectModel;

namespace SOHR.Shared.Contracts
{
    /// <summary>
    /// Vertrag für das ClientService
    /// </summary>
    [ServiceContract]
    public interface IClientService
    {
        [OperationContract]
        ObservableCollection<Header> LoadRuleSetHeaders();

        [OperationContract]
        RuleSet LoadRuleSet(Guid ID);

        [OperationContract]
        void SaveRuleSet(RuleSet set);

        [OperationContract]
        void DeleteRuleSet(Guid ID);
    }
}
