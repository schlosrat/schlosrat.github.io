// Decompiled with JetBrains decompiler
// Type: KSPPartWheelAudio
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using AK.Wwise;
using KSP.Messages;
using KSP.Modules;
using KSP.Rendering.Planets;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class KSPPartWheelAudio : KSPPartAudioBase
{
  public KSPPartWheelAudio.WheelSounds sounds;
  public float WheelDisplacementCutOff;
  public bool QualifyForLandVehicleWheel;
  private bool _isWheelOnGround;
  private float _currentBreakValue;
  private float _currentDisplacementValue;
  private PQSData.KSP2BiomeType _collisionBiomeType;
  private Module_WheelBase _wheelModule;
  private bool _isWheelOnActiveVessel;
  private bool _isWheelRegistered;
  private DateTime _timeWhenWheelLeftGround;
  private bool _hasBeenInTheAirLongEnough;
  private bool _hasBeenInTheAirHighEnough;

  public float WheelSpeed
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public override List<KSPPartAudioBase.PartAudioEvent> SupportedEvents
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected override Event[] GetAudioEventForPartEvent(
    KSPPartAudioBase.PartAudioEvent partAudioEvent)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public override void OnEnable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public override void OnDisable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public override void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetWheelOnGround(bool isOnGround) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetWheelBrakeValue(float breakValue) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetWheelDisplacementValue(float displacementValue) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdateWheelTouchdown() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnActiveVesselChanged(MessageCenterMessage msg) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public KSPPartWheelAudio() => throw null;

  [Serializable]
  public class WheelSounds
  {
    [NonReorderable]
    public Event[] onWheelTouchGround;
    [NonReorderable]
    public Event[] onWheelLeaveGround;
    [NonReorderable]
    public Event[] onBreakingStarts;
    [NonReorderable]
    public Event[] onBreakingStops;
    [NonReorderable]
    public Event[] onVABPartHighlight;
    [NonReorderable]
    public Event[] OnWheelAirplaneTouchdown;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public WheelSounds() => throw null;
  }
}
