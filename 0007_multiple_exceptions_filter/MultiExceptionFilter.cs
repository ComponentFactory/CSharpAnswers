namespace _0007_multiple_exceptions_filter
{
    static class MultiExceptionFilter
    {
        public static bool SomeOperation()
        {
            bool success = true;

            try
            {
                // Operation that could throw multiple types of exception
            }
            catch(Exception ex) when ((ex is NullReferenceException) ||
                                      (ex is ArgumentNullException) ||
                                      (ex is ArgumentOutOfRangeException))
            {
                success = false;
            }

            return success;
        }
    }
}
