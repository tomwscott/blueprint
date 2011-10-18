using System.Collections.Generic;

namespace Blueprint.Web.Services
{
    public interface IQuotesRepository
    {
        IList<int> FindAll();
    }

    public class QuotesRepository : IQuotesRepository
    {
        public IList<int> FindAll()
        {
            return new List<int> {1,2,3,4,5};
        }
    }
}