// Decompiled with JetBrains decompiler
// Type: KSP.UI.Missionlogic
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.Game.Missions;
using System.Runtime.CompilerServices;
using UnityEngine.Events;

namespace KSP.UI
{
  public class Missionlogic : ApiDataContext
  {
    public UnityAction UpdateUI;
    [DataList("missions")]
    public ContextListProperty<MissionUIElement> MissionsList;
    [DataList("completedMissions")]
    public ContextListProperty<MissionUIElement> CompletedMissionsList;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Missionlogic() => throw null;

    [DataAction("TrackMission")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void TrackMission() => throw null;

    [DataAction("CompleteMission")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CompleteMission(int index) => throw null;
  }
}
