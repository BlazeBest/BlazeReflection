using System;
using System.Reflection;
using System.Linq;
using VRC.Core;

namespace BlazeReflection
{
    public static class VRCApplicationSetupUtils
    {
        static VRCApplicationSetupUtils()
        {
            try
            {
                PropertyInfo propertyBuffer;

                propertyBuffer = null;
                propertyBuffer = typeof(VRCApplicationSetup).GetProperties().FirstOrDefault((PropertyInfo p) => p.PropertyType == typeof(VRCApplicationSetup));
                VRCApplicationSetupUtils.get_Instance_Method = ((propertyBuffer != null) ? propertyBuffer.GetGetMethod() : null);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[VRCApplicationSetup] Error loading player types, fields, and methods.");
                Console.WriteLine(ex);
                Console.ResetColor();
            }
        }

        public static VRCApplicationSetup get_Instance()
        {
            return (VRCApplicationSetup)VRCApplicationSetupUtils.get_Instance_Method.Invoke(null, null);
        }

        private static MethodInfo get_Instance_Method;
    }
}
