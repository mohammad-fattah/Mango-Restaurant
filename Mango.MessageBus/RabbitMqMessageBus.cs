using MassTransit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mango.MessageBus
{
    public class RabbitMqMessageBus : IMessageBus
    {
        public async Task PublishMessage(BaseMessage message, string uri)
        {
            var busControl = MyConfigurator.ConfigureBus();

            // Start the bus
            await busControl.StartAsync();

            await busControl.Publish(message);

            await busControl.StopAsync();
        }
    }
}
