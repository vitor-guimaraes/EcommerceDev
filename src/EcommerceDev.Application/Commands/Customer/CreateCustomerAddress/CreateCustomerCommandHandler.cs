using System;

public class CreateCustomerAdressCommandHandler : IHandler<CreateCustomerAddress, Guid>
{
    private readonly ICustomerRepository _customerRepository;

    public CreateCustomerAdressCommandHandler(ICustomerRepository customerRepository)
    {
        _customerRepository = customerRepository;
    }

    public async Task<Guid> HandleAsync (CreateCustomerAdressCommand request)
    {
        var customerAddress = new CustomerAddress(
            request.IdCustomer,
            request.RecipientName,
            request.AddressLine1,
            request.AddressLine2,
            request.ZipCode,
            request.District,
            request.State,
            request.City,
            request.Country
        );
        await _customerRepository.AddAsync(customerAddress);
        return customerAddress.Id;
    }

}
