using System;
using System.Reflection;
using System.Linq;
using VRC.Core;

namespace BlazeReflection
{
    public static class NotificationUtils
    {
        static NotificationUtils()
        {
            try
            {
                PropertyInfo propertyBuffer;

                propertyBuffer = null;
                propertyBuffer = typeof(NotificationManager).GetProperties().FirstOrDefault((PropertyInfo p) => p.PropertyType == typeof(NotificationManager));
                NotificationUtils.get_Instance_Method = ((propertyBuffer != null) ? propertyBuffer.GetGetMethod() : null);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[NotificationManager] Error loading player types, fields, and methods.");
                Console.WriteLine(ex);
                Console.ResetColor();
            }
        }

        public static NotificationManager get_Instance()
        {
            return (NotificationManager)NotificationUtils.get_Instance_Method.Invoke(null, null);
        }

        private static MethodInfo get_Instance_Method;
    }
}
