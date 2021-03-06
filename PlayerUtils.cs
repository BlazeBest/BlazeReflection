using System;
using System.Reflection;
using System.Linq;
using VRCSDK2;
using VRC;
using VRC.Core;
using ExitGames.Client.Photon;
using Player = VRC.Player;

namespace BlazeReflection
{
    public static class PlayerUtils
    {
        static PlayerUtils()
        {
            try
            {
                PropertyInfo propertyBuffer;

                propertyBuffer = null;
                propertyBuffer = typeof(VRCPlayer).GetProperties().FirstOrDefault((PropertyInfo p) => p.GetGetMethod().Name == "get_apiPlayer");
                PlayerUtils.get_apiPlayer_Method = ((propertyBuffer != null) ? propertyBuffer.GetGetMethod() : null);

                propertyBuffer = null;
                propertyBuffer = typeof(VRCPlayer).GetProperties().FirstOrDefault((PropertyInfo p) => p.GetGetMethod().Name == "get_AvatarManager");
                PlayerUtils.get_AvatarManager_Method = ((propertyBuffer != null) ? propertyBuffer.GetGetMethod() : null);

                propertyBuffer = null;
                propertyBuffer = typeof(VRCPlayer).GetProperties().FirstOrDefault((PropertyInfo p) => p.GetGetMethod().Name == "get_player");
                PlayerUtils.get_player_Method = ((propertyBuffer != null) ? propertyBuffer.GetGetMethod() : null);

                propertyBuffer = null;
                propertyBuffer = typeof(VRCPlayer).GetProperties().FirstOrDefault((PropertyInfo p) => p.GetGetMethod().Name == "get_SteamUserIDULong");
                PlayerUtils.get_SteamUserID_Method = ((propertyBuffer != null) ? propertyBuffer.GetGetMethod() : null);
                
                propertyBuffer = null;
                propertyBuffer = typeof(VRCPlayer).GetProperties().FirstOrDefault((PropertyInfo p) => p.GetGetMethod().Name == "get_Ping");
                PlayerUtils.get_Ping_Method = ((propertyBuffer != null) ? propertyBuffer.GetGetMethod() : null);
                
                propertyBuffer = null;
                propertyBuffer = typeof(Player).GetProperties().FirstOrDefault((PropertyInfo p) => p.GetGetMethod().Name == "get_Instance");
                PlayerUtils.get_Instance_Method = ((propertyBuffer != null) ? propertyBuffer.GetGetMethod() : null);
                                
                propertyBuffer = null;
                propertyBuffer = typeof(Player).GetProperties().FirstOrDefault((PropertyInfo p) => p.GetGetMethod().Name == "get_PhotonPlayer");
                PlayerUtils.get_PhotonPlayer_Method = ((propertyBuffer != null) ? propertyBuffer.GetGetMethod() : null);

                propertyBuffer = null;
                propertyBuffer = typeof(Player).GetProperties().FirstOrDefault((PropertyInfo p) => p.GetGetMethod().Name == "get_isBlockedEitherWay");
                PlayerUtils.get_isBlockedEitherWay_Method = ((propertyBuffer != null) ? propertyBuffer.GetGetMethod() : null);
                
                propertyBuffer = null;
                propertyBuffer = typeof(Player).GetProperties().FirstOrDefault((PropertyInfo p) => p.GetGetMethod().Name == "get_isFavoriteFriend");
                PlayerUtils.get_isFavoriteFriend_Method = ((propertyBuffer != null) ? propertyBuffer.GetGetMethod() : null);
                
                propertyBuffer = null;
                propertyBuffer = typeof(Player).GetProperties().FirstOrDefault((PropertyInfo p) => p.GetGetMethod().Name == "get_isFriend");
                PlayerUtils.get_isFriend_Method = ((propertyBuffer != null) ? propertyBuffer.GetGetMethod() : null);
                
                propertyBuffer = null;
                propertyBuffer = typeof(Player).GetProperties().FirstOrDefault((PropertyInfo p) => p.GetGetMethod().Name == "get_isInstanceOwner");
                PlayerUtils.get_isInstanceOwner_Method = ((propertyBuffer != null) ? propertyBuffer.GetGetMethod() : null);
                
                propertyBuffer = null;
                propertyBuffer = typeof(Player).GetProperties().FirstOrDefault((PropertyInfo p) => p.GetGetMethod().Name == "get_isLoaded");
                PlayerUtils.get_isLoaded_Method = ((propertyBuffer != null) ? propertyBuffer.GetGetMethod() : null);
                
                propertyBuffer = null;
                propertyBuffer = typeof(Player).GetProperties().FirstOrDefault((PropertyInfo p) => p.GetGetMethod().Name == "get_IsLocal");
                PlayerUtils.get_IsLocal_Method = ((propertyBuffer != null) ? propertyBuffer.GetGetMethod() : null);
                
                propertyBuffer = null;
                propertyBuffer = typeof(Player).GetProperties().FirstOrDefault((PropertyInfo p) => p.GetGetMethod().Name == "get_IsMaster");
                PlayerUtils.get_IsMaster_Method = ((propertyBuffer != null) ? propertyBuffer.GetGetMethod() : null);
                
                propertyBuffer = null;
                propertyBuffer = typeof(Player).GetProperties().FirstOrDefault((PropertyInfo p) => p.GetGetMethod().Name == "get_isModerator");
                PlayerUtils.get_isModerator_Method = ((propertyBuffer != null) ? propertyBuffer.GetGetMethod() : null);
                
                propertyBuffer = null;
                propertyBuffer = typeof(Player).GetProperties().FirstOrDefault((PropertyInfo p) => p.GetGetMethod().Name == "get_isRoomAuthor");
                PlayerUtils.get_isRoomAuthor_Method = ((propertyBuffer != null) ? propertyBuffer.GetGetMethod() : null);
                
                propertyBuffer = null;
                propertyBuffer = typeof(Player).GetProperties().FirstOrDefault((PropertyInfo p) => p.GetGetMethod().Name == "get_isSuper");
                PlayerUtils.get_isSuper_Method = ((propertyBuffer != null) ? propertyBuffer.GetGetMethod() : null);
                
                propertyBuffer = null;
                propertyBuffer = typeof(Player).GetProperties().FirstOrDefault((PropertyInfo p) => p.GetGetMethod().Name == "get_isTalking");
                PlayerUtils.get_isTalking_Method = ((propertyBuffer != null) ? propertyBuffer.GetGetMethod() : null);
                
                propertyBuffer = null;
                propertyBuffer = typeof(Player).GetProperties().FirstOrDefault((PropertyInfo p) => p.GetGetMethod().Name == "get_isTrusted");
                PlayerUtils.get_isTrusted_Method = ((propertyBuffer != null) ? propertyBuffer.GetGetMethod() : null);
                
                propertyBuffer = null;
                propertyBuffer = typeof(Player).GetProperties().FirstOrDefault((PropertyInfo p) => p.GetGetMethod().Name == "get_isValidUser");
                PlayerUtils.get_isValidUser_Method = ((propertyBuffer != null) ? propertyBuffer.GetGetMethod() : null);
                
                propertyBuffer = null;
                propertyBuffer = typeof(Player).GetProperties().FirstOrDefault((PropertyInfo p) => p.GetGetMethod().Name == "get_isVIP");
                PlayerUtils.get_isVIP_Method = ((propertyBuffer != null) ? propertyBuffer.GetGetMethod() : null);

                propertyBuffer = null;
                propertyBuffer = typeof(Player).GetProperties().FirstOrDefault((PropertyInfo p) => p.GetGetMethod().Name == "get_playerApi");
                PlayerUtils.get_playerApi_Method = ((propertyBuffer != null) ? propertyBuffer.GetGetMethod() : null);

                propertyBuffer = null;
                propertyBuffer = typeof(Player).GetProperties().FirstOrDefault((PropertyInfo p) => p.GetGetMethod().Name == "get_playerNet");
                PlayerUtils.get_playerNet_Method = ((propertyBuffer != null) ? propertyBuffer.GetGetMethod() : null);

                propertyBuffer = null;
                propertyBuffer = typeof(Player).GetProperties().FirstOrDefault((PropertyInfo p) => p.GetGetMethod().Name == "get_status");
                PlayerUtils.get_status_Method = ((propertyBuffer != null) ? propertyBuffer.GetGetMethod() : null);

                propertyBuffer = null;
                propertyBuffer = typeof(Player).GetProperties().FirstOrDefault((PropertyInfo p) => p.GetGetMethod().Name == "get_statusDescription");
                PlayerUtils.get_statusDescription_Method = ((propertyBuffer != null) ? propertyBuffer.GetGetMethod() : null);

                propertyBuffer = null;
                propertyBuffer = typeof(Player).GetProperties().FirstOrDefault((PropertyInfo p) => p.GetGetMethod().Name == "get_user");
                PlayerUtils.get_user_Method = ((propertyBuffer != null) ? propertyBuffer.GetGetMethod() : null);

                propertyBuffer = null;
                propertyBuffer = typeof(Player).GetProperties().FirstOrDefault((PropertyInfo p) => p.GetGetMethod().Name == "get_userId");
                PlayerUtils.get_userId_Method = ((propertyBuffer != null) ? propertyBuffer.GetGetMethod() : null);

                propertyBuffer = null;
                propertyBuffer = typeof(Player).GetProperties().FirstOrDefault((PropertyInfo p) => p.GetGetMethod().Name == "set_status");
                PlayerUtils.set_status_Method = ((propertyBuffer != null) ? propertyBuffer.GetGetMethod() : null);

                propertyBuffer = null;
                propertyBuffer = typeof(Player).GetProperties().FirstOrDefault((PropertyInfo p) => p.GetGetMethod().Name == "set_statusDescription");
                PlayerUtils.set_statusDescription_Method = ((propertyBuffer != null) ? propertyBuffer.GetGetMethod() : null);

                propertyBuffer = null;
                propertyBuffer = typeof(PlayerManager).GetProperties().FirstOrDefault((PropertyInfo p) => p.GetGetMethod().Name == "get_Instance");
                PlayerUtils.get_InstancePlayerManager_Method = ((propertyBuffer != null) ? propertyBuffer.GetGetMethod() : null);
                
                propertyBuffer = null;
                propertyBuffer = typeof(PlayerManager).GetProperties().FirstOrDefault((PropertyInfo p) => p.GetGetMethod().Name == "get_MasterPlayer");
                PlayerUtils.get_MasterPlayer_Method = ((propertyBuffer != null) ? propertyBuffer.GetGetMethod() : null);

                propertyBuffer = null;
                propertyBuffer = typeof(PlayerManager).GetProperties().FirstOrDefault((PropertyInfo p) => p.GetGetMethod().Name == "get_PlayersCount");
                PlayerUtils.get_PlayersCount_Method = ((propertyBuffer != null) ? propertyBuffer.GetGetMethod() : null);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[VRCPlayer] Error loading player types, fields, and methods.");
                Console.WriteLine(ex);
                Console.ResetColor();
            }
        }

