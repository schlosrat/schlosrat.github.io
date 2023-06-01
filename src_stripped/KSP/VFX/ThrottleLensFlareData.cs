// Decompiled with JetBrains decompiler
// Type: KSP.VFX.ThrottleLensFlareData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using KSP.Messages;
using KSP.Sim;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.VFX
{
  [DisableCustomEditorBase]
  [DisallowMultipleComponent]
  [ExecuteInEditMode]
  public class ThrottleLensFlareData : KerbalMonoBehaviour, IEngineFXData
  {
    [SerializeField]
    private ProFlare _flare;
    [Header("Throttle")]
    [Tooltip("Max Intensity is the largest the flare can be when the throttle and distance scalars are both 1")]
    [Range(0.0f, 2000f)]
    [SerializeField]
    private float _flareMaxIntensity;
    [Tooltip("Curve in control of the throttle scalar")]
    [SerializeField]
    private AnimationCurve _lensFlareIntensityCurve;
    [Tooltip("Max range is the furthest the camera can get before the flare is no longer visible")]
    [SerializeField]
    [Header("Range")]
    private float _flareMaxRange;
    [SerializeField]
    [Tooltip("Curve in control of the distance scalar")]
    private AnimationCurve _lensFlareRangeCurve;
    private bool renderFlare;
    private SubscriptionHandle _handleCameraChanged;

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
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RegisterEvents() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveEvents() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnCameraChanged(MessageCenterMessage msg) => throw null;

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
    private double CalculateDistanceToCamera() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float CalculatePrefabFlareIntensity(double distance, double throttle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ThrottleLensFlareData() => throw null;
  }
}
