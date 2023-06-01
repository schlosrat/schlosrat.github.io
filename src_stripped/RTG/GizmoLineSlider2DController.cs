// Decompiled with JetBrains decompiler
// Type: RTG.GizmoLineSlider2DController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace RTG
{
  public abstract class GizmoLineSlider2DController : IGizmoLineSlider2DController
  {
    protected GizmoLineSlider2DControllerData _data;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GizmoLineSlider2DController(GizmoLineSlider2DControllerData controllerData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract void UpdateHandles() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract void UpdateTransforms() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract void UpdateEpsilons() => throw null;
  }
}
