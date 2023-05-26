using AutoMapper;
using first_asp_app.Constanst;
using first_asp_app.Contracts;
using first_asp_app.Data;
using first_asp_app.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace first_asp_app.Repositories
{
    public class LeaveAllocationRepository : GenericRepository<LeaveAllocation>, ILeaveAllocationRepository
    {
        private readonly ApplicationDbContext context;
        private readonly ILeaveTypeRepository leaveTypeRepo;
        private readonly UserManager<Employee> userManager;
        private readonly IMapper mapper;

        public LeaveAllocationRepository(ApplicationDbContext context, ILeaveTypeRepository leaveTypeRepo, UserManager<Employee> userManager, IMapper mapper) : base(context)
        {
            this.context = context;
            this.leaveTypeRepo = leaveTypeRepo;
            this.userManager = userManager;
            this.mapper = mapper;
        }

        public async Task<bool> AllocationExists(string employeeId, int leaveTypeId, int period)
        {

            return await context.LeaveAllocations.AnyAsync(allocation=> allocation.EmployeeId == employeeId && allocation.LeaveTypeId == leaveTypeId && allocation.Period == period );
        }

        public async Task<EmployeeAllocationVM> GetEmployeeAllocations(string employeeId)
        {
            var allocations = await context.LeaveAllocations.Include(allocation=>allocation.LeaveType).Where(allocation => allocation.EmployeeId == employeeId).ToListAsync();
            var employee = await userManager.FindByIdAsync(employeeId);
            var employeeAllocationVM = mapper.Map<EmployeeAllocationVM>(employee);
            employeeAllocationVM.LeaveAllocations = mapper.Map<List<LeaveAllocationVM>>(allocations);
            return employeeAllocationVM;
        }

        public async Task LeaveAllocation(int leaveTypeId)
        {
            var employees = await userManager.GetUsersInRoleAsync(Roles.User);
            var period = DateTime.Now.Year;
            var leaveType = await leaveTypeRepo.GetAsync(leaveTypeId);
            var allocations = new List<LeaveAllocation>();
            foreach (var employee in employees)
            {
                if(!await AllocationExists(employee.Id, leaveTypeId, period))
                {

                allocations.Add(new LeaveAllocation
                {
                    EmployeeId = employee.Id,
                    LeaveTypeId = leaveTypeId,
                    Period = period,
                    NumberOfDays = leaveType.DefaultDays,
                    DateCreated = DateTime.Now,
                    DateModified = DateTime.Now,

                });
                }
            }

                await AddRangeAsync(allocations);
        }
    }
}
