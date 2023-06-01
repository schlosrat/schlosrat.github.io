// Decompiled with JetBrains decompiler
// Type: RTG.GizmoPlaneSlider2DController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public abstract class GizmoPlaneSlider2DController : IGizmoPlaneSlider2DController
  {
    protected GizmoPlaneSlider2DControllerData _data;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GizmoPlaneSlider2DController(GizmoPlaneSlider2DControllerData controllerData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract void UpdateHandles() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract void UpdateTransforms() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract void UpdateEpsilons() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract Vector2 GetRealExtentPoint(Shape2DExtentPoint extentPt) => throw null;
  }
}