        public static VRC_PlayerApi get_apiPlayer(this VRCPlayer player)
        {
            return (VRC_PlayerApi)PlayerUtils.get_apiPlayer_Method.Invoke(player, null);
        }

        public static VRCAvatarManager get_AvatarManager(this VRCPlayer player)
        {
            return (VRCAvatarManager)PlayerUtils.get_AvatarManager_Method.Invoke(player, null);
        }

        public static Player get_player(this VRCPlayer player)
        {
            return (Player)PlayerUtils.get_player_Method.Invoke(player, null);
        }

        public static ulong get_SteamUserID(this VRCPlayer player)
        {
            return (ulong)PlayerUtils.get_SteamUserID_Method.Invoke(player, null);
        }

        public static short get_Ping(this VRCPlayer player)
        {
            return (short)PlayerUtils.get_Ping_Method.Invoke(player, null);
        }

        public static Player get_Instance()
        {
            return (Player)PlayerUtils.get_Ping_Method.Invoke(null, null);
        }

        public static VRCAvatarManager get_AvatarManager(this Player player)
        {
            return (VRCAvatarManager)PlayerUtils.get_AvatarManager_Method.Invoke(player.vrcPlayer, null);
        }

        public static object get_PhotonPlayer(this Player player)
        {
            return PlayerUtils.get_PhotonPlayer_Method.Invoke(player, null);
        }

