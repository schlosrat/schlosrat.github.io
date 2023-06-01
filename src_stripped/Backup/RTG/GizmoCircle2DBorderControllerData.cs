// Decompiled with JetBrains decompiler
// Type: RTG.GizmoCircle2DBorderControllerData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace RTG
{
  public class GizmoCircle2DBorderControllerData
  {
    public Gizmo Gizmo;
    public GizmoPlaneSlider2D PlaneSlider;
    public GizmoCircle2DBorder Border;
    public GizmoHandle TargetHandle;
    public CircleShape2D TargetCircle;
    public CircleShape2D BorderCircle;
    public int BorderCircleIndex;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GizmoCircle2DBorderControllerData() => throw null;
  }
}
