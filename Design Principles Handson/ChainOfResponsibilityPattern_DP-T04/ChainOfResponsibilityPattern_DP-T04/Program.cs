using System;

namespace ChainOfResponsibilityPattern_DP_T04
{
    class Program
    {
        static void Main(string[] args)
        {
            ILeaveRequestHandler leaveRequest = new Supervisor();
            LeaveRequest leaveRequest1 = new LeaveRequest() { LeaveDays = 2,Employee="Madhu" };
            leaveRequest.HandleRequest(leaveRequest1);
            Console.ReadLine();
        }
    }
}
