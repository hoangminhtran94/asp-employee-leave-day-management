using AutoMapper;
using first_asp_app.Contracts;
using first_asp_app.Data;
using first_asp_app.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace first_asp_app.Repositories
{
    public class LeaveRequestRepository : GenericRepository<LeaveRequest>, ILeaveRequestRepository
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;
        private readonly IHttpContextAccessor httpContext;
        private readonly UserManager<Employee> userManager;
        private readonly ILeaveAllocationRepository leaveAllocationRepository;

        public LeaveRequestRepository(ApplicationDbContext context, IMapper mapper, IHttpContextAccessor httpContext,UserManager<Employee> userManager,ILeaveAllocationRepository leaveAllocationRepository) : base(context)
        {
            this.context = context;
            this.mapper = mapper;
            this.httpContext = httpContext;
            this.userManager = userManager;
            this.leaveAllocationRepository = leaveAllocationRepository;
        }

        public async Task ChangeApprovalStatus(int leaveRequestId, bool approved)
        {
            var leaveRequest = await GetAsync(leaveRequestId);
            leaveRequest.Approved = approved;
            if(approved)
            {
                var allocation = await leaveAllocationRepository.GetEmployeeAllocations(leaveRequest.RequestingEmployeeId, leaveRequest.LeaveTypeId);
                int dayRequested = (int)(leaveRequest.EndDate - leaveRequest.StartDate).TotalDays;
                allocation.NumberOfDays = allocation.NumberOfDays - dayRequested;
                await leaveAllocationRepository.UpdateAsync(allocation);

            }

            await UpdateAsync(leaveRequest);
        }
        public async Task<AdminLeaveRequestViewVM> GetAdminLeaveRequestList()
        {
            var leaveRequests = await context.leaveRequests.Include(q=>q.LeaveType).ToListAsync();
            var model = new AdminLeaveRequestViewVM
            {
                TotalRequests = leaveRequests.Count,
                ApprovedRequests = leaveRequests.Count(lr => lr.Approved == true),
                PendingRequests = leaveRequests.Count(lr => lr.Approved == null),
                RejectedRequests = leaveRequests.Count(lr => lr.Approved == false),
                LeaveRequests = mapper.Map<List<LeaveRequestVM>>(leaveRequests)

            };
            foreach (var leaveRequest in model.LeaveRequests)
            {
                leaveRequest.Employee = mapper.Map<EmployeeVM>(await userManager.FindByIdAsync(leaveRequest.RequestingEmployeeId));
            }
            return model;
        }


        public async Task CreateLeaveRequest(LeaveRequestCreateVM model)
        {
            var user = await userManager.GetUserAsync(httpContext?.HttpContext?.User);
           var leaveRequest = mapper.Map<LeaveRequest>(model);
           leaveRequest.DateCreated = DateTime.Now;
            leaveRequest.DateModified = DateTime.Now; 
            leaveRequest.RequestingEmployeeId = user.Id;
            await AddAsync(leaveRequest);
         
        }

    
        public async Task<List<LeaveRequest>> GetAllAsync(string employeeId)
        {
           return await context.leaveRequests.Where(lr=>lr.RequestingEmployeeId == employeeId).ToListAsync();
            
        }

        public async Task<EmployeeLeaveRequestViewVM> GetMyLeaveDetails()
        {
            var user = await userManager.GetUserAsync(httpContext?.HttpContext?.User);
            var allocations = (await leaveAllocationRepository.GetEmployeeAllocations(user.Id))?.LeaveAllocations;
            var requests = mapper.Map<List<LeaveRequestVM>>(await GetAllAsync(user.Id));
            var model = new EmployeeLeaveRequestViewVM(allocations, requests);

            return model;
        }

        public async Task<LeaveRequestVM?> GetLeaveRequestAsync(int? id)
        {
           var leaveRequest = await context.leaveRequests.Include(q=>q.LeaveType).FirstOrDefaultAsync(q=>q.Id == id);
            if (leaveRequest == null)
            {
                return null;
            }
            var model = mapper.Map<LeaveRequestVM>(leaveRequest);
            model.Employee = mapper.Map<EmployeeVM>(await userManager.FindByIdAsync(leaveRequest?.RequestingEmployeeId));
            return model;

        }
    }
}
