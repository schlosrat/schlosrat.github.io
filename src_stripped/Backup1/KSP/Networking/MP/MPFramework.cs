// Decompiled with JetBrains decompiler
// Type: KSP.Networking.MP.MPFramework
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.ScriptInterop;
using System.Runtime.CompilerServices;

namespace KSP.Networking.MP
{
  public class MPFramework
  {
    private static MPFramework _instance;
    public const int TIME_TO_UPDATE_DEBUG_VARIABLES = 500;
    private UIHooks _uiHooks;
    private Status _status;
    private bool _inMultiplayerWing;
    private AccountManagement _accountManagement;

    public static MPFramework Instance
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static MPFramework CreateInstance() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void DestroyInstance() => throw null;

    public UIHooks UIHooks
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Status Status
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool InMultiplayerWing
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetInMultiplayerWing(bool inMultiplayerWing) => throw null;

    public AccountManagement AccountManagement
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MPFramework() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    ~MPFramework() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Uninit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateHashes() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Setup() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Start(IScriptEnvironment iscriptEnvironment) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void BindMultiplayerKeys() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UnbindMultiplayerKeys() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetupLocalPlayerInfo() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void TeardownLocalPlayerInfo() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public byte GetPlayerIdForPlayerGuidString(string playerGuidString) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetupLogAndPersistentDirectories() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnApplicationFocus(bool focus) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnApplicationPause(bool pause) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnApplicationQuit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ClientMode GetClientMode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateDebugVariables() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Pump() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnFixedUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnGUI() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static MPFramework() => throw null;
  }
}
