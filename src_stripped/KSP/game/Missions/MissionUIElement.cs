// Decompiled with JetBrains decompiler
// Type: KSP.Game.Missions.MissionUIElement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Api.CoreTypes;
using KSP.Game.Missions.Definitions;
using KSP.Game.Missions.State;
using System.Runtime.CompilerServices;

namespace KSP.Game.Missions
{
  public class MissionUIElement : ApiDataContext
  {
    [DataProperty("Id")]
    private Property<string> id;
    [DataProperty("title")]
    private Property<string> title;
    [DataProperty("description")]
    public Property<string> description;
    [DataProperty("type")]
    private Property<MissionType> missionType;
    [DataProperty("state")]
    private Property<MissionState> missionState;
    [DataProperty("mission.stageInfo")]
    private Property<string> missionStageInfo;
    [DataProperty("isActive")]
    private Property<bool> active;
    [DataProperty("currentStage")]
    private Property<int> currentStage;
    [DataProperty("stageCount")]
    private Property<int> stageCount;
    [DataProperty("hidden")]
    private Property<bool> hidden;
    [DataProperty("vissibleRewards")]
    private Property<bool> visibleRewards;
    private MissionData _missionData;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MissionData GetMissionData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MissionUIElement(MissionData missionData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeProperties(MissionData missionData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateValues(MissionData missionData) => throw null;
  }
}
