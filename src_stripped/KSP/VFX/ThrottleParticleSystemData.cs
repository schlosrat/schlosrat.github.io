// Decompiled with JetBrains decompiler
// Type: KSP.VFX.ThrottleParticleSystemData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Game;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace KSP.VFX
{
  [DisallowMultipleComponent]
  public class ThrottleParticleSystemData : KerbalMonoBehaviour, IEngineFXData
  {
    public ParticleSystem.Particle[] CurParticles;
    public bool controlDuration;
    public TRANSITIONTYPES durationType;
    [Range(0.0f, 100f)]
    public float durationMin;
    [Range(0.0f, 100f)]
    public float durationMax;
    public AnimationCurve durationCurve;
    public Rect durationCurveRange;
    public bool controlLifetime;
    public TRANSITIONTYPES lifetimeType;
    [Range(0.0f, 1000f)]
    public float lifetimeMin;
    [Range(0.0f, 1000f)]
    public float lifetimeMax;
    public AnimationCurve lifetimeCurve;
    public Rect lifetimeCurveRange;
    public bool controlSize;
    public bool XYZSizeMode;
    public bool sizePressureMode;
    public bool XYZSizePressureMode;
    public TRANSITIONTYPES sizeType;
    public TRANSITIONTYPES sizexyzType;
    [Range(0.0f, 1000f)]
    [SerializeField]
    [FormerlySerializedAs("startSizeMin")]
    public float sizeMin;
    [SerializeField]
    [FormerlySerializedAs("startSizeMax")]
    [Range(0.0f, 1000f)]
    public float sizeMax;
    [FormerlySerializedAs("startSizeMinXYZ")]
    [SerializeField]
    public Vector3 sizeMinXYZ;
    [FormerlySerializedAs("startSizeMaxXYZ")]
    [SerializeField]
    public Vector3 sizeMaxXYZ;
    public AnimationCurve sizeCurve;
    public AnimationCurve sizeCurveX;
    public AnimationCurve sizeCurveY;
    public AnimationCurve sizeCurveZ;
    public AnimationCurve sizePressureCurve;
    public AnimationCurve sizePressureCurveX;
    public AnimationCurve sizePressureCurveY;
    public AnimationCurve sizePressureCurveZ;
    public Rect sizeCurveRange;
    public Rect sizeCurveXRange;
    public Rect sizeCurveYRange;
    public Rect sizeCurveZRange;
    public Rect pressureCurveRange;
    [FormerlySerializedAs("controlEmission")]
    [SerializeField]
    public bool controlEmissionOverTime;
    public TRANSITIONTYPES emissionOverTimeType;
    [SerializeField]
    [FormerlySerializedAs("emissionMin")]
    [Range(0.0f, 1000f)]
    public float emissionOverTimeMin;
    [Range(0.0f, 1000f)]
    [FormerlySerializedAs("emissionMax")]
    [SerializeField]
    public float emissionOverTimeMax;
    public AnimationCurve emissionOverTimeCurve;
    public Rect emissionOverTimeCurveRange;
    public bool controlEmissionOverDistance;
    public TRANSITIONTYPES emissionOverDistanceType;
    [Range(0.0f, 1000f)]
    public float emissionOverDistanceMin;
    [Range(0.0f, 1000f)]
    public float emissionOverDistanceMax;
    [Range(0.0f, 100f)]
    public float emissionRotationThresholdMax;
    [Range(0.0f, 100f)]
    public float emissionRotationThresholdMin;
    public AnimationCurve emissionOverDistanceCurve;
    public Rect emissionOverDistanceCurveRange;
    public bool controlSpeed;
    public TRANSITIONTYPES speedType;
    [Range(0.0f, 1000f)]
    public float speedMin;
    [Range(0.0f, 1000f)]
    public float speedMax;
    public AnimationCurve speedCurve;
    public Rect speedCurveRange;
    public bool controlShapeAngle;
    [Range(0.0f, 360f)]
    public float shapeAngleMin;
    [Range(0.0f, 360f)]
    public float shapeAngleMax;
    public bool controlAlpha;
    public bool alphaPressureMode;
    public AnimationCurve alphaPressureCurve;
    public Gradient lowerAtmoGradient;
    public Gradient upperAtmoGradient;
    public int currentKeyNum;
    public int maxKeyNum;
    public bool alphaOverallMode;
    public AnimationCurve alphaOverallCurve;
    [NonSerialized]
    public ParticleSystem VFX;
    public Vector3 VFXScale;
    public bool oneShot;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    public Action<float, float, float, Vector3> TriggerUpdateVisuals
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ToggleVisibility(bool doTurnOn, ParticleSystemStopBehavior stopBehaviour = ParticleSystemStopBehavior.StopEmitting) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsVisible() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateVisuals(
      float throttleMultiplier,
      float pressureMultiplier,
      float angularVelocityMultiplier,
      Vector3 accelerationDir)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void showBasedOnThrottle(float throttleMultiplier) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void scaleAlpha(
      float pressureRemap,
      ParticleSystem.ColorOverLifetimeModule colorLifetimeVFXInstance)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetParticleDuration(float newDur) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private ParticleSystem.MainModule scaleDuration(
      float throttleMultiplier,
      ParticleSystem.MainModule mainVFXInstance)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void scaleShapeAngle(
      float throttleMultiplier,
      ParticleSystem.ShapeModule shapeVFXInstance)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void scaleEmissionOverDistance(
      float angularVelocityMultiplier,
      ParticleSystem.EmissionModule emissionVFXInstance)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private ParticleSystem.MainModule scaleSize(
      float throttleMultiplier,
      float pressureRemapForCurve,
      ParticleSystem.MainModule mainVFXInstance)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private ParticleSystem.MainModule scaleControlSpeed(
      float throttleMultiplier,
      ParticleSystem.MainModule mainVFXInstance)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private ParticleSystem.EmissionModule scaleEmissionOverTime(
      float throttleMultiplier,
      ParticleSystem.EmissionModule emissionVFXInstance)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private ParticleSystem.MainModule scaleLifetime(
      float throttleMultiplier,
      ParticleSystem.MainModule mainVFXInstance)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float CalculatePressureMultiplier(
      bool usePressureCurve,
      AnimationCurve pressureCurve,
      float curveValue)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float RemapValues(float s, float a1, float a2, float b1, float b2) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Gradient GradientLerp(Gradient a, Gradient b, float t, int maxKey) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ThrottleParticleSystemData() => throw null;
  }
}
