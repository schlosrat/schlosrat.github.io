// Decompiled with JetBrains decompiler
// Type: KSP.Map.MapItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Sim.impl;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Map
{
  public class MapItem
  {
    public static readonly IGGuid DEFAULT_SIM_GUID;
    public const MapItemType DEFAULT_MAP_ITEM_TYPE = MapItemType.Unknown;
    public const string DEFAULT_MAP_ITEM_NAME = "";
    private const bool DEFAULT_IS_STAR = false;
    private const string TRACKING_STATION_PREFIX = "Menu/TrackingStation/";
    private const string VESSEL = "Vessel";
    private const string CELESTIAL_BODY = "CelestialBody";
    private const string COLONY = "Colony";
    private const string EVA_KERBAL = "EVAKerbal";
    private const string DELIVERY_ROUTE = "DeliveryRoute";
    private const string DEBRIS = "Debris";
    private const string WAYPOINT = "Waypoint";
    private string _itemName;
    private IGGuid _simGUID;
    private IGGuid _parentSimGUID;
    private MapItemType _mapItemType;
    private Dictionary<MapItemType, string> MapObjectTypeTags;

    public string ItemName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public IGGuid SimGUID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public IGGuid ParentSimGUID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public MapItemType MapItemType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool IsStar
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public string MapObjectTypeTag
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MapItem() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MapItem(IGGuid simGUID, MapItemType mapItemType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MapItem(
      IGGuid simGUID,
      MapItemType mapItemType,
      string itemName,
      IGGuid parentGUID = default (IGGuid),
      bool isStar = false)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MapItem(MapItem src) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetDataValues() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Set(
      IGGuid simGUID,
      MapItemType mapItemType,
      string itemName,
      IGGuid parentSimGUID,
      bool isStar)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Set(MapItem src) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Matches(MapItem src) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetDebugString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static MapItem() => throw null;
  }
}