        public static Hashtable get_HashtablePlayer(this Player player)
        {
            object photonPlayer = get_PhotonPlayer(player);
            return (Hashtable)PhotonViewUtils.get_Hashtable(photonPlayer);
        }

        public static bool get_isBlockedEitherWay(this Player player)
        {
            return (bool)PlayerUtils.get_isBlockedEitherWay_Method.Invoke(player, null);
        }

        public static bool get_isFavoriteFriend(this Player player)
        {
            return (bool)PlayerUtils.get_isFavoriteFriend_Method.Invoke(player, null);
        }

        public static bool get_isFriend(this Player player)
        {
            return (bool)PlayerUtils.get_isFriend_Method.Invoke(player, null);
        }

        public static bool get_isInstanceOwner(this Player player)
        {
            return (bool)PlayerUtils.get_isInstanceOwner_Method.Invoke(player, null);
        }

        public static bool get_isLoaded(this Player player)
        {
            return (bool)PlayerUtils.get_isLoaded_Method.Invoke(player, null);
        }

        public static bool get_IsLocal(this Player player)
        {
            return (bool)PlayerUtils.get_IsLocal_Method.Invoke(player, null);
        }

        public static bool get_IsMaster(this Player player)
        {
            return (bool)PlayerUtils.get_IsMaster_Method.Invoke(player, null);
        }
        
