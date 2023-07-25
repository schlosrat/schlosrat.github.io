// Decompiled with JetBrains decompiler
// Type: KSP.TriggersTools.TriggersTools
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Messages;
using KSP.Sim;
using KSP.Sim.impl;
using KSP.Sim.Maneuver;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.TriggersTools
{
  public class TriggersTools : KerbalMonoBehaviour
  {
    private const string TRIGGERSTOOLS_ADDRESSABLE = "TriggersToolsWindow.prefab";
    private static GameObject _instance;
    [SerializeField]
    [Header("Display Prefabs")]
    private DebugShapesArrowComponent debugArrowPrefab;
    [SerializeField]
    private DebugShapesAxesComponent debugAxesPrefab;
    [SerializeField]
    private DebugShapesCenterOfMarker CenterOfPrefab;
    [SerializeField]
    [Header("Control Labels")]
    private Toggle controlPointsToggle;
    [SerializeField]
    private Toggle cpNavballSetting;
    [SerializeField]
    private Toggle comToggle;
    [SerializeField]
    private Toggle velToggle;
    [SerializeField]
    private Toggle sasToggle;
    [SerializeField]
    private Toggle showJointsToggle;
    [SerializeField]
    private Toggle physicsForceToggle;
    [SerializeField]
    private Toggle partTempsToggle;
    [SerializeField]
    private Toggle tensorScalingEnabledToggle;
    [SerializeField]
    private Toggle multiJointsToggle;
    [SerializeField]
    private Toggle jointsEnabledToggle;
    [SerializeField]
    private Toggle dynamicSolverIterationToggle;
    [SerializeField]
    private Toggle dynamicTensorSolutionToggle;
    [Header("Input Labels")]
    [SerializeField]
    private TextMeshProUGUI toggleInputsText;
    [SerializeField]
    private TextMeshProUGUI pitchValue;
    [SerializeField]
    private TextMeshProUGUI yawValue;
    [SerializeField]
    private TextMeshProUGUI rollValue;
    [SerializeField]
    private bool showInputValues;
    [SerializeField]
    [Header("Control State Labels")]
    private TextMeshProUGUI controlStateValue;
    [Header("Stats Labels")]
    [SerializeField]
    private TextMeshProUGUI togglePartsText;
    [SerializeField]
    private Transform partStatsParent;
    [SerializeField]
    private TriggersToolsPartDetailsRow partRowPrefab;
    [SerializeField]
    private Transform maneuverStatsParent;
    [SerializeField]
    private TriggersToolsManeuverNodeRow _maneuverRowPrefab;
    [SerializeField]
    [Header("Panels for scenes")]
    private GameObject goNone;
    [SerializeField]
    private GameObject goFlight;
    private GameInstance _game;
    private GameState _state;
    private ViewController _view;
    private UniverseView _universe;
    private bool _ignoreValueChanged;
    private List<VesselComponent> _vessels;
    private Quaternion _navballRotation;
    [Header("Working Variables")]
    [SerializeField]
    private bool _isControlPointsShowing;
    [SerializeField]
    private bool _isControlPointsRotated;
    [SerializeField]
    private bool _isCoMMarkersShowing;
    [SerializeField]
    private bool _isSASTargetShowing;
    [SerializeField]
    private bool _isOrbitPointsShowing;
    [SerializeField]
    private bool _isPhysicsForceShowing;
    [SerializeField]
    private bool _isManeuverNodesShowing;
    private List<TriggersToolsManeuverNodeRow> _maneuverRows;
    private List<DebugShapesAxesComponent> _vesselControlAxes;
    private List<DebugShapesCenterOfMarker> _CoMMarkers;
    private List<DebugShapesArrowComponent> _vesselSASArrows;
    private List<DebugShapesAxesComponent> _vesselOrbitAxes;
    private Color _sasActiveColor;
    private Color _sasInactiveColor;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ToggleToolsWindow() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void CreateWindow() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void DestroyWindow() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CloseWindow() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnStateChange(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetActiveMode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnCPToggle(bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnCPNavRotationToggle(bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateControlOrientations() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DestroyControlOrientations() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnCoMToggle(bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnShowJointsToggle(bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnDynamicIterationSolverCountToggle(bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnTensorScalingToggle(bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnDynamicTensorSolutionToggle(bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnMultiJointsToggle(bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnJointsEnabledToggle(bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator CoroutineRebuildVessel(VesselBehavior vesselBehavior) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateCoMMarkers() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DestroyCoMMarkers() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateVesselCoM(ITransformModel t, SimulationObjectModel o) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnOrbitPointsToggle(bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateOrbitOrientations() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Tracker_OnUpdate(ITransformModel t, SimulationObjectModel o) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DestroyOrbitOrientations() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnSASTargetToggle(bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateSASTargets() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DestroySASTargets() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateSASVectors(ITransformModel t, SimulationObjectModel o) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ToggleInputValues() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateInputValues() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateControlStateValues() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GetPartMassStats() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GetManeuverNodes(bool show) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void FormatManeuverNodeData(
      TriggersToolsManeuverNodeRow row,
      ManeuverNodeData node)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateManeuverNodes() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ClearPartMassStats() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ClearManeuverNodeStats() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void TogglePhysicsForceDisplay(bool bValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TriggersTools() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static TriggersTools() => throw null;
  }
}
