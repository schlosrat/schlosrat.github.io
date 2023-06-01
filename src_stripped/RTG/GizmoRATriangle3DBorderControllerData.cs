// Decompiled with JetBrains decompiler
// Type: RTG.GizmoRATriangle3DBorderControllerData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace RTG
{
  public class GizmoRATriangle3DBorderControllerData
  {
    public Gizmo Gizmo;
    public GizmoPlaneSlider3D PlaneSlider;
    public GizmoRATriangle3DBorder Border;
    public GizmoHandle TargetHandle;
    public RightAngTriangle3D TargetTriangle;
    public RightAngTriangle3D BorderTriangle;
    public int BorderTriangleIndex;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GizmoRATriangle3DBorderControllerData() => throw null;
  }
}
