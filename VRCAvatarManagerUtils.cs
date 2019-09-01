using System;
using System.Reflection;
using System.Linq;
using VRCSDK2;
using VRC.Core;
using Player = VRC.Player;

namespace BlazeReflection
{
    public static class VRCAvatarManagerUtils
    {
        static VRCAvatarManagerUtils()
        {
            try
            {
                PropertyInfo propertyBuffer;

                propertyBuffer = null;
                propertyBuffer = typeof(VRCPlayer).GetProperties().FirstOrDefault((PropertyInfo p) => p.GetGetMethod().Name == "get_apiPlayer");
                VRCAvatarManagerUtils.get_apiPlayer_Method = ((propertyBuffer != null) ? propertyBuffer.GetGetMethod() : null);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[VRCAvatarManager] Error loading player types, fields, and methods.");
                Console.WriteLine(ex);
                Console.ResetColor();
            }
        }

        public static ApiAvatar get_CurrentAvatar(this VRCAvatarManager avatarManager)
        {
            return (ApiAvatar)VRCAvatarManagerUtils.get_apiPlayer_Method.Invoke(avatarManager, null);
        }

        private static MethodInfo get_apiPlayer_Method;
    }
}
