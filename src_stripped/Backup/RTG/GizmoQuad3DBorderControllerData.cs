// Decompiled with JetBrains decompiler
// Type: RTG.GizmoQuad3DBorderControllerData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace RTG
{
  public class GizmoQuad3DBorderControllerData
  {
    public Gizmo Gizmo;
    public GizmoPlaneSlider3D PlaneSlider;
    public GizmoQuad3DBorder Border;
    public GizmoHandle TargetHandle;
    public QuadShape3D TargetQuad;
    public QuadShape3D BorderQuad;
    public BoxShape3D TopBox;
    public BoxShape3D RightBox;
    public BoxShape3D BottomBox;
    public BoxShape3D LeftBox;
    public BoxShape3D TopLeftBox;
    public BoxShape3D TopRightBox;
    public BoxShape3D BottomRightBox;
    public BoxShape3D BottomLeftBox;
    public int BorderQuadIndex;
    public int TopBoxIndex;
    public int RightBoxIndex;
    public int BottomBoxIndex;
    public int LeftBoxIndex;
    public int TopLeftBoxIndex;
    public int TopRightBoxIndex;
    public int BottomRightBoxIndex;
    public int BottomLeftBoxIndex;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GizmoQuad3DBorderControllerData() => throw null;
  }
}
