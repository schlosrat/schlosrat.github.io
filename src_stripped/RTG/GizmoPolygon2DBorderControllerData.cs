// Decompiled with JetBrains decompiler
// Type: RTG.GizmoPolygon2DBorderControllerData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace RTG
{
  public class GizmoPolygon2DBorderControllerData
  {
    public Gizmo Gizmo;
    public GizmoPlaneSlider2D PlaneSlider;
    public GizmoPolygon2DBorder Border;
    public GizmoHandle TargetHandle;
    public PolygonShape2D TargetPolygon;
    public PolygonShape2D BorderPolygon;
    public PolygonShape2D ThickBorderPolygon;
    public int BorderPolygonIndex;
    public int ThickBorderPolygonIndex;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GizmoPolygon2DBorderControllerData() => throw null;
  }
}
