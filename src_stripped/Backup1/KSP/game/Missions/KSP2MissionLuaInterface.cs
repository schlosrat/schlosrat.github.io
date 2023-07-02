// Decompiled with JetBrains decompiler
// Type: KSP.Game.Missions.KSP2MissionLuaInterface
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game.Missions.State;
using KSP.ScriptInterop;
using System.Runtime.CompilerServices;

namespace KSP.Game.Missions
{
  public class KSP2MissionLuaInterface
  {
    public GameInstance Game
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public KSP2MissionManager MissionMgr
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RegisterEnvironment(IScriptEnvironment scriptEnvironment) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ActivateMission(string missionID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetMisionState(string missionID, MissionState state) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KSP2MissionLuaInterface() => throw null;
  }
}
