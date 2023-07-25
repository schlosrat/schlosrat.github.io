// Decompiled with JetBrains decompiler
// Type: KSP.Game.Missions.MissionUIElement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.Game.Missions.Definitions;
using KSP.Game.Missions.State;
using System.Runtime.CompilerServices;

namespace KSP.Game.Missions
{
  public class MissionUIElement : ApiDataContext
  {
    [DataProperty("mission.ID")]
    public Property<string> id;
    [DataProperty("mission.name")]
    public Property<string> name;
    [DataProperty("mission.description")]
    public Property<string> description;
    [DataProperty("mission.type")]
    private Property<MissionType> missionType;
    [DataProperty("mission.state")]
    private Property<MissionState> missionState;
    [DataProperty("mission.stageInfo")]
    private Property<string> missionStageInfo;
    [DataProperty("mission.isActive")]
    public Property<bool> active;
    [DataProperty("mission.currentStage")]
    public Property<int> currentStage;
    [DataProperty("mission.stages")]
    public Property<int> stages;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MissionUIElement(MissionData missionData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateMission(MissionData missionData) => throw null;
  }
}
