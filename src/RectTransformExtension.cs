// Decompiled with JetBrains decompiler
// Type: RectTransformExtension
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

public static class RectTransformExtension
{
  private static Vector3[] Corners;
  private static int visibleCorners;
  private static Vector3 screenSpaceCornerCache;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static int CornersVisible(
    this RectTransform rectTransform,
    Camera cam,
    RectTransform canvasRect)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static bool IsPartiallyVisible(
    this RectTransform rectTransform,
    Camera cam,
    RectTransform canvasRect)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static bool IsFullyVisible(
    this RectTransform rectTransform,
    Camera cam,
    RectTransform canvasRect)
  {
    throw null;
  }
}
