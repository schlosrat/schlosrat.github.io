// Decompiled with JetBrains decompiler
// Type: KSP.Game.Missions.ConditionSet
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game.Missions.Definitions;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace KSP.Game.Missions
{
  public class ConditionSet : Condition
  {
    [JsonProperty]
    public List<Condition> Children;
    [JsonProperty]
    public LogicalOperator ConditionMode;

    [JsonProperty]
    public string ConditionType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void SetCondition(Condition cond) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool Initialize(MissionData missionParent, IMissionConditionOwner parent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool Activate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void DeleteCondition(Condition target) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool Deactivate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool Shutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnMissionReset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool Evaluate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool Evaluate_OR() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool Evaluate_AND() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool Evaluate_XOR() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool Evaluate_NOT() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Pack() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void DumpStatus(StringBuilder sb, int indent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Condition DeepCopy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string GetDebugEvaluationString(bool includeResults) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ConditionSet() => throw null;
  }
}
