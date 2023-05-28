using AutoMapper;
using first_asp_app.Contracts;
using first_asp_app.Data;
using first_asp_app.Models;
using Microsoft.AspNetCore.Identity;

namespace first_asp_app.Repositories
{
    public class LeaveRequestRepository : GenericRepository<LeaveRequest>, ILeaveRequestRepository
    {
        private readonly IMapper mapper;
        private readonly IHttpContextAccessor httpContext;
        private readonly UserManager<Employee> userManager;

        public LeaveRequestRepository(ApplicationDbContext context, IMapper mapper, IHttpContextAccessor httpContext,UserManager<Employee> userManager) : base(context)
        {
            this.mapper = mapper;
            this.httpContext = httpContext;
            this.userManager = userManager;
        }

        public async Task CreateLeaveRequest(LeaveRequestCreateVM model)
        {
            var user = await userManager.GetUserAsync(httpContext?.HttpContext?.User);
           var leaveRequest = mapper.Map<LeaveRequest>(model);
           leaveRequest.DateCreated = DateTime.Now;
            leaveRequest.RequestingEmployeeId = user.Id;
            await AddAsync(leaveRequest);
         
        }
    }
}
