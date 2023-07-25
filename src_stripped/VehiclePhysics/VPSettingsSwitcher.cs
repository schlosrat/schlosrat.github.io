// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.VPSettingsSwitcher
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace VehiclePhysics
{
  [AddComponentMenu("Vehicle Physics/Utility/Settings Switcher", 42)]
  public class VPSettingsSwitcher : VehicleBehaviour
  {
    public int selectedGroup;
    public VPSettingsSwitcher.SettingsGroup[] settingsGroups;
    private VPSettingsSwitcher.SettingsGroup m_currentGroup;
    private VPVehicleController m_vehicle;
    private VPSettingsSwitcher.SettingsGroup m_originalSettings;

    public VPSettingsSwitcher.SettingsGroup currentGroup
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnEnableVehicle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnDisableVehicle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void FixedUpdateVehicle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Refresh() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VPSettingsSwitcher() => throw null;

    [Serializable]
    public class SettingsGroup
    {
      public string name;
      public Color uiColor;
      public bool setSteeringAids;
      public bool setTractionControl;
      public bool setStabilityControl;
      public bool setAntiSpin;
      public bool setDifferential;
      public SteeringAids.Settings steeringAids;
      public TractionControl.Settings tractionControl;
      public StabilityControl.Settings stabilityControl;
      public AntiSpin.Settings antiSpin;
      public Differential.Settings differential;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void LoadFromVehicle(VPVehicleController vehicle) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void SaveToVehicle(VPVehicleController vehicle, bool force = false) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public SettingsGroup() => throw null;
    }
  }
}
