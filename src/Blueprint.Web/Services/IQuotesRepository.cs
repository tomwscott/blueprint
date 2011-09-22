using System.Collections.Generic;

namespace Blueprint.Web.Services
{
    public interface IQuotesRepository
    {
        IList<int> FindAll();
    }
}