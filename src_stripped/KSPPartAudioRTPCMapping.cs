// Decompiled with JetBrains decompiler
// Type: KSPPartAudioRTPCMapping
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.impl;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[CreateAssetMenu(fileName = "KSPAudioRTPCMapping", menuName = "ScriptableObjects/KSPAudioRTPCMapping")]
public class KSPPartAudioRTPCMapping : ScriptableObject
{
  public KSPPartAudioRTPCPair _altitude;
  public KSPPartAudioRTPCPair _height;
  public KSPPartAudioRTPCPair _gforce;
  public KSPPartAudioRTPCPair _speed;
  public KSPPartAudioRTPCPair _staticPressure;
  public KSPPartAudioRTPCPair _partStaticPressure;
  public KSPPartAudioRTPCPair _vesselAtmDensity;
  public KSPPartAudioRTPCPair _partAtmDensity;
  public KSPPartAudioRTPCPair _partTemp;
  public KSPPartAudioRTPCPair _partDynamicPressure;
  public KSPPartAudioRTPCPair _partVelocity;
  public KSPPartAudioRTPCPair _partDrag;
  public KSPPartAudioRTPCPair _partMass;
  public KSPPartAudioRTPCPair _partAngularVelocity;
  public KSPPartAudioRTPCPair _machNumber;
  public KSPPartAudioRTPCPair _temperatureRatio;
  public KSPPartAudioRTPCPair _jointTorque;
  public KSPPartAudioRTPCPair _underWater;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public KSPPartAudioRTPCMapping() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void UpdateRTPCs(
    KSPPartAudioBase partAudio,
    ref Dictionary<uint, float> cache,
    VesselBehavior vessel,
    PartBehavior partBehavior)
  {
    throw null;
  }
}
