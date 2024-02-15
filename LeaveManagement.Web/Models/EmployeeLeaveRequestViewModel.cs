namespace LeaveManagement.Web.Models
{
    public class EmployeeLeaveRequestViewModel
    {
        public EmployeeLeaveRequestViewModel( List<LeaveAllocationViewModel> allocations, List<LeaveRequestViewModel> requests)
        {
            LeaveAllocations = allocations;
            LeaveRequests = requests;
        }

        public List<LeaveAllocationViewModel> LeaveAllocations { get; set; }
        public List<LeaveRequestViewModel> LeaveRequests { get; set; }
    }
}
