// Decompiled with JetBrains decompiler
// Type: MotionModelTest.MotionModelTestCameraFocus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
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
