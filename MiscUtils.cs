using System.Reflection;
using System.Linq;

namespace BlazeReflection
{
    public static class MiscUtils
    {
        public static ModerationManager ModerationManager
        {
            get
            {
                if (get_ModerationManager_Method == null)
                {
                    PropertyInfo propertyBuffer = typeof(ModerationManager).GetProperties().FirstOrDefault((PropertyInfo p) => p.PropertyType == typeof(ModerationManager));
                    get_ModerationManager_Method = ((propertyBuffer != null) ? propertyBuffer.GetGetMethod() : null);
                }
                return (ModerationManager)get_ModerationManager_Method.Invoke(null, null);
            }
        }

        public static NotificationManager NotificationManager
        {
            get
            {
                if (get_NotificationManager_Method == null)
                {
                    PropertyInfo propertyBuffer = typeof(NotificationManager).GetProperties().FirstOrDefault((PropertyInfo p) => p.PropertyType == typeof(NotificationManager));
                    get_NotificationManager_Method = ((propertyBuffer != null) ? propertyBuffer.GetGetMethod() : null);
                }
                return (NotificationManager)get_NotificationManager_Method.Invoke(null, null);
            }
        }

        public static VRCApplicationSetup VRCApplicationSetup
        {
            get
            {
                if (get_VRCApplicationSetup_Method == null)
                {
                    PropertyInfo propertyBuffer = typeof(VRCApplicationSetup).GetProperties().FirstOrDefault((PropertyInfo p) => p.PropertyType == typeof(VRCApplicationSetup));
                    get_VRCApplicationSetup_Method = ((propertyBuffer != null) ? propertyBuffer.GetGetMethod() : null);
                }
                return (VRCApplicationSetup)get_VRCApplicationSetup_Method.Invoke(null, null);
            }
        }

        public static VRCFlowManager VRCFlowManager
        {
            get
            {
                if (get_VRCFlowManager_Method == null)
                {
                    PropertyInfo propertyBuffer = typeof(VRCFlowManager).GetProperties().FirstOrDefault((PropertyInfo p) => p.PropertyType == typeof(VRCFlowManager));
                    get_VRCFlowManager_Method = ((propertyBuffer != null) ? propertyBuffer.GetGetMethod() : null);
                }
                return (VRCFlowManager)get_VRCFlowManager_Method.Invoke(null, null);
            }
        }

        public static VRCUiManager VRCUiManager
        {
            get
            {
                if (get_VRCUiManager_Method == null)
                {
                    PropertyInfo propertyBuffer = typeof(VRCUiManager).GetProperties().FirstOrDefault((PropertyInfo p) => p.PropertyType == typeof(VRCUiManager));
                    get_VRCUiManager_Method = ((propertyBuffer != null) ? propertyBuffer.GetGetMethod() : null);
                }
                return (VRCUiManager)get_VRCUiManager_Method.Invoke(null, null);
            }
        }

        public static VRCUiPopupManager VRCUiPopupManager
        {
            get
            {
                if (get_VRCUiPopupManager_Method == null)
                {
                    PropertyInfo propertyBuffer = typeof(VRCUiPopupManager).GetProperties().FirstOrDefault((PropertyInfo p) => p.PropertyType == typeof(VRCUiPopupManager));
                    get_VRCUiPopupManager_Method = ((propertyBuffer != null) ? propertyBuffer.GetGetMethod() : null);
                }
                return (VRCUiPopupManager)get_VRCUiPopupManager_Method.Invoke(null, null);
            }
        }

        private static MethodInfo get_ModerationManager_Method;

        private static MethodInfo get_NotificationManager_Method;

        private static MethodInfo get_VRCApplicationSetup_Method;

        private static MethodInfo get_VRCFlowManager_Method;

        private static MethodInfo get_VRCUiManager_Method;

        private static MethodInfo get_VRCUiPopupManager_Method;
    }
}
