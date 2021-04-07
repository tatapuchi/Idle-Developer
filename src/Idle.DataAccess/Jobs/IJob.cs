using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.DataAccess.Jobs
{
    public interface IJob: IModel, IDescriptive, IRequirement, IProgress, IXPIncome, ICoinIncome
    {

    }
}
