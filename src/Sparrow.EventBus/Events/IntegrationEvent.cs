using System;

namespace Sparrow.EventBus.Events
{
    /// <summary>
    /// 事件
    /// </summary>
    public class IntegrationEvent
    {
        public IntegrationEvent()
        {
            Id = Guid.NewGuid();
            CreationTime = DateTime.UtcNow;
        }

        public IntegrationEvent(Guid id, DateTime createDate)
        {
            Id = id;
            CreationTime = createDate;
        }

        /// <summary>
        /// 事件唯一标识
        /// </summary>
        public Guid Id { get;  set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreationTime { get;  set; }
    }
}
