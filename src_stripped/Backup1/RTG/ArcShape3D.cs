// Decompiled with JetBrains decompiler
// Type: RTG.ArcShape3D
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public class ArcShape3D : Shape3D
  {
    private ArcShape3D.WireRenderDescriptor _wireRenderDesc;
    private Vector3 _startPoint;
    private Vector3 _endPoint;
    private Vector3 _origin;
    private Plane _plane;
    private float _radius;
    private AABB _aabb;
    private float _degreeAngleFromStart;
    private bool _forceShortestArc;
    private List<Vector3> _borderPoints;
    private int _numBorderPoints;
    private bool _areBorderPointsDirty;
    private ArcEpsilon _epsilon;
    private Shape3DRaycastMode _raycastMode;

    public float Radius
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool ForceShortestArc
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float DegreeAngleFromStart
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float AbsDegreeAngleFromStart
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int NumBorderPoints
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Vector3 Origin
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Vector3 StartPoint
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 EndPoint
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Plane Plane
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 Normal
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ArcEpsilon Epsilon
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float AreaEps
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float ExtrudeEps
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float WireEps
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public ArcShape3D.WireRenderDescriptor WireRenderDesc
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Shape3DRaycastMode RaycastMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RenderSolid() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RenderWire() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetArcData(Plane plane, Vector3 origin, Vector3 startPoint, float radius) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool Raycast(Ray ray, out float t) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool RaycastWire(Ray ray, out float t) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool ContainsPoint(Vector3 point, bool checkOnPlane) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override AABB GetAABB() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnBorderPointsFoundDirty() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CalculateEndPoint() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ArcShape3D() => throw null;

    public enum WireRenderFlags
    {
      None,
      ExtremitiesBorder,
      ArcBorder,
      All,
    }

    public class WireRenderDescriptor
    {
      private ArcShape3D.WireRenderFlags _wireFlags;

      public ArcShape3D.WireRenderFlags WireFlags
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
        [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public WireRenderDescriptor() => throw null;
    }
  }
}
