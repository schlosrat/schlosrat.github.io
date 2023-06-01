// Decompiled with JetBrains decompiler
// Type: RTG.GizmoLineSlider3DControllerData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace RTG
{
  public class GizmoLineSlider3DControllerData
  {
    public Gizmo Gizmo;
    public GizmoLineSlider3D Slider;
    public GizmoHandle SliderHandle;
    public SegmentShape3D Segment;
    public BoxShape3D Box;
    public CylinderShape3D Cylinder;
    public int SegmentIndex;
    public int BoxIndex;
    public int CylinderIndex;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GizmoLineSlider3DControllerData() => throw null;
  }
}
