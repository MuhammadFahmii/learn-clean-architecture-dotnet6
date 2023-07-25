using Dapper.Contrib.Extensions;
using HR.LeaveManagement.Domain.Common;

namespace HR.LeaveManagement.Domain;

[Table("LeaveTypes")]
public class LeaveType : BaseDomainEntity
{
    public string Name { get; set; }
    public int DefaultDays { get; set; }
}