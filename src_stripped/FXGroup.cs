// Decompiled with JetBrains decompiler
// Type: FXGroup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
