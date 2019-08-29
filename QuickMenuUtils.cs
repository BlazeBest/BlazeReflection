using System;
using System.Reflection;
using System.Linq;
using VRC.Core;

namespace BlazeReflection
{
    public static class QuickMenuUtils
    {
        static QuickMenuUtils()
        {
            try
            {
                PropertyInfo propertyBuffer;

                propertyBuffer = null;
                propertyBuffer = typeof(QuickMenu).GetProperties().First((PropertyInfo p) => p.GetGetMethod().Name == "get_canRecvReqInvite");
                QuickMenuUtils.get_canRecvReqInvite_Method = ((propertyBuffer != null) ? propertyBuffer.GetGetMethod() : null);

                propertyBuffer = null;
                propertyBuffer = typeof(QuickMenu).GetProperties().First((PropertyInfo p) => p.GetGetMethod().Name == "get_Instance");
                QuickMenuUtils.get_canRecvReqInvite_Method = ((propertyBuffer != null) ? propertyBuffer.GetGetMethod() : null);

                propertyBuffer = null;
                propertyBuffer = typeof(QuickMenu).GetProperties().First((PropertyInfo p) => p.GetGetMethod().Name == "get_IsActive");
                QuickMenuUtils.get_IsActive_Method = ((propertyBuffer != null) ? propertyBuffer.GetGetMethod() : null);

                propertyBuffer = null;
                propertyBuffer = typeof(QuickMenu).GetProperties().First((PropertyInfo p) => p.GetGetMethod().Name == "get_IsOnRightHand");
                QuickMenuUtils.get_IsOnRightHand_Method = ((propertyBuffer != null) ? propertyBuffer.GetGetMethod() : null);

                propertyBuffer = null;
                propertyBuffer = typeof(QuickMenu).GetProperties().First((PropertyInfo p) => p.GetGetMethod().Name == "get_SelectedUser");
                QuickMenuUtils.get_SelectedUser_Method = ((propertyBuffer != null) ? propertyBuffer.GetGetMethod() : null);

                propertyBuffer = null;
                propertyBuffer = typeof(QuickMenu).GetProperties().First((PropertyInfo p) => p.GetGetMethod().Name == "set_SelectedUser");
                QuickMenuUtils.set_SelectedUser_Method = ((propertyBuffer != null) ? propertyBuffer.GetGetMethod() : null);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[QuickMenu] Error loading player types, fields, and methods.");
                Console.WriteLine(ex);
                Console.ResetColor();
            }
        }

        public static bool get_canRecvReqInvite(this QuickMenu quickMenu)
        {
            return (bool)QuickMenuUtils.get_canRecvReqInvite_Method.Invoke(quickMenu, null);
        }

        public static QuickMenu get_Instance()
        {
            return (QuickMenu)QuickMenuUtils.get_Instance_Method.Invoke(null, null);
        }

        public static bool get_IsActive(this QuickMenu quickMenu)
        {
            return (bool)QuickMenuUtils.get_IsActive_Method.Invoke(quickMenu, null);
        }
        
        public static bool get_IsOnRightHand(this QuickMenu quickMenu)
        {
            return (bool)QuickMenuUtils.get_IsOnRightHand_Method.Invoke(quickMenu, null);
        }

        public static APIUser get_SelectedUser(this QuickMenu quickMenu)
        {
            return (APIUser)QuickMenuUtils.get_SelectedUser_Method.Invoke(quickMenu, null);
        }

        public static void set_SelectedUser(this QuickMenu quickMenu, APIUser value)
        {
            QuickMenuUtils.set_SelectedUser_Method.Invoke(quickMenu, new object[] { (APIUser)value });
        }

        private static MethodInfo get_canRecvReqInvite_Method;

        private static MethodInfo get_Instance_Method;

        private static MethodInfo get_IsActive_Method;

        private static MethodInfo get_IsOnRightHand_Method;

        private static MethodInfo get_SelectedUser_Method;

        private static MethodInfo set_SelectedUser_Method;
    }
}
