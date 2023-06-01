// Decompiled with JetBrains decompiler
// Type: KSP.UI.Flight.FlightHUDWorldLabelsInstrument
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.Game;
using KSP.Messages;
using KSP.Sim.impl;
using KSP.UI.Binding;
using KSP.Utilities;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI.Flight
{
  public class FlightHUDWorldLabelsInstrument : UIFlightHUDInstrument
  {
    [SerializeField]
    private ContextBindRoot _labelPrefab;
    private GameObjectPool<ContextBindRoot> _labelPool;
    private Dictionary<VesselComponent, FlightHUDWorldLabelsInstrument.WorldLabel> _currentLabels;
    private ViewDataProvider _dataProvider;
    private Queue<VesselComponent> _removalQueue;
    private const string VESSEL_NAME_KEY = "VesselName";
    private const string DISTANCE_VALUE_KEY = "VesselDistance";
    private const string VESSEL_TARGETED_KEY = "VesselTargeted";
    private const string IS_DEBRIS_KEY = "IsDebris";

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Initialize(Camera uiRenderCamera, ViewDataProvider viewDataProvider) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVesselChanged(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AddLabel(VesselComponent vessel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RemoveLabel(VesselComponent vessel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ResetLabels() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateLabelData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateLabelPosition() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FlightHUDWorldLabelsInstrument() => throw null;

    public class WorldLabel
    {
      private ContextBindRoot _prefab;
      private VesselComponent _targetVessel;
      private PropertyExternal<string> _vesselNameProp;
      private PropertyExternal<double> _vesselDistanceProp;
      private PropertyExternal<bool> _vesselTargetedProp;
      private PropertyExternal<bool> _isDebrisProp;

      public ContextBindRoot Prefab
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public WorldLabel(VesselComponent vessel, ContextBindRoot labelPrefab) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void BindData(VesselComponent vessel) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void ValidateProperties() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private string GetVesselName() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private double GetDistanceFromActiveVessel() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private bool GetVesselTargeted() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private bool GetIsDebris() => throw null;
    }
  }
}
