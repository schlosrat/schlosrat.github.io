// Decompiled with JetBrains decompiler
// Type: KSP.ModularCamera.sample.DemoLogic_01Overview
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.ModularCamera.sample
{
  public class DemoLogic_01Overview : MonoBehaviour
  {
    private ICameraDriver activeDriver;
    private ICameraDriver orbitDriver;
    private ICameraDriver fpsDriver;
    private ICameraDriver dragDriver;
    [Header("Required by Drivers")]
    public Transform pivotTransform;
    public Transform gimbalTransform;
    public Camera cameraReference;
    [Header("Debug stuff")]
    public DemoLogic_01Overview.Mode DEBUG_Mode;
    public GameObject DEBUG_pivotIndicator;
    public Text DEBUG_modeDisplay;
    public DebugInfoStateText DEBUG_infoDisplay;
    [Header("Input Tweakables")]
    public SampleInputProvider DEBUG_inputProvider;

    public Transform CameraTransform
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private DemoLogic_01Overview.Mode activeMode
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
    public DemoLogic_01Overview() => throw null;

    public enum Mode
    {
      Orbit,
      Drag,
      FPS,
      None,
    }
  }
}
