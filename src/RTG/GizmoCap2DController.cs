// Decompiled with JetBrains decompiler
// Type: RTG.GizmoCap2DController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public abstract class GizmoCap2DController : IGizmoCap2DController
  {
    protected GizmoCap2DControllerData _data;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GizmoCap2DController(GizmoCap2DControllerData controllerData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract void UpdateHandles() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract void UpdateTransforms() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract void CapSlider2D(Vector2 sliderDirection, Vector2 sliderEndPt) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract void CapSlider2DInvert(Vector2 sliderDirection, Vector2 sliderEndPt) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract float GetSliderAlignedRealLength() => throw null;
  }
}
