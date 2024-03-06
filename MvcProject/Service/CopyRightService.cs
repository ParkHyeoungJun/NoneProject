namespace MvcProject.Service
{
    public class CopyRightService : ICopyRightService
    {
        public string GetCopyRight()
        {
            return DateTime.Now.ToString("yyyy-MM-dd") + " Copy Ript";

        }
    }
}
