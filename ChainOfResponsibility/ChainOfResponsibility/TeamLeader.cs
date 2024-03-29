﻿
namespace ChainOfResponsibility
{
   
    public class TeamLeader : EmployeeLeaveHandler
    {
       
        private readonly int MAX_LEAVES_CAN_APPROVE = 10;

        public override void ApplyLeave(string EmployeeName, int NumberOfDaysLeave)
        {
            if (NumberOfDaysLeave <= MAX_LEAVES_CAN_APPROVE)
            {
                
                Console.WriteLine($"Team Leader Approved {NumberOfDaysLeave} Days Leave for the Employee {EmployeeName}");
            }
    
            else
            {
                if (Supervisor != null)
                    Supervisor.ApplyLeave(EmployeeName, NumberOfDaysLeave);
                else
                    throw new Exception("Null Reference Exception");
            }
        }
    }
}