// Decompiled with JetBrains decompiler
// Type: KSP.UI.UserInterfaceSettingsMenuManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.UI.Binding;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI
{
  public class UserInterfaceSettingsMenuManager : SettingsSubMenu
  {
    private const string SHOW_VESSEL_LABELS_PROPERTY_KEY = "ShowVesselLabels";
    private const string TEMPERATURE_GAUGES_PROPERTY_KEY = "TemperatureGauges";
    private const string GLOBAL_UI_SCALE_PROPERTY_KEY = "GlobalUIScale";
    private const string SHOW_NAVBALL_IN_MAP_VIEW_PROPERTY_KEY = "ShowNavballInMapView";
    [SerializeField]
    private ContextBindRoot _bindRoot;
    private DataContext _dataContext;
    private Property<bool> _showVesselLabels;
    private Property<bool> _temperatureGauges;
    private Property<float> _globalUIScale;
    private Property<bool> _showNavballInMapView;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Revert() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeContextBinding() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVesselLabelsChanged(bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnTemperatureGaugesChanged(bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnGlobalUIScaleChanged(float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnShowNavballInMapViewChanged(bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyVesselLables(bool selectionValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyTemperatureGauges(bool selectionValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyGlobalUIScalePercent(float selectionValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyShowNavballInMapView(bool selectionValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UserInterfaceSettingsMenuManager() => throw null;
  }
}
