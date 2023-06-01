// Decompiled with JetBrains decompiler
// Type: KSP.Networking.OnlineServices.OnlineServicesFramework
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using KSP.Networking.OnlineServices.Authentication;
using KSP.Networking.OnlineServices.Backtrace;
using KSP.Networking.OnlineServices.Telemetry;
using KSP.ScriptInterop;
using System.Collections;
using System.Runtime.CompilerServices;

namespace KSP.Networking.OnlineServices
{
  public class OnlineServicesFramework
  {
    private static OnlineServicesFramework osFramework;
    private GameInstance _gameInstance;
    private AuthenticationManager _authenticationManager;
    private BacktraceManager _backtraceManager;
    private Manager _telemetryManager;

    public static OnlineServicesFramework Instance
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GameInstance GameInstance
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetGameInstance(GameInstance gameInstance) => throw null;

    public AuthenticationManager AuthenticationManager
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public BacktraceManager BacktraceManager
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Manager TelemetryManager
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OnlineServicesFramework(GameInstance gameInstance, IScriptEnvironment iscriptEnvironment = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init(GameInstance gameInstance, IScriptEnvironment iscriptEnvironment = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Uninit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerator InitializeServices() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static OnlineServicesFramework() => throw null;
  }
}
