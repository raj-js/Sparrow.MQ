using Microsoft.Extensions.DependencyInjection;

namespace Sparrow.EventBus
{
    public static class Startup
    {
        /// <summary>
        /// 添加默认的事件订阅者管理器
        /// </summary>
        /// <param name="services"></param>
        public static void AddDefaultSubscriptionManager(this IServiceCollection services)
        {
            services.AddSingleton<IEventBusSubscriptionsManager, InMemoryEventBusSubscriptionsManager>();
        }
    }
}
