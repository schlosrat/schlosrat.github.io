// Decompiled with JetBrains decompiler
// Type: KSP.ModularCamera.sample.DemoLogic_03Validation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.PhysicsUtils;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.ModularCamera.sample
{
  public class DemoLogic_03Validation : MonoBehaviour
  {
    private ICameraDriver activeDriver;
    private ICameraDriver fpsDriver_NoValidate;
    private ICameraDriver fpsDriver_ValidateFloor;
    private ICameraDriver fpsDriver_ValidateColliders;
    [Header("Required by Drivers")]
    public Transform pivotTransform;
    public Transform gimbalTransform;
    public Camera cameraReference;
    public TriggerIntersectionWatcher cameraCollisions;
    [Header("Debug stuff")]
    public DemoLogic_03Validation.Mode DEBUG_Mode;
    public GameObject DEBUG_pivotIndicator;
    public DebugInfoStateText DEBUG_infoDisplay;
    [Header("Input Tweakables")]
    public SampleInputProvider inputParser;

    public Transform CameraTransform
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private DemoLogic_03Validation.Mode activeMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool UpdateDriverMode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDrawGizmos() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DemoLogic_03Validation() => throw null;

    public enum Mode
    {
      Validate_None,
      Validate_Floor,
      Validate_Colliders,
      None,
    }
  }
}
