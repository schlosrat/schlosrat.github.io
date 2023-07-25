// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.AtmosphereTransitionVFXHandling
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.VFX;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim.impl
{
  public class AtmosphereTransitionVFXHandling
  {
    public const float STANDARD_ATMOS_PRESSURE_KPA = 101.325f;
    private PartBehavior parentPart;
    public List<AtmosphereTransitionVFXHandling.AtmosphericCrossfadeData> vfxInAtmosphereList;
    public List<AtmosphereTransitionVFXHandling.AtmosphericCrossfadeData> vfxOutOfAtmosphereList;
    private static int albedoPropertyIndex;
    private static int tintPropertyIndex;
    public float VesselPressurekPa;
    public float VesselPressureNormalized;
    public float VesselAngularVelocity;
    public float startAtmosphericFadeAtPercentage;
    private float lastFadeScaleValue;
    private Quaternion lastVesselRotation;
    private FloatCurve atmosphereVFXCurve;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init(PartBehavior _parentPart) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void InitForTesting(GameObject targetGO) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CollectAtmosphericVFX() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CollectAtmosphericVFX(GameObject targetGO) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddAtmosphericVFX(GameObject atmoGO, GameObject vacGO) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private List<AtmosphereTransitionVFXHandling.AtmosphericCrossfadeData> GetAllParticleSystemsForManagement(
      GameObject PSGO)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GetPressureFromVessel(VesselComponent vessel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CalcRotationSpeedOfVessel(VesselComponent vessel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAtmosphericVFXAlpha() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AtmosphereTransitionVFXHandling() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static AtmosphereTransitionVFXHandling() => throw null;

    public class AtmosphericCrossfadeData
    {
      public ParticleSystem VFX;
      public Material Material;
      public Color OriginalColor;
      public int ColorID;
      public ThrottleParticleSystemData ParticleSystemData;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public AtmosphericCrossfadeData(
        ParticleSystem initialVFX,
        Material initialMaterial,
        ThrottleParticleSystemData initialData)
      {
        throw null;
      }
    }
  }
}
