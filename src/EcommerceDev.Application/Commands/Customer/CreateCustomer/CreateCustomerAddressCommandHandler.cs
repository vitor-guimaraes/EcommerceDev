using System;

public class CreateCustomerAddressCommandHandler : IHandler<CreateCustomerAddressCommand, Guid>
{
    private readonly ICustomerRepository _customerRepository;
    public CreateCustomerAddressCommandHandler(ICustomerRepository customerRepository)
    {
        _customerRepository = customerRepository;
    }
    public async Task<Guid> HandleAsync(CreateCustomerAddressCommand request)
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
        return customerAddress.IdCustomer;
    }
}


1:12:33