// Decompiled with JetBrains decompiler
// Type: KSP.Networking.MP.MPVars
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Networking.MP.Serialize;
using System;
using System.Runtime.CompilerServices;

namespace KSP.Networking.MP
{
  [Serializable]
  public class MPVars : IMPSyncable
  {
    private static MPVars _instance;
    public const string BASEKEYORFILENAME = "MPDebug";
    public const string EXTENSION = ".json";
    public const string FULLPATH_PREFIX = "PersistentDataFiles\\";
    public static string DEFAULT_LOGGED_OUT_PLAYER_NAME_STRING;
    public static string DEFAULT_LOGGED_OUT_PLAYER_GUID_STRING;
    public static string DEFAULT_LOGIN_OVERLAY_ACCOUNT_NAME_STRING;
    public static string DEFAULT_BYPASS_PLAYER_NAME_STRING;
    public static string DEFAULT_BYPASS_PLAYER_GUID_STRING;
    public const bool DEFAULT_DEBUG_MPSYNC_IGGUID_WITH_DEBUG_NAME = false;
    public string LoggedOutPlayerNameString;
    public string LoggedOutPlayerGuidString;
    public string LoginOverlayAccountNameString;
    public string BypassPlayerNameString;
    public string BypassPlayerGuidString;
    public bool DebugMPSyncIGGuidWithDebugName;

    public static MPVars Instance
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void PopulateDynamicDefaultValues() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool SaveStringToPasswordString(string saveString, out string passwordString) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool PasswordStringToSaveString(string passwordString, out string saveString) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Uninit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool ResetAllValues() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MPSync(IMPSerializer mpSerializer) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SanityChecks() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SaveLocation GetSaveLocation() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Load() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool PopulatePlayerIdentityFieldsIfNeeded() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Save() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MPVars() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static MPVars() => throw null;
  }
}
