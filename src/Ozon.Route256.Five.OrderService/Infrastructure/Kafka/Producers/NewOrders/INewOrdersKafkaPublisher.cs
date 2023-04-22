﻿namespace Ozon.Route256.Five.OrderService.Infrastructure.Kafka.Producers.NewOrders;

public interface INewOrdersKafkaPublisher
{
    Task PublishToKafka(NewOrderDto dto, CancellationToken token);
}