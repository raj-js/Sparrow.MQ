using System.Threading.Tasks;

namespace HiDoc.BuildingBlock.EventBus.Abstractions
{
    /// <summary>
    /// 动态事件（内容）处理者
    /// </summary>
    public interface IDynamicIntegrationEventHandler
    {
        /// <summary>
        /// 处理动态消息
        /// </summary>
        /// <param name="eventData"></param>
        /// <returns></returns>
        Task Handle(dynamic eventData);
    }
}
