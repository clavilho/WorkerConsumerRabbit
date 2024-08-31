using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

namespace WorkerConsumoRabbitMQ;

public class Consumidor
{

    public static async Task ConsumidorRabbit()
    {
        var connectionString = Environment.GetEnvironmentVariable("connectionStringRabbit");
        var factory = new ConnectionFactory()
        {
            Uri = new Uri(connectionString)
        };

        using var connection = factory.CreateConnection();
        using var channel = connection.CreateModel();

        channel.QueueDeclare(queue: "queue1",
                            durable: false,
                            exclusive: false,
                            autoDelete: false,
                            arguments: null);

        var consumer = new EventingBasicConsumer(channel);

        consumer.Received += (model, ea) =>
        {
            var body = ea.Body.ToArray();
            var message = Encoding.UTF8.GetString(body);
            Console.WriteLine($" [x] Received {message}");
        };

        var result = channel.BasicGet(queue: "queue1",
                             autoAck: true
                            );
        if (result != null)
        {
            var body = result.Body.ToArray();
            var message = Encoding.UTF8.GetString(body);

            Console.WriteLine($" [x] Received {message}");
        }
        else
        {
            Console.WriteLine("Sem mensagens disponiveis. Waiting...");
        }


    }


}
