using System;
using System.Reflection;
using System.Linq;
using VRC.Core;

namespace BlazeReflection
{
    public static class VRCUiPopupManagerUtils
    {
        static VRCUiPopupManagerUtils()
        {
            try
            {
                PropertyInfo propertyBuffer;

                propertyBuffer = null;
                propertyBuffer = typeof(VRCUiPopupManager).GetProperties().FirstOrDefault((PropertyInfo p) => p.PropertyType == typeof(VRCUiPopupManager));
                VRCUiPopupManagerUtils.get_Instance_Method = ((propertyBuffer != null) ? propertyBuffer.GetGetMethod() : null);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[VRCUiPopupManager] Error loading player types, fields, and methods.");
                Console.WriteLine(ex);
                Console.ResetColor();
            }
        }

        public static VRCUiPopupManager get_Instance()
        {
            return (VRCUiPopupManager)VRCUiPopupManagerUtils.get_Instance_Method.Invoke(null, null);
        }

        private static MethodInfo get_Instance_Method;
    }
}
