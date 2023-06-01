// Decompiled with JetBrains decompiler
// Type: KSP.ModularCamera.DebugDrawHelpers
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.ModularCamera
{
  public static class DebugDrawHelpers
  {
    private static readonly float EPSILON_SQR;
    private static readonly Color PivotColor;
    private static readonly Color CameraColorAtTarget;
    private static readonly Color CameraColorNotAtTarget;
    private static readonly Color TargetColor;
    private static readonly Color TargetLineColor;
    private static readonly Color DefaultGridColor;
    private static readonly Color DefaultFrustumColor;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static float PercentDiff(float a, float b) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void DrawCameraDriverGizmos(
      Transform pivot,
      Transform gimbal,
      Transform camera,
      ICameraDriver driver = null,
      float sphereRadius = 0.6f)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void DrawCameraFrustum(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void DrawCameraFrustum(Camera camera, Color color) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void SetDebugColor(Color color) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Color GetDebugColor() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void DrawOrientationGrid(Matrix4x4 localToWorld, int fields, bool showXYZ = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void DrawOrientationGrid(
      Matrix4x4 localToWorld,
      int fields,
      Color gridColor,
      bool showXYZ = false)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void DrawGrid(Matrix4x4 localToWorld, int width, int height, int subdivs) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void DrawAxes(
      Matrix4x4 localToWorld,
      Color gridColor = default (Color),
      float axisLength = 3f,
      bool showXYZ = false)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void DrawArrowHandle(Vector3 worldPos, Quaternion worldDir, float length) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void DrawLine(Matrix4x4 localToWorld, Vector3 localStart, Vector3 localEnd) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static DebugDrawHelpers() => throw null;
  }
}
