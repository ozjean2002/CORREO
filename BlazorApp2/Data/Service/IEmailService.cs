using BlazorApp2.Data.model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorApp2.Data.service
{
    public interface IEmailService
    {
        Task<IEnumerable<Email>> GetAll();
    }
}