using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Collections.ObjectModel;

namespace SOHR.Shared.Contracts
{
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
