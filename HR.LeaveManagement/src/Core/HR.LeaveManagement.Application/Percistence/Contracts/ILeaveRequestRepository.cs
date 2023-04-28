using System;
using System.Collections.Generic;
using System.Text;
using HR.LeaveManagement.Domain;
namespace HR.LeaveManagement.Application.Contracts
{
    public interface ILeaveRequestRepository : IGenericRepository<LeaveRequest>
    {
    }
}
