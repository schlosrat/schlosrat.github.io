// Decompiled with JetBrains decompiler
// Type: KSP.UI.UserInterfaceSettingsMenuManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
    [SerializeField]
    private ContextBindRoot _bindRoot;
    private DataContext _dataContext;
    private Property<bool> _showVesselLabels;
    private Property<bool> _temperatureGauges;

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
    private void ApplyVesselLables(bool selectionValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyTemperatureGauges(bool selectionValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UserInterfaceSettingsMenuManager() => throw null;
  }
}
