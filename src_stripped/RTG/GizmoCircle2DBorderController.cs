// Decompiled with JetBrains decompiler
// Type: RTG.GizmoCircle2DBorderController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace RTG
{
  public abstract class GizmoCircle2DBorderController : IGizmoCircle2DBorderController
  {
    protected GizmoCircle2DBorderControllerData _data;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GizmoCircle2DBorderController(GizmoCircle2DBorderControllerData data) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract void UpdateHandles() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract void UpdateEpsilons() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract void UpdateTransforms() => throw null;
  }
}
