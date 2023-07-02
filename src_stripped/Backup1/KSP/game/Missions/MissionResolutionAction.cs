// Decompiled with JetBrains decompiler
// Type: KSP.Game.Missions.MissionResolutionAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game.Missions.State;
using KSP.Messages;
using Newtonsoft.Json;
using System;
using System.Runtime.CompilerServices;

namespace KSP.Game.Missions
{
  [Serializable]
  public class MissionResolutionAction : MissionActionBase, IMissionAction
  {
    [JsonProperty]
    public MissionState MissionResolution;
    [JsonIgnore]
    public string ParentMissionID;
    [JsonProperty]
    public string summary_PrefabKey;
    [JsonProperty]
    public bool waitForSummaryDismissed;
    private SubscriptionHandle _handleOnMissionSummaryDismissed;

    [JsonIgnore]
    private GameInstance Game
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetParentMissionID(string missionID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Activate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Deactivate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnMissionReset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetEditorName() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetEditorDescription() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnMissionSummaryDismissed(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MissionResolutionAction() => throw null;
  }
}
