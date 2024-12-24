using OnionArchitecture.Contracts;
using OnionArchitecture.Entities.Models;

namespace OnionArchitecture.Repository;

public class CompanyRepository(RepositoryContext repositoryContext)
    : RepositoryBase<Company>(repositoryContext), ICompanyRepository
{

}