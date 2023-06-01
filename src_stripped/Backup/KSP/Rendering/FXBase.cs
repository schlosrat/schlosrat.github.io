// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.FXBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using KSP.Messages;
using KSP.Sim.impl;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Rendering
{
  [DisallowMultipleComponent]
  public class FXBase : KerbalMonoBehaviour
  {
    [Tooltip("If true, reposition all VFX elements when floating origin snaps")]
    [SerializeField]
    public bool EnableFloatingOrigin;
    [Tooltip("If true, reposition all VFX elements when the inertial frame changes")]
    [SerializeField]
    public bool EnableInertialFrameRebase;
    private SubscriptionHandle _handleReferenceFrameChanged;
    private ParticleSystem _particleSystem;
    private TrailRenderer _trailRenderer;
    private LineRenderer _lineRenderer;
    private ParticleSystem.Particle[] particlesToMove;

    private InertialFrame InertialReferenceFrame
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static event FXBase.FXCreatedEventHandler OnFXCreated
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RegisterEvents() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UnregisterEvents() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPhysicsSpaceProviderReferenceChanged(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator LateFrameChange(PhysicsSpaceRefFrameChangedMessage m) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ReframeParticleSystem(QuaternionD spaceTransition) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ReframeTrailRenderer(QuaternionD spaceTransition) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ReframeLineRenderer(QuaternionD spaceTransition) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void onFrameSnapPositions(Vector3d physicStepVector, List<Action> actionList) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SnapParticleSystem(Vector3 phsycisStepVector) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SnapTrailRenderer(Vector3 phsycisStepVector) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SnapLineRenderer(Vector3 phsycisStepVector) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FXBase() => throw null;

    public delegate void FXCreatedEventHandler(FXBase obj);
  }
}
