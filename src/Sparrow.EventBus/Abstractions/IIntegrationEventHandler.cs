using Sparrow.EventBus.Events;
using System.Threading.Tasks;

namespace Sparrow.EventBus.Abstractions
{
    /// <summary>
    /// 事件处理者
    /// </summary>
    /// <typeparam name="TIntegrationEvent"></typeparam>
    public interface IIntegrationEventHandler<in TIntegrationEvent> : IIntegrationEventHandler
        where TIntegrationEvent : IntegrationEvent
    {
        /// <summary>
        /// 处理事件
        /// </summary>
        /// <param name="event"></param>
        /// <returns></returns>
        Task Handle(TIntegrationEvent @event);
    }

    /// <summary>
    /// 事件处理者
    /// </summary>
    public interface IIntegrationEventHandler
    {

    }
}
