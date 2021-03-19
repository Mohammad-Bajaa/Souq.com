using System.Threading.Tasks;
using Souq.SharedKernel.Interfaces;
using Souq.SharedKernel;

namespace Souq.UnitTests
{
    public class NoOpDomainEventDispatcher : IDomainEventDispatcher
    {
        public Task Dispatch(BaseDomainEvent domainEvent)
        {
            return Task.CompletedTask;
        }
    }
}
