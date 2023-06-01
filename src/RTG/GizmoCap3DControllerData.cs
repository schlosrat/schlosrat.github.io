// Decompiled with JetBrains decompiler
// Type: RTG.GizmoCap3DControllerData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace RTG
{
  public class GizmoCap3DControllerData
  {
    public Gizmo Gizmo;
    public GizmoCap3D Cap;
    public GizmoHandle CapHandle;
    public ConeShape3D Cone;
    public PyramidShape3D Pyramid;
    public BoxShape3D Box;
    public SphereShape3D Sphere;
    public TriangPrismShape3D TrPrism;
    public int ConeIndex;
    public int PyramidIndex;
    public int BoxIndex;
    public int SphereIndex;
    public int TrPrismIndex;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GizmoCap3DControllerData() => throw null;
  }
}
