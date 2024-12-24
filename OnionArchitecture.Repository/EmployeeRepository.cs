using OnionArchitecture.Contracts;
using OnionArchitecture.Entities.Models;

namespace OnionArchitecture.Repository;

public class EmployeeRepository(RepositoryContext repositoryContext)
    : RepositoryBase<Employee>(repositoryContext), IEmployeeRepository
{
}