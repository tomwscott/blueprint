using System.Web.Mvc;

namespace Blueprint.Tests.Support
{
    public static class ViewResultExtensions
    {
        public static Model As<Model>(this ActionResult result)
        {
            return (Model) ((ViewResult) result).Model;
        }
    }
}