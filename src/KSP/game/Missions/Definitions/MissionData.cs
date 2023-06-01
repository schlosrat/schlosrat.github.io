// Decompiled with JetBrains decompiler
// Type: KSP.Game.Missions.Definitions.MissionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game.Missions.State;
using KSP.Sim;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Game.Missions.Definitions
{
  [Serializable]
  public class MissionData
  {
    [JsonProperty]
    public string ID;
    [JsonProperty]
    [KSPDefinition]
    public string MissionGroup;
    [KSPDefinition]
    [JsonProperty]
    public string name;
    [JsonProperty]
    [KSPDefinition]
    public string description;
    [JsonProperty]
    [KSPDefinition]
    public MissionType type;
    [JsonProperty]
    [KSPDefinition]
    public MissionOwner Owner;
    [KSPDefinition]
    [JsonProperty]
    public MissionState state;
    [JsonProperty]
    [KSPDefinition]
    public string missionScript;
    public List<MissionStage> missionStages;
    [JsonProperty]
    [KSPDefinition]
    public int currentStageIndex;
    [JsonProperty]
    [KSPDefinition]
    public bool hidden;
    [KSPDefinition]
    [JsonProperty]
    public bool pendingCompletionTest;
    [KSPDefinition]
    [JsonProperty]
    public int maxStageID;
    [JsonProperty]
    [KSPDefinition]
    public UIDisplayType uiDisplayType;
    [JsonProperty]
    [KSPDefinition]
    public List<MissionBranch> ExceptionBranches;
    [JsonProperty]
    [KSPDefinition]
    public string MissionSaveAssetKey;

    [JsonIgnore]
    public GameInstance Game
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MissionData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MissionData(MissionData src) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Set(MissionData src) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MissionData GetDeepCopy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnInitialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnActivate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ReactivateCurrentStage() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnDeactivate(bool applyPriorState = true, Action onCompleteCallback = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnConditionMet() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void TestStageCompletion() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FireOnStageCompletedMessage() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnStageComplete() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnMissionComplete() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnMissionReset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnMissionFailed() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ActivateStage(int stage) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DeactivateStage(int stage) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Pack() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GenerateMissionStatus() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GenerateStageStatus(bool dumpStatus = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetStageCount() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GenerateStageID() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool CurrentStageUpdatesExceptionBranches() => throw null;
  }
}
