using System.Threading.Tasks;
using Souq.SharedKernel;

namespace Souq.SharedKernel.Interfaces
{
    public interface IHandle<in T> where T : BaseDomainEvent
    {
        Task Handle(T domainEvent);
    }
}