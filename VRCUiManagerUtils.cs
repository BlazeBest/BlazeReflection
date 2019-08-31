using System;
using System.Reflection;
using System.Linq;
using VRC.Core;

namespace BlazeReflection
{
    public static class VRCUiManagerUtils
    {
        static VRCUiManagerUtils()
        {
            try
            {
                PropertyInfo propertyBuffer;

                propertyBuffer = null;
                propertyBuffer = typeof(VRCUiManager).GetProperties().FirstOrDefault((PropertyInfo p) => p.PropertyType == typeof(VRCUiManager));
                VRCUiManagerUtils.get_Instance_Method = ((propertyBuffer != null) ? propertyBuffer.GetGetMethod() : null);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[VRCUiManager] Error loading player types, fields, and methods.");
                Console.WriteLine(ex);
                Console.ResetColor();
            }
        }

        public static VRCUiManager get_Instance()
        {
            return (VRCUiManager)VRCUiManagerUtils.get_Instance_Method.Invoke(null, null);
        }

        private static MethodInfo get_Instance_Method;
    }
}
