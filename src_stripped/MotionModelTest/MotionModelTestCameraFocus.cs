﻿// Decompiled with JetBrains decompiler
// Type: MotionModelTest.MotionModelTestCameraFocus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace MotionModelTest
{
  [RequireComponent(typeof (Camera))]
  public class MotionModelTestCameraFocus : MonoBehaviour
  {
    public string frameOfReference;
    public MotionModelTestCameraFocus.Mode mode;
    public float zoomOffset;
    private Camera cam;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MotionModelTestCameraFocus() => throw null;

    public enum Mode
    {
      CelestialFrame,
      BodyFrame,
      ParentFrame,
    }
  }
}
