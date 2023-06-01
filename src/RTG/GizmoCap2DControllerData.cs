// Decompiled with JetBrains decompiler
// Type: RTG.GizmoCap2DControllerData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace RTG
{
  public class GizmoCap2DControllerData
  {
    public Gizmo Gizmo;
    public GizmoCap2D Cap;
    public GizmoHandle CapHandle;
    public QuadShape2D Quad;
    public CircleShape2D Circle;
    public ConeShape2D Arrow;
    public int QuadIndex;
    public int CircleIndex;
    public int ArrowIndex;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GizmoCap2DControllerData() => throw null;
  }
}
