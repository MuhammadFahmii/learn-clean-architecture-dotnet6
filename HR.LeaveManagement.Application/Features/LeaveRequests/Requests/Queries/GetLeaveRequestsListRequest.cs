using HR.LeaveManagement.Application.DTOs.LeaveRequests;
using HR.LeaveManagement.Application.DTOs.LeaveTypes;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR.LeaveManagement.Application.Features.LeaveRequests.Requests.Queries
{
    public class GetLeaveRequestsListRequest : IRequest<List<LeaveRequestListDto>>
    {
    }
}
