// Decompiled with JetBrains decompiler
// Type: RTG.GizmoQuad2DBorderControllerData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace RTG
{
  public class GizmoQuad2DBorderControllerData
  {
    public Gizmo Gizmo;
    public GizmoPlaneSlider2D PlaneSlider;
    public GizmoQuad2DBorder Border;
    public GizmoHandle TargetHandle;
    public QuadShape2D TargetQuad;
    public QuadShape2D BorderQuad;
    public int BorderQuadIndex;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GizmoQuad2DBorderControllerData() => throw null;
  }
}
