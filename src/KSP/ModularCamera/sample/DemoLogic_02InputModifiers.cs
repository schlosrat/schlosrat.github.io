// Decompiled with JetBrains decompiler
// Type: KSP.ModularCamera.sample.DemoLogic_02InputModifiers
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.ModularCamera.sample
{
  public class DemoLogic_02InputModifiers : MonoBehaviour
  {
    private ICameraDriver activeDriver;
    private ICameraDriver driverBase;
    private ICameraDriver driverExternal;
    private ICameraDriver driverHeight;
    private ICameraDriver driverStageDist;
    private ICameraDriver driverSine;
    [Header("Required by Drivers")]
    public Transform pivotTransform;
    public Transform gimbalTransform;
    public Camera cameraReference;
    [Header("Debug stuff")]
    public DemoLogic_02InputModifiers.Mode DEBUG_Mode;
    public GameObject DEBUG_pivotIndicator;
    public DebugInfoStateText DEBUG_infoDisplay;
    [Header("Input Tweakables")]
    public SampleInputProvider inputParser;
    [Space]
    [Range(0.1f, 10f)]
    public float ExternalValue;
    public Transform stageTransform;

    public Transform CameraTransform
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private DemoLogic_02InputModifiers.Mode activeMode
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
    public DemoLogic_02InputModifiers() => throw null;

    public enum Mode
    {
      SpeedModifier_None,
      SpeedModifier_External,
      SpeedModifier_Height,
      SpeedModifier_StageDist,
      SpeedModifier_Sine,
      None,
    }
  }
}
