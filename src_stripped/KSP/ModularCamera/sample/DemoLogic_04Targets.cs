// Decompiled with JetBrains decompiler
// Type: KSP.ModularCamera.sample.DemoLogic_04Targets
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.PhysicsUtils;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.ModularCamera.sample
{
  public class DemoLogic_04Targets : MonoBehaviour
  {
    private ICameraDriver activeDriver;
    private ICameraDriver driverFPS;
    private ICameraDriver driverOrbitPosition;
    private ICameraDriver driverOrbitLock;
    [Header("Required by Drivers")]
    public Transform pivotTransform;
    public Transform gimbalTransform;
    public Camera cameraReference;
    public TriggerIntersectionWatcher cameraCollisions;
    [Header("Debug stuff")]
    public DemoLogic_04Targets.Mode DEBUG_Mode;
    public GameObject DEBUG_pivotIndicator;
    public DebugInfoStateText DEBUG_infoDisplay;
    [Header("Input Tweakables")]
    public SampleInputProvider inputParser;
    [Space]
    public Transform targetRoot;
    private int targetIndex;
    private List<Collider> targets;
    private float lerpSpeedMove;
    private float lerpSpeedRotate;

    public Transform CameraTransform
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private Transform TargetTransform
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private DemoLogic_04Targets.Mode activeMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PopulateTargets(Transform transform) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleDriverShifting() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool UpdateTarget() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool UpdateDriverMode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDrawGizmos() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DemoLogic_04Targets() => throw null;

    public enum Mode
    {
      FPS_Free,
      Orbit_Position,
      Orbit_Lock,
      None,
    }
  }
}
