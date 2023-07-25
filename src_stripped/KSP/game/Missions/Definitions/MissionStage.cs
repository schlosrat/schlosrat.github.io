﻿// Decompiled with JetBrains decompiler
// Type: KSP.Game.Missions.Definitions.MissionStage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Game.Missions.Definitions
{
  [Serializable]
  public class MissionStage : IMissionConditionOwner
  {
    public const int INVALID_ID = -1;
    [JsonProperty]
    public int StageID;
    [JsonProperty]
    [KSPDefinition]
    public string name;
    [KSPDefinition]
    [JsonProperty]
    public string description;
    [JsonProperty]
    [KSPDefinition]
    public bool IgnoreExceptionBranches;
    [KSPDefinition]
    public List<IMissionAction> actions;
    [KSPDefinition]
    public List<MissionBranch> branches;
    [KSPDefinition]
    [JsonProperty]
    public string parentMissionID;
    [JsonIgnore]
    [KSPDefinition]
    public Condition condition;
    [JsonProperty]
    [KSPDefinition]
    public JObject scriptableCondition;
    [JsonProperty]
    [KSPState]
    public bool completed;
    [KSPState]
    [JsonProperty]
    public bool active;
    [JsonIgnore]
    [NonSerialized]
    private MissionData parent;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCondition(Condition cond) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Initialize(MissionData parent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Activate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DeleteCondition(Condition target) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Deactivate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Shutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnMissionReset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Evaluate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int EvaluateBranch() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Pack() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Unpack() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Condition UnpackRecursive(JObject source) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MissionStage DeepCopy(MissionData parentMission) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetDebugEvaluationString(bool includeName, bool includeResults) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MissionStage() => throw null;
  }
}
