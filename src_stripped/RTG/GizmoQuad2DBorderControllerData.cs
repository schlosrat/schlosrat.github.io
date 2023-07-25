// Decompiled with JetBrains decompiler
// Type: RTG.GizmoQuad2DBorderControllerData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
