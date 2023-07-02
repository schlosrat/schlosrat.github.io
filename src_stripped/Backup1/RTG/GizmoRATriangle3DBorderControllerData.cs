// Decompiled with JetBrains decompiler
// Type: RTG.GizmoRATriangle3DBorderControllerData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
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
