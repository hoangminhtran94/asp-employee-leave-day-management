using LeaveManagement.Data;
using first_asp_app.Models;

namespace first_asp_app.Contracts
{
    public interface ILeaveAllocationRepository: IGenericRepository<LeaveAllocation>
    {
       Task LeaveAllocation(int leaveTypeId);
       Task<bool> AllocationExists(string employeeId, int leaveTypeId, int period);
        Task<EmployeeAllocationVM> GetEmployeeAllocations(string employeeId);
        Task<LeaveAllocation?> GetEmployeeAllocations(string employeeId, int leaveTypeId);

    }
}
