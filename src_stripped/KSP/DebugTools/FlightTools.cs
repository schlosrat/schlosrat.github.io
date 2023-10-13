// Decompiled with JetBrains decompiler
// Type: KSP.DebugTools.FlightTools
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Game;
using KSP.Messages;
using KSP.Sim.impl;
using KSP.Utilities;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.DebugTools
{
  public class FlightTools : KerbalMonoBehaviour
  {
    private const string SIM_OBJECT_TOOLS_WINDOW_ADDRESSABLE_NAME = "Flight Tools Window.prefab";
    [SerializeField]
    private SimObjectItem _simObjectItemPrefab;
    [SerializeField]
    private JointConnectionItem _jointConnectionItemPrefab;
    [SerializeField]
    private Transform _itemListParent;
    [SerializeField]
    [Header("Settings Toggles")]
    private Toggle _toggleProximityLoadUnload;
    [SerializeField]
    private Toggle _toggleCelestialBodyCollisionApproximation;
    [SerializeField]
    private Toggle _toggleHighlightItems;
    [Header("Type Toggles")]
    [SerializeField]
    private Toggle _toggleShowVessels;
    [SerializeField]
    private Toggle _toggleShowParts;
    [SerializeField]
    private Toggle _toggleShowJointConnections;
    [SerializeField]
    private Toggle _toggleShowCelestialBodies;
    [Header("Additional Toggles")]
    [SerializeField]
    private Toggle _toggleActiveVesselOnly;
    private static GameObject s_instance;
    private GameObjectPool<SimObjectItem> _simObjectItemPool;
    private GameObjectPool<JointConnectionItem> _jointConnectionItemPool;
    private bool _forceRefresh;
    private bool _highlightItems;
    private FlightTools.ItemType _filterType;
    private bool _filterActiveVesselOnly;
    private SubscriptionHandle _activeVesselChangedHandle;
    private SubscriptionHandle _gameLoadFinishedHandle;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ToggleWindow() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void HideWindow() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void CreateWindow() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void DestroyWindow() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroyButtonClicked() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static bool IsInFilter(
      SimulationObjectModel simObject,
      FlightTools.ItemType curComponentTypeFilter,
      bool filterActiveVesselOnly,
      IGGuid activeVesselGuid)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnSimObjectItemReset(SimObjectItem simObjectItem) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnJointConnectionItemReset(JointConnectionItem jointConnectionItem) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ForceRefresh() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnSimObjectItemPointerEntered(FlightToolsItem<SimulationObjectModel> item) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnSimObjectItemPointerExited(FlightToolsItem<SimulationObjectModel> item) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnJointConnectionItemPointerEntered(
      FlightToolsItem<PartOwnerBehavior.JointConnection> item)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnJointConnectionItemPointerExited(
      FlightToolsItem<PartOwnerBehavior.JointConnection> item)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void SetVesselHighlight(VesselBehavior vesselBehavior, bool isHighlighted) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void SetPartHighlight(PartBehavior partBehavior, bool isHighlighted) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void SetJointConnectionHighlight(
      PartOwnerBehavior.JointConnection jointConnection,
      bool isHighlighted)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static ObjectOutlinesManager GetOutlineManager() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnGameLoadFinished(MessageCenterMessage obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnActiveVesselChanged(MessageCenterMessage obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnToggleHighlightItemsValueChanged(bool newValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnToggleProximityLoadUnloadValueChanged(bool newValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnToggleCelestialBodyCollisionApproximationValueChanged(bool newValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnToggleShowVesselsValueChanged(bool newValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnToggleShowPartsValueChanged(bool newValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnToggleShowJointConnectionsValueChanged(bool newValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnToggleShowCelestialBodiesValueChanged(bool newValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnToggleOnlyActiveVesselValueChanged(bool newValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FlightTools() => throw null;

    private enum ItemType
    {
      Vessel,
      Part,
      JointConnection,
      CelestialBody,
    }
  }
}
