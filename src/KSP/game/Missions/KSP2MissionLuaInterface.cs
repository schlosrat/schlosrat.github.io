// Decompiled with JetBrains decompiler
// Type: KSP.Game.Missions.KSP2MissionLuaInterface
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
