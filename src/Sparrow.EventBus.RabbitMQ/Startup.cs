using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Sparrow.EventBus.Abstractions;
using System;

namespace Sparrow.EventBus.RabbitMQ
{
    public static class Startup
    {
        /// <summary>
        /// 添加 RabbitMQ 作为事件总线
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="queueName">队列名</param>
        /// <param name="retryCount">重试次数</param>
        public static void AddRabbitMQEventBus(this IServiceCollection services, IServiceProvider provider, string queueName, int retryCount = 5) 
        {
            services.AddSingleton<IEventBus, EventBusRabbitMQ>(sp =>
            {
                var rabbitMQPersistentConnection = sp.GetRequiredService<IRabbitMQPersistentConnection>();
                var logger = sp.GetRequiredService<ILogger<EventBusRabbitMQ>>();
                var eventBusSubcriptionsManager = sp.GetRequiredService<IEventBusSubscriptionsManager>();

                return new EventBusRabbitMQ(rabbitMQPersistentConnection, logger, provider, eventBusSubcriptionsManager, queueName, retryCount);
            });
        }
    }
}
