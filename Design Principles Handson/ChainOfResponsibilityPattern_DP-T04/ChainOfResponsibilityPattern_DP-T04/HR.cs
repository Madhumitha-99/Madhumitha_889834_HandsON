using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern_DP_T04
{
    public class HR:ILeaveRequestHandler
    {
        public ILeaveRequestHandler nextHandler { get; set; }
        public void HandleRequest(LeaveRequest leaveRequest)
        {
            if (leaveRequest.LeaveDays > 5)
            {
                Console.WriteLine("{0}'s leave for {1} days is approved by HR", leaveRequest.Employee, leaveRequest.LeaveDays);
            }
            else
            {
                nextHandler.HandleRequest(leaveRequest);
            }
        }
    }
}
