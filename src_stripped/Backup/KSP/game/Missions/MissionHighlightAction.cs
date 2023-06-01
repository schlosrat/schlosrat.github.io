// Decompiled with JetBrains decompiler
// Type: KSP.Game.Missions.MissionHighlightAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Map;
using KSP.UI;
using Newtonsoft.Json;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Game.Missions
{
  [Serializable]
  public class MissionHighlightAction : MissionActionBase, IMissionAction
  {
    [JsonIgnore]
    public Highlight_Data highlightData;
    [JsonProperty]
    public HighlightType highlightType;
    [JsonProperty]
    public bool trackInNavball;
    [JsonProperty]
    public string attachNodeID;
    [JsonProperty]
    public string attachNodehighlight;
    [JsonProperty]
    public string trackingGUID;
    [JsonProperty]
    public string partName;
    [JsonProperty]
    public bool lastPartPlaced;
    [JsonProperty]
    public string celestialBodyName;
    [JsonProperty]
    public string prefabKey;
    [JsonProperty]
    public Vector3 offset;
    [JsonProperty]
    public Vector3 orientation;
    [JsonProperty]
    public bool cb_Coordinates;
    [JsonProperty]
    public Vector3 cb_Coords;
    [JsonProperty]
    public ManeuverGizmoInputType maneuverGizmoHandle;
    [JsonProperty]
    public Map3DTrajectoryEvents.EventType orbitNodeTrajectoryEvent;
    [JsonProperty]
    public double timeFromOrbitTrajectory;
    [JsonIgnore]
    private Highlight spawnedHighlight;
    [JsonIgnore]
    public string ParentMissionID;

    [JsonIgnore]
    private GameInstance Game
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Activate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Deactivate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnMissionReset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetParentMissionID(string missionID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetEditorName() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetEditorDescription() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MissionHighlightAction() => throw null;
  }
}
