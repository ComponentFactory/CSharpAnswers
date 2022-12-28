﻿namespace _0007_multiple_exceptions_filter
{
    class SingleExceptionCatch
    {
        public bool SomeOperation()
        {
            bool success = true;

            try
            {
                // Operation that could throw multiple types of exception
            }
            catch(Exception ex)
            {
                if ((ex is NullReferenceException) ||
                    (ex is ArgumentNullException) ||
                    (ex is ArgumentOutOfRangeException))
                {
                    success = false;
                }
                else
                    throw;
            }
            
            return success;
        }
    }
}
