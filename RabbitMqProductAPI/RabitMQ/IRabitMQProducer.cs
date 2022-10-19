namespace RabbitMqProductAPI.RabitMQ
{
    public interface IRabitMQProducer
    {
        public void SendProductMessage<T> (T message);
    }
}
