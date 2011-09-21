using System;
using Blueprint.Web.Services;

namespace Blueprint.Tests.Support.Stubs
{
    public class StubClock : IClock
    {
        private DateTime? specifiedTime;

        public DateTime Now
        {
            get { return specifiedTime ?? DateTime.Now; }
            set { specifiedTime = value; }
        }
    }
}