using System.Threading.Tasks;
using Souq.SharedKernel;

namespace Souq.SharedKernel.Interfaces
{
    public interface IDomainEventDispatcher
    {
        Task Dispatch(BaseDomainEvent domainEvent);
    }
}