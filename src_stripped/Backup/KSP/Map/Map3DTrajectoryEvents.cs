// Decompiled with JetBrains decompiler
// Type: KSP.Map.Map3DTrajectoryEvents
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using KSP.Messages;
using KSP.Sim;
using KSP.Sim.impl;
using KSP.Utilities;
using Shapes;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Map
{
  public class Map3DTrajectoryEvents : KerbalMonoBehaviour
  {
    public const string MAP_TRAJECTORIES_LOCALIZATION_KEY = "Map/Trajectory/";
    [SerializeField]
    private Canvas _eventCanvas;
    [SerializeField]
    private Map3DOrbitalMarker[] _eventPrefabs;
    [Header("Marker Display Options")]
    [SerializeField]
    private bool _displayClosestApproach;
    [SerializeField]
    private bool _displayCapture;
    [SerializeField]
    private bool _displayExitingSOI;
    [SerializeField]
    private bool _displayEnteringSOI;
    [SerializeField]
    private bool _displayEndThrust;
    [SerializeField]
    private bool _displayPartialOutOfFuel;
    [SerializeField]
    private bool _displayCompletelyOutOfFuel;
    [SerializeField]
    private bool _displayCollision;
    [SerializeField]
    private bool _displayPeriapsis;
    [SerializeField]
    private bool _displayApoapsis;
    [SerializeField]
    private bool _displayIntersect;
    [SerializeField]
    private bool _displayAscendingDescending;
    private Map3DSpaceProvider _spaceProvider;
    private MapCamera _mapCamera;
    private Dictionary<Map3DTrajectoryEvents.EventType, GameObjectPool<Map3DOrbitalMarker>> _eventPools;
    private DictionaryValueList<IGGuid, DictionaryValueList<OrbitMarker, Map3DOrbitalMarker>> _currentEvents;
    private Queue<Map3DOrbitalMarker> _releaseQueue;
    private Map3DOrbitalMarker highlightEvent;
    private Transform _parentContainer;
    private VesselComponent _lastSelection;
    private IGGuid _lastSelectionID;
    private VesselComponent _lastActiveVessel;
    private IGGuid _lastActiveVesselID;
    private OrbiterComponent _lastActiveVesselTarget;
    private IGGuid _lastActiveVesselTargetID;
    private const double ECCENTRICITY_UPDATE_THRESHOLD = 1E-06;
    private const double LAST_ORBIT_PATCH_ECCENTRICITY_EPSILON = 0.001;
    private const double LAST_ORBIT_PATCH_SEMI_MAJOR_AXIS_EPSILON = 0.001;
    [SerializeField]
    protected double debugHighlightOffset;
    [SerializeField]
    protected Map3DTrajectoryEvents.EventType debugEventType;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetEventTypeNameFormatted(Map3DTrajectoryEvents.EventType type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializePools() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnRequestSelectionChange(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnActiveVesselChange(MessageCenterMessage message) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVesselTargetChange(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnMapInitialized(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnSOIEntered(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnSOIExited(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateEventsTransformModel() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void QueueForRelease(Map3DOrbitalMarker tEvent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ResetInstance(Map3DOrbitalMarker tEvent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ReleaseInstance(Map3DOrbitalMarker tEvent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ReleaseInstancesForID(IGGuid id) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ReleaseAllInstances() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Shutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateViewForOrbiter(OrbiterComponent orbiter) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateViewForCurrentTrajectory(
      OrbiterComponent orbiter,
      IGGuid simulationObjectGlobalId)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateViewForManeuverTrajectory(
      OrbiterComponent orbiter,
      IGGuid simulationObjectGlobalId)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateViewForCurrentTrajectoryPatch(
      IPatchedOrbit orbitPatch,
      OrbiterComponent orbiter,
      IGGuid parentID)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateViewForManeuverTrajectoryPatch(
      IPatchedOrbit orbitPatch,
      OrbiterComponent orbiter,
      IGGuid parentID)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateViewForTargeter(
      OrbitTargeter targeter,
      OrbiterComponent orbiter,
      IGGuid parentID)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool TryFetchNewEventInstance(
      Map3DTrajectoryEvents.EventType type,
      OrbitMarker orbitMarker,
      OrbiterComponent orbiter,
      IGGuid parentID,
      out Map3DOrbitalMarker marker,
      bool proxyMarker = false)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateViewState() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateEvent(Map3DOrbitalMarker tEvent, bool forcePositionUpdate = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void TryUpdateAssociatedMarker(AnDnMarker marker, IGGuid orbiterID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void TryUpdateAssociatedMarker(IntersectMarker marker, IGGuid orbiterID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsValidUT(double UT) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DrawAnDnLines(Camera cam) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector3d GetAnDnVector3d(AnDnMarker marker) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsValidForRendering(OrbitMarker marker) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DrawEventPolylines(List<PolylinePath> paths) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateOrbitMarkerView(
      Map3DTrajectoryEvents.EventType eventType,
      OrbitMarker orbitMarker,
      OrbiterComponent orbiter,
      IGGuid parentID,
      bool setProxy = false)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool CanDisplayMarker(Map3DTrajectoryEvents.EventType eventType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnOrbitHighlightRequested(MessageCenterMessage msg) => throw null;

    [ContextMenu("DebugShowHighlightTrajectory")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void DebugShowHighlightTrajectory() => throw null;

    [ContextMenu("DebugHideHighlight")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void DebugHideHighlight() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddHighlightNode(
      IGGuid simID,
      Map3DTrajectoryEvents.EventType eventType,
      double UToffset)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ReleaseActiveHighlight(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Map3DTrajectoryEvents() => throw null;

    public enum EventType
    {
      ClosestApproach,
      Capture,
      Acceleration,
      ExitingSOI,
      EnteringSOI,
      EndThrust,
      PartialOutOfFuel,
      CompletelyOutOfFuel,
      Collision,
      Periapsis,
      Apoapsis,
      Intersect1A,
      Intersect1B,
      Intersect2A,
      Intersect2B,
      AscendingNode,
      DescendingNode,
      HighlightNode,
    }
  }
}
