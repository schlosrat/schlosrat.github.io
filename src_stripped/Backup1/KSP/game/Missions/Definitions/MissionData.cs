// Decompiled with JetBrains decompiler
// Type: KSP.Game.Missions.Definitions.MissionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
    public MissionType type;
    [KSPDefinition]
    [JsonProperty]
    public MissionOwner Owner;
    [KSPDefinition]
    [JsonProperty]
    public MissionState state;
    [KSPDefinition]
    [JsonProperty]
    public string missionScript;
    public List<MissionStage> missionStages;
    [JsonProperty]
    [KSPDefinition]
    public int currentStageIndex;
    [KSPDefinition]
    [JsonProperty]
    public bool hidden;
    [KSPDefinition]
    [JsonProperty]
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
