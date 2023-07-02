// Decompiled with JetBrains decompiler
// Type: FXGroup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class FXGroup
{
  public List<Light> lights;
  public List<ParticleSystem> vfxList;
  public AudioClip sfx;
  public AudioSource audio;
  private List<float> initSizeValues;
  private List<float> initLifeValues;
  private List<float> initLightValues;
  private bool valid;
  public string name;
  private bool active;
  private float power;
  public float powerVariation;
  public bool activeLatch;

  public bool isValid
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public FXGroup(string groupID) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void begin(AudioSource audioRef) => throw null;

  public bool Active
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void setActive(bool value) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Burst() => throw null;

  public float Power
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetLatch(bool latch) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetPower(float pwr) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetPowerLatch(float pwr) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Unlatch() => throw null;
}
