using System.Web;

namespace CoffeeConsumption.Managers
{
    public class SessionManager
    {
        private const string userIdParamName = "userId";

        public static int? GetCurrentUserId()
        {
            var userId = HttpContext.Current.Session[userIdParamName] as int?;
            return userId;
        }

        public static void SetCurrentUserID(int userID)
        {
            HttpContext.Current.Session[userIdParamName] = userID;
        }
    }
}