using CA.Application.Application.Common.Interfaces;

namespace CA.Application.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
