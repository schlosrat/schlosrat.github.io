// Decompiled with JetBrains decompiler
// Type: RTG.GizmoLineSlider3DControllerData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
