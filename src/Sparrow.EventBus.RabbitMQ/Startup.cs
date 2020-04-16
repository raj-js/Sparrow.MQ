using Sparrow.EventBus.Abstractions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace HiDoc.BuildingBlock.EventBus.RabbitMQ
{
    public static class Startup
    {
        /// <summary>
        /// 添加 RabbitMQ 作为事件总线
        /// </summary>
        /// <param name="services"></param>
        /// <param name="queueName">队列名</param>
        /// <param name="retryCount">重试次数</param>
        public static void AddRabbitMQEventBus(this IServiceCollection services, string queueName, int retryCount = 5) 
        {
            services.AddSingleton<IEventBus, EventBusRabbitMQ>(sp =>
            {
                var rabbitMQPersistentConnection = sp.GetRequiredService<IRabbitMQPersistentConnection>();
                var iLifetimeScope = sp.GetRequiredService<ILifetimeScope>();
                var logger = sp.GetRequiredService<ILogger<EventBusRabbitMQ>>();
                var eventBusSubcriptionsManager = sp.GetRequiredService<IEventBusSubscriptionsManager>();
                return new EventBusRabbitMQ(rabbitMQPersistentConnection, logger, iLifetimeScope, eventBusSubcriptionsManager, queueName, retryCount);
            });
        }
    }
}
