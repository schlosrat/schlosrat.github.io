// Decompiled with JetBrains decompiler
// Type: KSP.Map.Map3DOrbitalMarker
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using DG.Tweening;
using KSP.Api.CoreTypes;
using KSP.Game;
using KSP.Messages;
using KSP.Sim;
using KSP.Sim.impl;
using KSP.UI.Binding;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UI.Extensions;

namespace KSP.Map
{
  public class Map3DOrbitalMarker : KerbalMonoBehaviour, IComparable<Map3DOrbitalMarker>
  {
    private Camera _viewCamera;
    private Canvas _parentCanvas;
    private CanvasScaler _parentCanvasScaler;
    [Header("Display Properties")]
    [SerializeField]
    private RectTransform _contentContainer;
    [SerializeField]
    private RectTransform _panelContainer;
    [SerializeField]
    private ContextBindRoot _bindRoot;
    [SerializeField]
    private UIValue_ReadNumber_TextUnits _distancePropDataFormatter;
    [SerializeField]
    private Graphic _collapsedObject;
    [SerializeField]
    private Graphic _expandedObject;
    [SerializeField]
    private bool _lockToCollapsed;
    [Tooltip("The interval used to iterate around the overlap center to find an unoccupied position")]
    [SerializeField]
    [Header("Overlap Handling Controls")]
    private int _overlapResolveAngleInterval;
    [Tooltip("The distance interval to increase by when rotating around the overlap center to find an unoccupied position")]
    [SerializeField]
    private float _overlapResolveDistanceInterval;
    [Tooltip("Max amount of iterations to perform when resolving overlap positions")]
    [SerializeField]
    private int _positionResolveIterations;
    [Tooltip("Max amount of markers to display within a given set of overlaps")]
    [SerializeField]
    private int _maxOverlapDisplay;
    [Tooltip("Markers with higher priorities are favored for display when the amount of overlapped markers exceeds _maxOverlapDisplay")]
    [SerializeField]
    private int _overlapDisplayPriority;
    [Header("Vector Stem Controls")]
    [SerializeField]
    private UILineRenderer _stemVector;
    [Header("Orientation Controls")]
    [SerializeField]
    private Map3DOrbitalMarker.OrientationData[] _collapsedOrientationPositions;
    [SerializeField]
    private Map3DOrbitalMarker.OrientationData[] _expandedOrientationPositions;
    [Header("Animations")]
    [SerializeField]
    private DOTweenAnimation _hoverInAnimation;
    [SerializeField]
    private DOTweenAnimation _hoverOutAnimation;
    [SerializeField]
    private DOTweenAnimation _pinnedAnimation;
    [SerializeField]
    private DOTweenAnimation _unpinnedAnimation;
    private ITransformModel _viewerReferenceBody;
    public double PreviousOrbitEccentricity;
    public double PreviousOrbitSemiMajorAxis;
    public double PreviousUniversalTime;
    private DataContext _dataContext;
    private PropertyExternal<string> _vesselNameProp;
    private PropertyExternal<Quaternion> _orientationProp;
    private PropertyExternal<string> _eventTypeProp;
    private PropertyExternal<double> _relativeVelProp;
    private PropertyExternal<Quaternion> _relativeVelIndicatorProp;
    private PropertyExternal<double> _distanceProp;
    private PropertyExternal<double> _etaProp;
    private PropertyExternal<double> _inclinationProp;
    private Property<bool> _isExpandedProp;
    private Property<bool> _isHiddenInGroup;
    private bool _isPinned;
    private const string VESSEL_NAME_PROPERTY_KEY = "VesselName";
    private const string VESSEL_ORIENTATION_PROPERTY_KEY = "VesselOrientation";
    private const string EVENT_TYPE_PROPERTY_KEY = "EventType";
    private const string RELATIVE_VEL_PROPERTY_KEY = "RelativeVelocity";
    private const string RELATIVE_VEL_INDICATOR_PROPERTY_KEY = "RelativeVelocityIndicator";
    private const string DISTANCE_PROPERTY_KEY = "DistanceToTarget";
    private const string ETA_PROPERTY_KEY = "ETA";
    private const string INCLINATION_PROPERTY_KEY = "Inclination";
    private const string EXPANDED_PROPERTY_KEY = "IsExpanded";
    private const string HIDDEN_PROPERTY_KEY = "IsHiddenInGroup";
    private const int DISTANCE_PROP_UNIT_ENTRY_INDEX_KM = 1;
    private int _orientationIndex;
    private RectTransform _transform;
    private bool hasInitTransform;
    private Vector3 _mapPos;
    private Map3DOrbitalMarker.PositioningType _positioningType;
    private bool _isVisible;
    private bool _isWithinCameraFustrum;
    private Vector2 _currentPositionOffset;
    private bool _isOverlapping;
    private bool _isHovered;
    private Rect _originalRect;
    private Rect _adjPosRect;
    private List<Map3DOrbitalMarker> _overlappedMarkers;
    private bool _maneuverGizmoActive;
    private static List<Map3DOrbitalMarker> _currentMarkers;
    private static bool _isAnyHovered;

    public OrbitMarker OrbitMarker
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Map3DTrajectoryEvents.EventType EventType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public CelestialBodyComponent CurrentPatchReferenceBody
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public OrbiterComponent Orbiter
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public IGGuid AssociatedObjectID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public TransformModel TransformModel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    private RectTransform transform
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public RectTransform ActiveRectTransform
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 MapPosition
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsProxy
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Rect OriginalRect
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Rect AdjustedPositionRect
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsDisplayed
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int OverlapDisplayPriority
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize(
      Camera viewCamera,
      Canvas parentCanvas,
      Map3DTrajectoryEvents.EventType eventType,
      OrbitMarker marker,
      OrbiterComponent orbiter,
      bool isProxy = false)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeContext() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPanelExpand(bool expanded) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RecalculateOverlap() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetOrientation() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool TryResolveOverlap(out Vector2 resolvedOffset) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector2 GetOverlapGroupCenter() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private List<Map3DOrbitalMarker> GetOverlapGroup(
      Map3DOrbitalMarker checkMarker,
      List<Map3DOrbitalMarker> visited = null)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsRectOverlapping(Rect targetRect, bool useAdjustedRect = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateOverlapGroups() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateRect() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Rect GetRectAtPosition(Vector3 targetPosition) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdatePanelPosition() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string GetVesselName() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Quaternion GetVesselOrientation() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string GetEventTypeString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double GetRelativeVelocity() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector3d GetRelativeVelocityAtUT(IPatchedOrbit patch, double UT) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Quaternion GetRelativeVelocityOrientation() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double GetDistance() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double GetETA() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double GetInclination() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Restore() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ToggleMarkerVisibility() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ValidateProperties() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateDisplayState() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Expand() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Collapse() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateStemVector() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void UpdatePosition(Map3DSpaceProvider spaceProvider, bool usePreviousUT = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateTransformModel() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ToggleMarkerVisiblity(bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnManeuverGizmoStateChange(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int CompareTo(Map3DOrbitalMarker other) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Map3DOrbitalMarker() => throw null;

    public enum PositioningType
    {
      RelativeToOrbiter,
      RelativeToPatch,
    }

    [Serializable]
    public struct OrientationData
    {
      public Vector2 Position;
      public Vector2 Pivot;
      public float ConnectorLength;
    }
  }
}
