namespace _0007_multiple_exceptions_filter
{
    static class MultiExceptionCatch
    {
        public static bool SomeOperation()
        {
            bool success = true;

            try
            {
                // Operation that could throw multiple types of exception
            }
            catch(NullReferenceException)
            {
                success = false;
            }
            catch(ArgumentNullException)
            {
                success = false;
            }
            catch(ArgumentOutOfRangeException)
            {
                success = false;
            }

            return success;
        }
    }
}
