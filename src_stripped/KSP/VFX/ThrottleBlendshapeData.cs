// Decompiled with JetBrains decompiler
// Type: KSP.VFX.ThrottleBlendshapeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.VFX
{
  [DisallowMultipleComponent]
  [DisableCustomEditorBase]
  public class ThrottleBlendshapeData : KerbalMonoBehaviour, IEngineFXData
  {
    [Tooltip("The normalized pressure where 'Upper Atmosphere' should start. On Kerbin, at 25k above Sea level, the pressure was measured at 0.0092.")]
    public float UpperAtmoNormalizedPressureThreshold;
    public int ZeroThrottleBlendshapeIndex;
    public int UpperAtmosphereBlendshapeIndex;
    public int VacuumBlendshapeIndex;
    public AnimationCurve ThrottleScaleForAtmoBlendCurve;
    public AnimationCurve AtmoToUpperBlendCurve;
    public AnimationCurve UpperAtmoToVacuumBlendCurve;
    public AnimationCurve VacuumFromUpperAtmoBlendCurve;
    public List<ThrottleBlendshapeData.BlendshapeShaderFloatParam> AtmoVac_Float_ShaderParameters;
    public List<ThrottleBlendshapeData.BlendshapeShaderColorParam> AtmoVac_Color_ShaderParameters;
    public List<ThrottleBlendshapeData.BlendshapeShaderFloatParam> Throttle_Float_ShaderMultipliers;
    public List<ThrottleBlendshapeData.BlendshapeShaderColorParam> Throttle_Color_ShaderMultipliers;
    public float bendRotationOffset;
    private SkinnedMeshRenderer BlendShapeMesh;
    private Material _blendShapeMaterial;
    private Dictionary<int, ThrottleBlendshapeData.BlendshapeShaderFloatParam> ThrottleMultiplierDictionaryFloat;
    private Dictionary<int, ThrottleBlendshapeData.BlendshapeShaderColorParam> ThrottleMultiplierDictionaryColor;
    private Vector3 originalBlendShapeScale;
    private float atmoToUpperDif;
    private Bounds refBounds;
    private Mesh refMesh;
    private static List<ThrottleBlendshapeData.BlendshapeShaderFloatParam> defaultThrottleFloatMultipliers;
    private static List<ThrottleBlendshapeData.BlendshapeShaderColorParam> defaultThrottleColorMultipliers;
    private static List<ThrottleBlendshapeData.BlendshapeShaderFloatParam> defaultAtmoVacFloatParameters;
    private static List<ThrottleBlendshapeData.BlendshapeShaderColorParam> defaultAtmoVacColorParameters;

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
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateAtmoVacValues(float curAtmoPercent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateThrottleValues(float curThrottlePercent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateVisuals(
      float curThrottle,
      float curAtmo,
      float curAngleVel,
      Vector3 curAccelerationDir)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyFloatToMaterial(
      Material target,
      ThrottleBlendshapeData.BlendshapeShaderFloatParam curParam)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyColorToMaterial(
      Material target,
      ThrottleBlendshapeData.BlendshapeShaderColorParam curParam)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateBlendShape(float curThrottle, float curAtmo, float curAngleVel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateAccelerationBend(Vector3 acceleration) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Bounds GetUpdatedBounds(Mesh mesh) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static ThrottleBlendshapeData.BlendshapeShaderColorParam GenerateDefaultColorParameter(
      string paramName,
      Color startC,
      Color endC,
      float startA,
      float endA)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static AnimationCurve NewCurve(float startValue, float endValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static AnimationCurve NewFlatEndedLinearCurve(
      float startTime,
      float startValue,
      float endTime,
      float endValue)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ThrottleBlendshapeData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static ThrottleBlendshapeData() => throw null;

    [Serializable]
    public abstract class BlendshapeShaderParam<T>
    {
      public string ShaderParamName;
      public int ParamHash;
      [HideInInspector]
      public T Current;
      [HideInInspector]
      public T PreviouslyRenderedValue;
      [HideInInspector]
      public bool hasRendererd;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public abstract void UpdateCurrent(float curPercent) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      protected BlendshapeShaderParam() => throw null;
    }

    [Serializable]
    public class BlendshapeShaderFloatParam : ThrottleBlendshapeData.BlendshapeShaderParam<float>
    {
      public AnimationCurve MinMaxCurve;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public BlendshapeShaderFloatParam(string _shaderParamName, AnimationCurve _curve) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public override void UpdateCurrent(float curPercent) => throw null;
    }

    [Serializable]
    public class BlendshapeShaderColorParam : ThrottleBlendshapeData.BlendshapeShaderParam<Color>
    {
      [GradientUsage(true)]
      public Gradient MinMaxGradient;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public BlendshapeShaderColorParam(string _shaderParamName, Gradient _gradient) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public override void UpdateCurrent(float curPercent) => throw null;
    }
  }
}
