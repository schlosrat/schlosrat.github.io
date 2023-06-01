// Decompiled with JetBrains decompiler
// Type: KSP.Map.Map3DView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using KSP.Messages;
using KSP.Sim.impl;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Map
{
  public class Map3DView : KerbalMonoBehaviour
  {
    private const string INIT_ASSERT_MESSAGE = "Map3DView has not been initialized with Configure(...)!";
    [SerializeField]
    private MapCamera _mapCamera;
    [SerializeField]
    private Map3DFocusItem _itemTemplate;
    [SerializeField]
    private OrbitRenderer _orbitRendererTemplate;
    [SerializeField]
    private Map3DSpaceProvider _spaceProvider;
    [SerializeField]
    private Map3DTooltips _tooltipManager;
    [SerializeField]
    private Map3DManeuvers _maneuverManager;
    [SerializeField]
    private Map3DTrajectoryEvents _maneuverEvents;
    [SerializeField]
    private double _inverseScaleFactor;
    [SerializeField]
    private List<MapItemType> _targettableMapItems;
    private bool _initialized;
    private OrbitRenderer _orbitRendererInstance;
    private Dictionary<IGGuid, Map3DFocusItem> _objectsLookup;
    private List<Map3DFocusItem> _maneuverableItems;
    private SubscriptionHandle _handleFocusChanged;
    private SubscriptionHandle _handleTooltipRequested;
    private SubscriptionHandle _handleTooltipRemoved;
    private SubscriptionHandle _handleVesselDestroyed;
    private SubscriptionHandle _handleVesselChanged;
    private List<GameObject> scaledCloudMaps;
    private GameObject scaledSpaceCelestialBodyInstance;
    private readonly Queue<Map3DView.Map3DViewAssetLoadRequest> _queuePrefabLoader;

    public bool ViewAndCameraInitialized
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Dictionary<IGGuid, Map3DFocusItem> AllMapSelectableItems
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Map3DTrajectoryEvents ManeuverEvents
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Map3DManeuvers ManeuverManager
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Configure(List<MapItem> mapItems) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string BuildObjectLookupDictionaryDebugString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnTooltipRequested(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnTooltipRemove(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVesselChanged(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVesselDestroyed(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FixedUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RequestAssetLoad(Map3DView.Map3DViewAssetLoadRequest request) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Map3DSpaceProvider GetSpaceProvider() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MapCamera FindMapCamera() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MapCamera GetMapCamera() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcessMapItems(List<MapItem> mapItems) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateMapItems(List<MapItem> mapItems) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ProcessSingleMapItem(MapItem item) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnMapScaledSpaceCelestialBodyInstantiated(GameObject instance, IGGuid id) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnFocusChanged(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnMapShutdown(MessageCenterMessage message) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsValidTargetType(MapItemType itemType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetItemTypeTargetable(MapItemType itemType, bool isTargetable) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool GetItemTypeTargetable(MapItemType itemType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Map3DView() => throw null;

    public struct Map3DViewAssetLoadRequest
    {
      public MapItemType MapItemType;
      public string AssetKey;
      public IGGuid Guid;
      public Transform ParentTransform;
    }
  }
}
