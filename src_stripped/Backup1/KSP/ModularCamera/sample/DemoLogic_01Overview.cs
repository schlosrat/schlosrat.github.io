// Decompiled with JetBrains decompiler
// Type: KSP.ModularCamera.sample.DemoLogic_01Overview
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
