﻿// Decompiled with JetBrains decompiler
// Type: KSPPartAudioRTPCMapping
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
