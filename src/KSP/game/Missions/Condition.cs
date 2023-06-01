// Decompiled with JetBrains decompiler
// Type: KSP.Game.Missions.Condition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game.Missions.Definitions;
using Newtonsoft.Json;
using System.Runtime.CompilerServices;
using System.Text;

namespace KSP.Game.Missions
{
  public class Condition : IMissionConditionOwner
  {
    protected MissionData parentMission;
    [JsonIgnore]
    private IMissionConditionOwner owner;

    [JsonIgnore]
    public IMissionConditionOwner Owner
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool Evaluate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void ResetEvaluation() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool Initialize(MissionData parentMission, IMissionConditionOwner owner) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetParents(MissionData parentMission, IMissionConditionOwner owner) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void SetCondition(Condition cond) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void InformParentOfCompletion() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool Activate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool Deactivate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Pack() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnMissionReset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void DeleteCondition(Condition target) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Condition DeepCopy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool Shutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void DumpStatus(StringBuilder sb, int indent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string GetDebugEvaluationString(bool includeResults) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Condition() => throw null;
  }
}
