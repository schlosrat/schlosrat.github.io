// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Maneuver.ManeuverProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.Game;
using KSP.Map;
using KSP.Messages;
using KSP.Sim.DeltaV;
using KSP.Sim.impl;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim.Maneuver
{
  public class ManeuverProvider : IDisposable
  {
    private const string ACTIVE_MANEUVER_KEY = "ActiveManeuver";
    private const string BURN_PROGRESS_KEY = "BurnProgressBar";
    private const string INSUFFICIENT_BURN_PROGRESS_KEY = "InsufficientBurnProgressBar";
    private const string START_BURN_TIME_DISPLAY_KEY = "StartBurnTimeDisplay";
    private const string STOP_BURN_TIME_DISPLAY_KEY = "StopBurnTimeDisplay";
    private const string DELTA_V_DISPLAY_KEY = "DeltaVDisplay";
    private const string MANEUVER_NODE_NAME_KEY = "ManeuverNodeName";
    private const string WARP_BUTTON_KEY = "WarpButton";
    private const string REVIVE_BUTTON_KEY = "ReviveButton";
    private const string DELETE_BUTTON_KEY = "DeleteButton";
    private const string IS_BEFORE_MANEUVER_KEY = "IsBeforeManeuver";
    private const string REQUIRED_DELTA_V_MET_KEY = "IsRequiredDeltaVMet";
    private const string BURN_STARTED_ON_TIME_KEY = "HasPlayerStartedBurnOnTime";
    private const string BURN_STOPPED_ON_TIME_KEY = "HasPlayerStoppedBurnOnTime";
    private const string STAGING_INDICATORS = "StagingIndicators";
    public const string STAGE_ID_KEY = "StageID";
    public const string STAGE_POS_KEY = "StagePos";
    public const BurnTimerIconStatus DEFAULT_ICON_STATUS = BurnTimerIconStatus.Unknown;
    private Property<bool> _activeManeuverProperty;
    public Property<bool> IsBeforeManeuver;
    public Property<BurnTimerIconStatus> HasPlayerStartedBurnOnTime;
    public Property<BurnTimerIconStatus> HasPlayerStoppedBurnOnTime;
    private PropertyExternal<bool> _isReqiredDeltaVMet;
    private PropertyExternal<float> _burnProgressProperty;
    private PropertyExternal<float> _insufficientBurnProgressProperty;
    public PropertyExternal<int> StartBurnTimeProperty;
    public PropertyExternal<int> StopBurnTimeProperty;
    private PropertyExternal<int> _deltaVProperty;
    private Property<string> _maneuverNodeNameProperty;
    public static float NORMALIZED_MANEUVER_BOUND;
    public static float MINIMUM_ACCELERATION_REQUIRED;
    public int PlayerBurnInputWindow;
    private GameInstance _game;
    private ManeuverPlanComponent _activeVesselPlan;
    private StagingComponent _stagingComponent;
    private Vector3 _velocityDifference;
    private bool _hasPlayerStartedBurnTooEarly;
    private bool _hasPlayerStoppedBurnTooEarly;
    private List<DeltaVStageInfo> _usedStages;
    private List<StageIndicatorDataContext> _stagesToRemove;
    private int _previousBurnTimeETA;

    [DataList("StagingIndicators")]
    public ContextListProperty<StageIndicatorDataContext> StagingIndicators
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public float NormalizedManeuverTime
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public DataContext ActiveContext
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ManeuverProvider(GameInstance game) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateActiveVessel(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnManeuverDataUpdated() => throw null;

    /// <summary>
    /// Returns all maneuver nodes for this vessel.
    /// </summary>
    /// <param name="vesselID"></param>
    /// <returns List{ManeuverNodeData}></returns>
    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<ManeuverNodeData> GetNodesForVessel(IGGuid vesselID) => throw null;

    /// <summary>
    /// Main entry point for creating a new node on a vessel. This method calls ManeuverPlanComponent.AddNode. If successful, it will then call UpdateActiveNode.
    /// </summary>
    /// <param name="node"></param>
    /// <returns bool></returns>
    /// <exception cref="NullReferenceException"></exception>
    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool AddNodeToVessel(ManeuverNodeData node) => throw null;

    /// <summary>
    /// Removes the provided list of nodes from the specified vessel.
    /// </summary>
    /// <param name="vesselID"></param>
    /// <param name="nodeData"></param>
    /// <exception cref="NullReferenceException"></exception>
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveNodesFromVessel(IGGuid vesselID, List<ManeuverNodeData> nodeData) => throw null;

    /// <summary>
    /// Process an update to the burn vector (change parameter) for the provided node (nodeData parameter). This method checks EnoughDeltaVToChangeNode,
    /// limiting the amount of the change if more is requested than the vessel is capable of. If the vessel is out of fuel the node is not updated, otherwise
    /// the limited change is applied, ManeuverPlanComponent.UpdateChangeOnNode() is called, followed by this.UpdateActiveNode(), and this.UpdateAllChildNodeDetails().
    /// </summary>
    /// <param name="nodeData"></param>
    /// <param name="change"></param>
    /// <param name="lookupGizmoValues"></param>
    /// <exception cref="NullReferenceException"></exception>
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateChangeOnNode(
      ManeuverNodeData nodeData,
      Vector3 change,
      Dictionary<Guid, GizmoData>.ValueCollection lookupGizmoValues)
    {
      throw null;
    }

    /// <summary>
    /// Process an update to the node.Time parameter
    /// </summary>
    /// <param name="nodeData"></param>
    /// <param name="time"></param>
    /// <param name="lookupGizmoValues"></param>
    /// <exception cref="NullReferenceException"></exception>
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateTimeOnNode(
      ManeuverNodeData nodeData,
      double time,
      Dictionary<Guid, GizmoData>.ValueCollection lookupGizmoValues)
    {
      throw null;
    }

    /// <summary>
    /// Update all nodes that are subordinate to (later than and dependent upon) this node. This method calls this._game.SpaceSimulation.Maneuvers.UpdateNodeDetails.
    /// </summary>
    /// <param name="nodeData"></param>
    /// <param name="lookupGizmoValues"></param>
    /// <exception cref="NullReferenceException"></exception>
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateAllChildNodeDetails(
      ManeuverNodeData nodeData,
      Dictionary<Guid, GizmoData>.ValueCollection lookupGizmoValues)
    {
      throw null;
    }

    /// <summary>
    /// Calls ManeuverPlanComponent.UpdateNodeDetails() and then this.UpdateActiveNode()
    /// </summary>
    /// <param name="nodeData"></param>
    /// <exception cref="NullReferenceException"></exception>
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateNodeDetails(ManeuverNodeData nodeData) => throw null;

    /// <summary>
    /// Sets _activeManeuverProperty true and then validates the burn properties.
    /// </summary>
    /// <exception cref="NullReferenceException"></exception>
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateActiveNodeEta() => throw null;

    /// <summary>
    /// If there is an _activeVesselPlan and that object has an ActiveNode, then sets _activeManeuverProperty true, sets _maneuverNodeNameProperty to the NodeName,
    /// and then validates the burn properties, otherwsie sets _activeManeuverProperty false.
    /// </summary>
    /// <exception cref="NullReferenceException"></exception>
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateActiveNode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateStageMarkers() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float UpdateStagePos(
      StageIndicatorDataContext stageItem,
      DeltaVStageInfo stage,
      double remainingDvRequired,
      float currentStagePos)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateAudioManeuver() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void WarpToActiveNode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ReviveActiveNode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DeleteActiveNode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Dispose() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float GetBurnProgress() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int GetBurnTime() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float GetInsuficientBurnProgress() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double GetBurnETA() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int GetStartBurnTime() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int GetStopBurnTime() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int GetDeltaVRequired() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsReqiredDeltaVMet() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsActiveVesselAccelerating() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static ManeuverProvider() => throw null;
  }
}
