// Decompiled with JetBrains decompiler
// Type: KSP.Game.Missions.EventCondition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game.Missions.Definitions;
using KSP.Messages;
using Newtonsoft.Json;
using System;
using System.Runtime.CompilerServices;
using System.Text;

namespace KSP.Game.Missions
{
  public class EventCondition : Condition
  {
    [JsonProperty]
    private bool eventObserved;
    [JsonIgnore]
    public Type eventType;
    [JsonProperty]
    public string EventTypeAQN;
    private SubscriptionHandle messageHandle;
    private bool subscribed;

    [JsonProperty]
    public string ConditionType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [JsonIgnore]
    public string EventTypeAQNAbbrev
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [JsonIgnore]
    public GameInstance Game
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool Evaluate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void ResetEvaluation() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool Initialize(MissionData parentMission, IMissionConditionOwner owner) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool Activate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool Deactivate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool Shutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnMissionReset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void MessageHandler(MessageCenterMessage message) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void DumpStatus(StringBuilder sb, int indent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Condition DeepCopy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string GetDebugEvaluationString(bool includeResults) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public EventCondition() => throw null;
  }
}
