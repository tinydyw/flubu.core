using Flubu.Context;
using Flubu.Tasks;

namespace Flubu.Packaging
{
    public static class LoggingHelper
    {
        public static bool LogIfFilteredOut(string fileName, IFileFilter filter, ITaskContext taskContext)
        {
            if (filter != null && !filter.IsPassedThrough(fileName))
            {
                taskContext.WriteMessage(string.Format("File '{0}' has been filtered out.", fileName));
                return false;
            }

            return true;
        }
    }
}