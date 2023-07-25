// Decompiled with JetBrains decompiler
// Type: KSP.VFX.VFXPostProcessData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Rendering;
using KSP.Sim;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace KSP.VFX
{
  [DisallowMultipleComponent]
  public class VFXPostProcessData : KerbalMonoBehaviour, IEngineFXData
  {
    private bool _isVisible;
    [Header("Post Profile")]
    public PostProcessProfile _postProfile;
    [Header("Distance")]
    public float _distanceMax;
    public AnimationCurve _distanceCurve;
    [Header("Throttle")]
    public AnimationCurve _throttleCurve;
    [Header("Time")]
    public bool _useTimeCurve;
    public AnimationCurve _timeCurve;
    private PostProcessVolume _postVolume;
    private VolumePriority _volumePriority;

    public Action<float, float, float, Vector3> TriggerUpdateVisuals
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ToggleVisibility(bool doTurnOn, ParticleSystemStopBehavior stopBehaviour = ParticleSystemStopBehavior.StopEmitting) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsVisible() => throw null;

    private IPhysicsSpaceProvider PhysicsSpace
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

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
    private void AddVolume() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RemoveVolume() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double CalculateDistanceToCamera() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float CalculatePrefabPostIntensity(double distance, double throttle, double time) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VFXPostProcessData() => throw null;
  }
}
