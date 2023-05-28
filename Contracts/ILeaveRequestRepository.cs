using first_asp_app.Data;
using first_asp_app.Models;

namespace first_asp_app.Contracts
{
    public interface ILeaveRequestRepository:IGenericRepository<LeaveRequest>
    {
        Task CreateLeaveRequest(LeaveRequestCreateVM model);
    }
}
