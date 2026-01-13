using System;

public interface IMediator
{
	Task<TResponse> DispatchAsync<TRequest, Tresponse>(TRequest request)
}
