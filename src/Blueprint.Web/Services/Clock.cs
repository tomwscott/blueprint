using System;

namespace Blueprint.Web.Services
{
    public interface IClock
    {
       DateTime Now { get; }
    }

    public class Clock : IClock
    {
        public DateTime Now
        {
            get { return DateTime.Now; }
        }
    }
}