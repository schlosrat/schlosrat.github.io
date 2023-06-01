// Decompiled with JetBrains decompiler
// Type: KSP.Networking.MP.MPFramework
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using KSP.ScriptInterop;
using System.Runtime.CompilerServices;

namespace KSP.Networking.MP
{
  public class MPFramework
  {
    private static MPFramework gMPFramework;
    private GameInstance _gameInstance;
    public DebugVars _debugVars;
    private UIHooks _uiHooks;
    private Status _status;
    private bool _inMultiplayerWing;
    private AccountManagement _accountManagement;

    public static GameInstance Game
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static MPFramework Instance
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GameInstance GameInstance
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetGameInstance(GameInstance gameInstance) => throw null;

    public DebugVars DebugVars
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

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
    public MPFramework(GameInstance gameInstance, IScriptEnvironment iscriptEnvironment = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init(GameInstance gameInstance, IScriptEnvironment iscriptEnvironment = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Uninit() => throw null;

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
