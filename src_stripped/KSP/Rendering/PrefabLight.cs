// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.PrefabLight
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Sim;
using KSP.Sim.impl;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Rendering
{
  public class PrefabLight : KerbalMonoBehaviour
  {
    private bool _lightEnabled;
    private MeshRenderer[] _meshRenderers;
    private Light[] _lights;
    private float _boundsSize;
    [SerializeField]
    private Color _lightColor;
    [ColorUsage(true, true)]
    private float _lightIntensity;
    private float _currentIntensity;
    [SerializeField]
    private bool _reactToTimeOfDay;
    [SerializeField]
    private AnimationCurve _enabledAnimCurve;
    [SerializeField]
    private float _enabledDuration;
    [SerializeField]
    private AnimationCurve _disabledAnimCurve;
    [SerializeField]
    private float _disabledDuration;
    private float _timeIntensityMultiplier;
    private IPhysicsSpaceProvider PhysicsSpace;
    private UniverseCameraManager CameraManager;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void EnableLight() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DisableLight() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator AnimateLightIntensityEvent(
      float duration,
      AnimationCurve curve,
      bool enabled)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ForceDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAllLightColors(Color color) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateAllLightIntensities(float intensity) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetEnabledStatusAllLights(bool enabled) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float CalculateDistanceToCamera() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PrefabLight() => throw null;
  }
}
