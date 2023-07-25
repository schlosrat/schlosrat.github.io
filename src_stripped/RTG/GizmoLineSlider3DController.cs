// Decompiled with JetBrains decompiler
// Type: RTG.GizmoLineSlider3DController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public abstract class GizmoLineSlider3DController : IGizmoLineSlider3DController
  {
    protected GizmoLineSlider3DControllerData _data;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GizmoLineSlider3DController(GizmoLineSlider3DControllerData controllerData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract void UpdateHandles() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract void UpdateTransforms(float zoomFactor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract void UpdateEpsilons(float zoomFactor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract float GetRealSizeAlongDirection(Vector3 direction, float zoomFactor) => throw null;
  }
}
