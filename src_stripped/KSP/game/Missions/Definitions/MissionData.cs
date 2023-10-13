// Decompiled with JetBrains decompiler
// Type: KSP.Game.Missions.Definitions.MissionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
    [KSPDefinition]
    [JsonProperty]
    public string description;
    [KSPDefinition]
    [JsonProperty]
    public string GameModeFeatureId;
    [KSPDefinition]
    [JsonProperty]
    public MissionType type;
    [JsonProperty]
    [KSPDefinition]
    public MissionOwner Owner;
    public const int DEFAULT_OWNER_ID = 1;
    protected int OwnerId;
    [JsonProperty]
    [KSPDefinition]
    public MissionState state;
    [JsonProperty]
    [KSPDefinition]
    public string missionScript;
    public List<MissionStage> missionStages;
    [JsonProperty]
    [KSPDefinition]
    public int currentStageIndex;
    [KSPDefinition]
    [JsonProperty]
    public bool Hidden;
    [JsonProperty]
    [KSPDefinition]
    public bool VisibleRewards;
    [JsonProperty]
    [KSPDefinition]
    public bool pendingCompletionTest;
    [JsonProperty]
    [KSPDefinition]
    public int maxStageID;
    [JsonProperty]
    [KSPDefinition]
    public UIDisplayType uiDisplayType;
    [JsonProperty]
    [KSPDefinition]
    public List<MissionBranch> ExceptionBranches;
    [KSPDefinition]
    [JsonProperty]
    public List<MissionBranch> PreRequisiteBranches;
    [KSPDefinition]
    [JsonProperty]
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

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool CanTestPreRequisiteBranches() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetOwnerId(int newOwnerId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetOwnerId() => throw null;
  }
}
