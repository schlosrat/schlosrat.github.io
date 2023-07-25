// Decompiled with JetBrains decompiler
// Type: KSP.VFX.ThrottleLensFlareData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Messages;
using KSP.Sim;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.VFX
{
  [DisallowMultipleComponent]
  [ExecuteInEditMode]
  [DisableCustomEditorBase]
  public class ThrottleLensFlareData : KerbalMonoBehaviour, IEngineFXData
  {
    [SerializeField]
    private ProFlare _flare;
    [Range(0.0f, 2000f)]
    [Header("Throttle")]
    [SerializeField]
    [Tooltip("Max Intensity is the largest the flare can be when the throttle and distance scalars are both 1")]
    private float _flareMaxIntensity;
    [SerializeField]
    [Tooltip("Curve in control of the throttle scalar")]
    private AnimationCurve _lensFlareIntensityCurve;
    [SerializeField]
    [Tooltip("Max range is the furthest the camera can get before the flare is no longer visible")]
    [Header("Range")]
    private float _flareMaxRange;
    [Tooltip("Curve in control of the distance scalar")]
    [SerializeField]
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
