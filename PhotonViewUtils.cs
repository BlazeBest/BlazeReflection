using System;
using System.Reflection;
using System.Linq;
using Photon.Pun;

namespace BlazeReflection
{
    public static class PhotonViewUtils
    {
        static PhotonViewUtils()
        {
            try
            {
                PropertyInfo propertyBuffer;

                propertyBuffer = null;
                propertyBuffer = typeof(PhotonView).GetProperties().First((PropertyInfo p) => p.GetGetMethod().Name == "get_Controller");
                PhotonViewUtils.get_Controller_Method = ((propertyBuffer != null) ? propertyBuffer.GetGetMethod() : null);

                propertyBuffer = null;
                propertyBuffer = typeof(PhotonView).GetProperties().First((PropertyInfo p) => p.GetGetMethod().Name == "get_ControllerActorNr");
                PhotonViewUtils.get_ControllerActorNr_Method = ((propertyBuffer != null) ? propertyBuffer.GetGetMethod() : null);

                propertyBuffer = null;
                propertyBuffer = typeof(PhotonView).GetProperties().First((PropertyInfo p) => p.GetGetMethod().Name == "get_CreatorActorNr");
                PhotonViewUtils.get_CreatorActorNr_Method = ((propertyBuffer != null) ? propertyBuffer.GetGetMethod() : null);

                propertyBuffer = null;
                propertyBuffer = typeof(PhotonView).GetProperties().First((PropertyInfo p) => p.GetGetMethod().Name == "get_InstantiationData");
                PhotonViewUtils.get_InstantiationData_Method = ((propertyBuffer != null) ? propertyBuffer.GetGetMethod() : null);

                propertyBuffer = null;
                propertyBuffer = typeof(PhotonView).GetProperties().First((PropertyInfo p) => p.GetGetMethod().Name == "get_IsMine");
                PhotonViewUtils.get_IsMine_Method = ((propertyBuffer != null) ? propertyBuffer.GetGetMethod() : null);

                propertyBuffer = null;
                propertyBuffer = typeof(PhotonView).GetProperties().First((PropertyInfo p) => p.GetGetMethod().Name == "get_IsOwnerActive");
                PhotonViewUtils.get_IsOwnerActive_Method = ((propertyBuffer != null) ? propertyBuffer.GetGetMethod() : null);

                propertyBuffer = null;
                propertyBuffer = typeof(PhotonView).GetProperties().First((PropertyInfo p) => p.GetGetMethod().Name == "get_IsSceneView");
                PhotonViewUtils.get_IsSceneView_Method = ((propertyBuffer != null) ? propertyBuffer.GetGetMethod() : null);

                propertyBuffer = null;
                propertyBuffer = typeof(PhotonView).GetProperties().First((PropertyInfo p) => p.GetGetMethod().Name == "get_Owner");
                PhotonViewUtils.get_Owner_Method = ((propertyBuffer != null) ? propertyBuffer.GetGetMethod() : null);

                propertyBuffer = null;
                propertyBuffer = typeof(PhotonView).GetProperties().First((PropertyInfo p) => p.GetGetMethod().Name == "get_OwnerActorNr");
                PhotonViewUtils.get_OwnerActorNr_Method = ((propertyBuffer != null) ? propertyBuffer.GetGetMethod() : null);

                propertyBuffer = null;
                propertyBuffer = typeof(PhotonView).GetProperties().First((PropertyInfo p) => p.GetGetMethod().Name == "get_OwnershipWasTransfered");
                PhotonViewUtils.get_OwnershipWasTransfered_Method = ((propertyBuffer != null) ? propertyBuffer.GetGetMethod() : null);

                propertyBuffer = null;
                propertyBuffer = typeof(PhotonView).GetProperties().First((PropertyInfo p) => p.GetGetMethod().Name == "get_Prefix");
                PhotonViewUtils.get_Prefix_Method = ((propertyBuffer != null) ? propertyBuffer.GetGetMethod() : null);

                propertyBuffer = null;
                propertyBuffer = typeof(PhotonView).GetProperties().First((PropertyInfo p) => p.GetGetMethod().Name == "get_ViewID");
                PhotonViewUtils.get_ViewID_Method = ((propertyBuffer != null) ? propertyBuffer.GetGetMethod() : null);

                propertyBuffer = null;
                propertyBuffer = typeof(PhotonView).GetProperties().First((PropertyInfo p) => p.GetGetMethod().Name == "set_InstantiationData");
                PhotonViewUtils.set_InstantiationData_Method = ((propertyBuffer != null) ? propertyBuffer.GetGetMethod() : null);

                propertyBuffer = null;
                propertyBuffer = typeof(PhotonView).GetProperties().First((PropertyInfo p) => p.GetGetMethod().Name == "set_OwnershipWasTransfered");
                PhotonViewUtils.set_OwnershipWasTransfered_Method = ((propertyBuffer != null) ? propertyBuffer.GetGetMethod() : null);

                propertyBuffer = null;
                propertyBuffer = typeof(PhotonView).GetProperties().First((PropertyInfo p) => p.GetGetMethod().Name == "set_Prefix");
                PhotonViewUtils.set_Prefix_Method = ((propertyBuffer != null) ? propertyBuffer.GetGetMethod() : null);

                propertyBuffer = null;
                propertyBuffer = typeof(PhotonView).GetProperties().First((PropertyInfo p) => p.GetGetMethod().Name == "set_ViewID");
                PhotonViewUtils.set_ViewID_Method = ((propertyBuffer != null) ? propertyBuffer.GetGetMethod() : null);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[Photon] Error loading player types, fields, and methods.");
                Console.WriteLine(ex);
                Console.ResetColor();
            }
        }

