// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.FXBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
    private Vector3 _previousFramePosition;
    private SubscriptionHandle _handleReferenceFrameChanged;
    private ParticleSystem _particleSystem;
    private TrailRenderer _trailRenderer;
    private LineRenderer _lineRenderer;
    private ParticleSystem.Particle[] _particlePositionBuffer;
    private Vector3[] _linePositionBuffer;
    private Vector3[] _trailPositionBuffer;

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
    private void ValidateParticleBufferStorageSize(int size) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ValidateTrailPositionBufferStorageSize(int size) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ValidateLinePositionBufferStorageSize(int size) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPhysicsSpaceProviderReferenceChanged(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DisableRenderers() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void EnableRenderers() => throw null;

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
