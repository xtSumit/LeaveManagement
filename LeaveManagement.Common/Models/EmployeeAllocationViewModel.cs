namespace LeaveManagement.Common.Models
{
    public class EmployeeAllocationViewModel: EmployeeListViewModel 
    {
        public List<LeaveAllocationViewModel> LeaveAllocation { get; set; }
    }
}
