using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;

namespace BlazeReflection
{
    public static class RoomManagerUtils
    {
        static RoomManagerUtils()
        {
            try
            {
                PropertyInfo propertyBuffer;

                propertyBuffer = null;
                propertyBuffer = typeof(RoomManagerBase).GetProperties().FirstOrDefault((PropertyInfo p) => p.GetGetMethod().Name == "get_currentAuthorId");
                RoomManagerUtils.get_currentAuthorId_Method = ((propertyBuffer != null) ? propertyBuffer.GetGetMethod() : null);

                propertyBuffer = null;
                propertyBuffer = typeof(RoomManagerBase).GetProperties().FirstOrDefault((PropertyInfo p) => p.GetGetMethod().Name == "get_currentOwnerId");
                RoomManagerUtils.get_currentAuthorId_Method = ((propertyBuffer != null) ? propertyBuffer.GetGetMethod() : null);
                
                propertyBuffer = null;
                propertyBuffer = typeof(RoomManagerBase).GetProperties().FirstOrDefault((PropertyInfo p) => p.GetGetMethod().Name == "get_inRoom");
                RoomManagerUtils.get_inRoom_Method = ((propertyBuffer != null) ? propertyBuffer.GetGetMethod() : null);

                propertyBuffer = null;
                propertyBuffer = typeof(RoomManagerBase).GetProperties().FirstOrDefault((PropertyInfo p) => p.GetGetMethod().Name == "get_metadata");
                RoomManagerUtils.get_metadata_Method = ((propertyBuffer != null) ? propertyBuffer.GetGetMethod() : null);

                propertyBuffer = null;
                propertyBuffer = typeof(RoomManagerBase).GetProperties().FirstOrDefault((PropertyInfo p) => p.GetGetMethod().Name == "get_TimeSinceEnteredRoom");
                RoomManagerUtils.get_metadata_Method = ((propertyBuffer != null) ? propertyBuffer.GetGetMethod() : null);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[RoomManager] Error loading player types, fields, and methods.");
                Console.WriteLine(ex);
                Console.ResetColor();
            }
        }

        public static string get_currentAuthorId()
        {
            return (string)RoomManagerUtils.get_currentAuthorId_Method.Invoke(null, null);
        }
        
        public static string get_currentOwnerId()
        {
            return (string)RoomManagerUtils.get_currentOwnerId_Method.Invoke(null, null);
        }        

        public static bool get_inRoom()
        {
            return (bool)RoomManagerUtils.get_inRoom_Method.Invoke(null, null);
        }

        public static Dictionary<string, object> get_metadata()
        {
            return (Dictionary<string, object>)RoomManagerUtils.get_metadata_Method.Invoke(null, null);
        }

        public static float get_TimeSinceEnteredRoom()
        {
            return (float)RoomManagerUtils.get_TimeSinceEnteredRoom_Method.Invoke(null, null);
        }

        private static MethodInfo get_currentAuthorId_Method;

        private static MethodInfo get_currentOwnerId_Method;

        private static MethodInfo get_inRoom_Method;

        private static MethodInfo get_metadata_Method;

        private static MethodInfo get_TimeSinceEnteredRoom_Method;
    }
}
