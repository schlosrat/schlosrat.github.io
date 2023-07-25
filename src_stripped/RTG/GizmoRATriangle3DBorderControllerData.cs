// Decompiled with JetBrains decompiler
// Type: RTG.GizmoRATriangle3DBorderControllerData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
