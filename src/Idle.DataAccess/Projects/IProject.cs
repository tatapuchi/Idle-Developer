using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.DataAccess.Projects
{
    public interface IProject: IModel, IDescriptive, IRequirement, IProgress, IXPIncome, ICoinIncome
    {

    }
}
