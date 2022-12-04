using LeaveManagementApplication.Contracts;
using LeaveManagementApplication.Data;

namespace LeaveManagementApplication.Repository
{
    public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
    {
        public LeaveTypeRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
