using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern_DP_T04
{
    public class Supervisor:ILeaveRequestHandler
    {
        public ILeaveRequestHandler nextHandler { get; set; }
        public void HandleRequest(LeaveRequest leaveRequest)
        {
            if (leaveRequest.LeaveDays >= 1 && leaveRequest.LeaveDays <= 3)
            {
                Console.WriteLine("{0}'s leave for {1} approved by Supervisor", leaveRequest.Employee, leaveRequest.LeaveDays);
            }
            else
            {
                Console.WriteLine("Supervisor : Redirected to HR for Approval");
                nextHandler = new ProjectManager();
                nextHandler.HandleRequest(leaveRequest);
            }
        }
    }
}
