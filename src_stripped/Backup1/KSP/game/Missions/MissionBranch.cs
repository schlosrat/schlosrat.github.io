// Decompiled with JetBrains decompiler
// Type: KSP.Game.Missions.MissionBranch
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game.Missions.Definitions;
using Newtonsoft.Json;
using System;
using System.Runtime.CompilerServices;

namespace KSP.Game.Missions
{
  [Serializable]
  public class MissionBranch : IMissionConditionOwner
  {
    public Condition condition;
    public int TargetStage;
    [JsonIgnore]
    [NonSerialized]
    public MissionData ParentMission;
    public bool ExceptionBranch;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCondition(Condition cond) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize(MissionData parentMission) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Activate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Deactivate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Evaluate(out int targetStageID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Shutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnMissionReset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DeleteCondition(Condition target) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetEditorName() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetEditorDescription() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MissionBranch DeepCopy(MissionData parentMission) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MissionBranch() => throw null;
  }
}
