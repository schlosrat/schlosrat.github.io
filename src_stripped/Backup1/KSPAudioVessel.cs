// Decompiled with JetBrains decompiler
// Type: KSPAudioVessel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Messages;
using KSP.Modules;
using KSP.Sim.impl;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[DisallowMultipleComponent]
public class KSPAudioVessel : KerbalMonoBehaviour
{
  public KSPAudioVessel.VesselSounds _vesselSounds;
  public static bool VerboseEnabled;
  private VesselComponent _vesselComponent;
  private bool _isActiveVessel;
  private static int DopplerDeferFrameCount;
  private int _dopplerCountdown;
  private Vector3 _previousListenerPosition;
  private Vector3 _previousSourcePosition;
  private const float MaxDistance = 100f;
  private Module_Kerbal _moduleKerbal;
  private float _p_vessel__angular_velocity_rotation_speed;
  private float _p_vessel_is_kerbal_eva;
  private float _p_vessel_mass_rtpc;
  private float _p_vessel_dynamic_pressure_kPa;
  private float _p_vessel_drag_coefficient;
  private float _p_vessel_temperature;
  private float _p_vessel_gforce;
  private float _p_vessel_atmos_density;
  private float _p_vessel_static_pressure_kPa;
  private float _p_vessel_drag_wind_velocity;
  private float _p_vessel_relative_speed_doppler;

  public static Vector3 ActiveAudioVesselPosition
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetVessel(VesselComponent vesselComp) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void ActivateVesselAudio() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void DeactivateVesselAudio() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnEnable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDisable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void PlayAudioEvents(AK.Wwise.Event[] events) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnActiveVesselChanged(MessageCenterMessage msg) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdateRTPCs() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void LateUpdate() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public KSPAudioVessel() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  static KSPAudioVessel() => throw null;

  [Serializable]
  public class VesselSounds
  {
    [NonReorderable]
    public AK.Wwise.Event[] onVesselLoaded;
    [NonReorderable]
    public AK.Wwise.Event[] onVesselUnloaded;
    [NonReorderable]
    public AK.Wwise.Event[] onVesselActivatedForPlayer;
    [NonReorderable]
    public AK.Wwise.Event[] onVesselDeactivatedForPlayer;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VesselSounds() => throw null;
  }
}
