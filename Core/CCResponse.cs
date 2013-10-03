namespace Core
{
    public class CCResponse
    {
        #region Constants

        private const string DefaultErrorMessage = "An Error occured";

        #endregion

        #region Properties

        public bool IsSuccessfull { get; set; }

        public string Message { get; set; }

        public object Data { get; set; }

        #endregion

        #region Constructor

        private CCResponse()
        {
        }

        #endregion

        #region Public Methods

        public static CCResponse Failed(string message = DefaultErrorMessage, object data = null)
        {
            return new CCResponse()
                {
                    IsSuccessfull = false,
                    Message = message,
                    Data = data
                };
        }

        public static CCResponse Succeded(object data = null)
        {
            return new CCResponse()
                {
                    IsSuccessfull = true,
                    Data = data
                };
        }

        #endregion
    }
}
