
namespace Lab6
{
    /// <summary>
    /// A class that implements the error system.
    /// </summary>
    public class Errors
    {
        private static int _errorCode = 0;

        /// <summary>
        /// Setter and getter for the error code.
        /// </summary>
        public static int ErrorCode
        {
            get => _errorCode;
            set => _errorCode = value;
        }

        /// <summary>
        /// Sets the value of the _errorCode field.
        /// </summary>
        /// <param name="errorCode">Error code.</param>
        public static void SetErrorCode(int errorCode)
        {
            ErrorCode = errorCode;
        }

        static string[] errorsArray = {
            "",
            "Incorrect name!",
            "Incorrect age of person!",
            "Incorrect gander of person!",
            "Incorrect average mark!",
            "Incorrect grade!",
            "Incorrect number of sunjects!",
            "Can't delete this element/incorrect index!",
            "Can't edit this element/incorrect index!",
            "Incorrect class data!"
        };

        /// <summary>
        /// Return curent error.
        /// </summary>
        /// <returns>Current error.</returns>
        public static string GetError()
        {
            return errorsArray[ErrorCode];
        }
    }
}
