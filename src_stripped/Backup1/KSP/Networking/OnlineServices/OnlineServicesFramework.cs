// Decompiled with JetBrains decompiler
// Type: KSP.Networking.OnlineServices.OnlineServicesFramework
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