        public static bool get_isModerator(this Player player)
        {
            return (bool)PlayerUtils.get_isModerator_Method.Invoke(player, null);
        }

        public static bool get_isRoomAuthor(this Player player)
        {
            return (bool)PlayerUtils.get_isRoomAuthor_Method.Invoke(player, null);
        }

        public static bool get_isSuper(this Player player)
        {
            return (bool)PlayerUtils.get_isSuper_Method.Invoke(player, null);
        }

        public static bool get_isTalking(this Player player)
        {
            return (bool)PlayerUtils.get_isTalking_Method.Invoke(player, null);
        }

        public static bool get_isTrusted(this Player player)
        {
            return (bool)PlayerUtils.get_isTrusted_Method.Invoke(player, null);
        }

        public static bool get_isValidUser(this Player player)
        {
            return (bool)PlayerUtils.get_isValidUser_Method.Invoke(player, null);
        }

        public static bool get_isVIP(this Player player)
        {
            return (bool)PlayerUtils.get_isVIP_Method.Invoke(player, null);
        }

        public static VRC_PlayerApi get_playerApi(this Player player)
        {
            return (VRC_PlayerApi)PlayerUtils.get_playerApi_Method.Invoke(player, null);
        }

        public static PlayerNet get_playerNet(this Player player)
        {
            return (PlayerNet)PlayerUtils.get_playerNet_Method.Invoke(player, null);
        }

        public static string get_status(this Player player)
        {
            return (string)PlayerUtils.get_status_Method.Invoke(player, null);
        }

        public static string get_statusDescription(this Player player)
        {
            return (string)PlayerUtils.get_statusDescription_Method.Invoke(player, null);
        }

        public static ulong get_SteamUserID(this Player player)
        {
            return (ulong)PlayerUtils.get_SteamUserID_Method.Invoke(player.vrcPlayer, null);
        }

        public static APIUser get_user(this Player player)
        {
            return (APIUser)PlayerUtils.get_user_Method.Invoke(player, null);
        }
        
        public static string get_userId(this Player player)
        {
            return (string)PlayerUtils.get_userId_Method.Invoke(player, null);
        }
        
        public static void set_status(this Player player, string value)
        {
            PlayerUtils.set_status_Method.Invoke(player, new object[] { (string)value });
        }

        public static void set_statusDescription(this Player player, string value)
        {
            PlayerUtils.set_statusDescription_Method.Invoke(player, new object[] { (string)value });
        }

        public static PlayerManager get_InstancePlayerManager()
        {
            return (PlayerManager)PlayerUtils.get_InstancePlayerManager_Method.Invoke(null, null);
        }

        public static Player get_MasterPlayer(this PlayerManager playerManager)
        {
            return (Player)PlayerUtils.get_MasterPlayer_Method.Invoke(playerManager, null);
        }

        public static int get_PlayersCount(this PlayerManager playerManager)
        {
            return (int)PlayerUtils.get_PlayersCount_Method.Invoke(playerManager, null);
        }

        private static MethodInfo get_apiPlayer_Method;

        private static MethodInfo get_AvatarManager_Method;

        private static MethodInfo get_player_Method;

        private static MethodInfo get_SteamUserID_Method;

        private static MethodInfo get_Ping_Method;

        private static MethodInfo get_Instance_Method;

        private static MethodInfo get_PhotonPlayer_Method;

        private static MethodInfo get_isBlockedEitherWay_Method;

        private static MethodInfo get_isFavoriteFriend_Method;

        private static MethodInfo get_isFriend_Method;

        private static MethodInfo get_isInstanceOwner_Method;

        private static MethodInfo get_isLoaded_Method;

        private static MethodInfo get_IsLocal_Method;

        private static MethodInfo get_IsMaster_Method;

        private static MethodInfo get_isModerator_Method;

        private static MethodInfo get_isRoomAuthor_Method;

        private static MethodInfo get_isSuper_Method;

        private static MethodInfo get_isTalking_Method;

        private static MethodInfo get_isTrusted_Method;

        private static MethodInfo get_isValidUser_Method;

        private static MethodInfo get_isVIP_Method;

        private static MethodInfo get_playerApi_Method;

        private static MethodInfo get_playerNet_Method;

        private static MethodInfo get_status_Method;

        private static MethodInfo get_statusDescription_Method;

        private static MethodInfo get_user_Method;

        private static MethodInfo get_userId_Method;

        private static MethodInfo set_status_Method;

        private static MethodInfo set_statusDescription_Method;

        private static MethodInfo get_InstancePlayerManager_Method;

        private static MethodInfo get_MasterPlayer_Method;

        private static MethodInfo get_PlayersCount_Method;
    }
}