        // JAAMJNHBFDN - PhotonClass

        public static JAAMJNHBFDN get_Controller(this PhotonView photon)
        {
            return (JAAMJNHBFDN)PhotonViewUtils.get_Controller_Method.Invoke(photon, null);
        }

        public static int get_ControllerActorNr(this PhotonView photon)
        {
            return (int)PhotonViewUtils.get_ControllerActorNr_Method.Invoke(photon, null);
        }

        public static int get_CreatorActorNr(this PhotonView photon)
        {
            return (int)PhotonViewUtils.get_CreatorActorNr_Method.Invoke(photon, null);
        }

        public static object[] get_InstantiationData(this PhotonView photon)
        {
            return (object[])PhotonViewUtils.get_InstantiationData_Method.Invoke(photon, null);
        }

        public static bool get_IsMine(this PhotonView photon)
        {
            return (bool)PhotonViewUtils.get_IsMine_Method.Invoke(photon, null);
        }

        public static bool get_IsOwnerActive(this PhotonView photon)
        {
            return (bool)PhotonViewUtils.get_IsOwnerActive_Method.Invoke(photon, null);
        }

        public static bool get_IsSceneView(this PhotonView photon)
        {
            return (bool)PhotonViewUtils.get_IsSceneView_Method.Invoke(photon, null);
        }

        public static JAAMJNHBFDN get_Owner(this PhotonView photon)
        {
            return (JAAMJNHBFDN)PhotonViewUtils.get_Owner_Method.Invoke(photon, null);
        }

        public static int get_OwnerActorNr(this PhotonView photon)
        {
            return (int)PhotonViewUtils.get_OwnerActorNr_Method.Invoke(photon, null);
        }

        public static bool get_OwnershipWasTransfered(this PhotonView photon)
        {
            return (bool)PhotonViewUtils.get_OwnershipWasTransfered_Method.Invoke(photon, null);
        }

        public static int get_Prefix(this PhotonView photon)
        {
            return (int)PhotonViewUtils.get_Prefix_Method.Invoke(photon, null);
        }

        public static int get_ViewID(this PhotonView photon)
        {
            return (int)PhotonViewUtils.get_ViewID_Method.Invoke(photon, null);
        }

        public static void set_InstantiationData(this PhotonView photon, object[] value)
        {
            PhotonViewUtils.set_InstantiationData_Method.Invoke(photon, new object[] { (object[])value });
        }

        public static void set_OwnershipWasTransfered(this PhotonView photon, bool value)
        {
            PhotonViewUtils.set_OwnershipWasTransfered_Method.Invoke(photon, new object[] { (bool)value });
        }

        public static void set_Prefix(this PhotonView photon, int value)
        {
            PhotonViewUtils.set_Prefix_Method.Invoke(photon, new object[] { (int)value });
        }

        public static void set_ViewID(this PhotonView photon, int value)
        {
            PhotonViewUtils.set_ViewID_Method.Invoke(photon, new object[] { (int)value });
        }

        private static MethodInfo get_Controller_Method;

        private static MethodInfo get_ControllerActorNr_Method;

        private static MethodInfo get_CreatorActorNr_Method;

        private static MethodInfo get_InstantiationData_Method;

        private static MethodInfo get_IsMine_Method;

        private static MethodInfo get_IsOwnerActive_Method;

        private static MethodInfo get_IsSceneView_Method;

        private static MethodInfo get_Owner_Method;

        private static MethodInfo get_OwnerActorNr_Method;

        private static MethodInfo get_OwnershipWasTransfered_Method;

        private static MethodInfo get_Prefix_Method;

        private static MethodInfo get_ViewID_Method;

        private static MethodInfo set_InstantiationData_Method;

        private static MethodInfo set_OwnershipWasTransfered_Method;

        private static MethodInfo set_Prefix_Method;

        private static MethodInfo set_ViewID_Method;
    }
}
