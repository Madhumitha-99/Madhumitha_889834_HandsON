using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern_DP_T04
{
    public interface ILeaveRequestHandler
    {
        void HandleRequest(LeaveRequest leaveRequest);
        ILeaveRequestHandler nextHandler { get; set; }
    }
}
