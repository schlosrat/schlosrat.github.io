// Decompiled with JetBrains decompiler
// Type: RTG.GizmoPlaneSlider3DControllerData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace RTG
{
  public class GizmoPlaneSlider3DControllerData
  {
    public Gizmo Gizmo;
    public GizmoPlaneSlider3D Slider;
    public GizmoHandle SliderHandle;
    public GizmoQuad3DBorder QuadBorder;
    public QuadShape3D Quad;
    public GizmoRATriangle3DBorder RATriangleBorder;
    public RightAngTriangle3D RATriangle;
    public GizmoCircle3DBorder CircleBorder;
    public CircleShape3D Circle;
    public int QuadIndex;
    public int RATriangleIndex;
    public int CircleIndex;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GizmoPlaneSlider3DControllerData() => throw null;
  }
}
