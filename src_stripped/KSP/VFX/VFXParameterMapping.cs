// Decompiled with JetBrains decompiler
// Type: KSP.VFX.VFXParameterMapping
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.VFX
{
  [Serializable]
  public class VFXParameterMapping
  {
    private VFXParameterMapping.InitialParameterState _initialState;
    public VFXParameter VFXParameter;
    public VFXContextVariable ContextVariable;
    public AnimationCurve Curve;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VFXParameterMapping(VFXParameter parameter, VFXContextVariable context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VFXParameterMapping(
      VFXParameter parameter,
      VFXContextVariable context,
      AnimationCurve curve)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CaptureInitialState(ParticleSystem ps) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateVFXParameter(
      FXContextData contextData,
      FXPartContextData partData,
      ParticleSystem ps)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateVFXParameter(
      FXContextData contextData,
      FXPartContextData partData,
      TrailRenderer tr)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void SetMinMaxCurveMultiplier(
      ref ParticleSystem.MinMaxCurve curve,
      float curveMultiplier)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void SetMinMaxGradientMultiplier(
      ref ParticleSystem.MinMaxGradient minMaxGrad,
      Color multColor)
    {
      throw null;
    }

    internal class InitialParameterState
    {
      public ParticleSystem.MinMaxCurve startLifetime;
      public ParticleSystem.MinMaxCurve startSpeed;
      public ParticleSystem.MinMaxCurve startSize;
      public ParticleSystem.MinMaxGradient startColor;
      public Vector3 shapeScale;
      public ParticleSystem.MinMaxCurve limitVelocityOverLifetimeDrag;
      public ParticleSystem.MinMaxGradient colorOverLifetimeColor;
      public ParticleSystem.MinMaxCurve sizeOverLifetimeSize;
      public float emissionRateOverTimeMultiplier;
      public float emissionRateOverDistanceMultiplier;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void CaptureInitialState(ParticleSystem ps) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public InitialParameterState() => throw null;
    }
  }
}
