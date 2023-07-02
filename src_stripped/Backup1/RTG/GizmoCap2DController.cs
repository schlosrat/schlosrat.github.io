// Decompiled with JetBrains decompiler
// Type: RTG.GizmoCap2DController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
