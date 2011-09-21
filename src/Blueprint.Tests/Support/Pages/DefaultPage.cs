namespace Blueprint.Tests.Support.Pages
{
    public class DefaultPage : Page<DefaultPage>
    {
        public DefaultPage(Browser.Driver driver) : base(driver, "/")
        {
        }
    }
}