// Decompiled with JetBrains decompiler
// Type: RTG.GizmoCap3DController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public abstract class GizmoCap3DController : IGizmoCap3DController
  {
    protected GizmoCap3DControllerData _data;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GizmoCap3DController(GizmoCap3DControllerData controllerData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract void UpdateHandles() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract void UpdateTransforms(float zoomFactor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract void CapSlider3D(
      Vector3 sliderDirection,
      Vector3 sliderEndPt,
      float zoomFactor)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract void CapSlider3DInvert(
      Vector3 sliderDirection,
      Vector3 sliderEndPt,
      float zoomFactor)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract float GetSliderAlignedRealLength(float zoomFactor) => throw null;
  }
}
