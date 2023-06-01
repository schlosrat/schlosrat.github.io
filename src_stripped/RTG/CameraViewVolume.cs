// Decompiled with JetBrains decompiler
// Type: RTG.CameraViewVolume
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public class CameraViewVolume
  {
    private const int _numWorldPoints = 8;
    private const int _numWorldPlanes = 6;
    private Vector3[] _worldPoints;
    private Plane[] _worldPlanes;
    private Vector2 _farPlaneSize;
    private Vector2 _nearPlaneSize;
    private AABB _worldAABB;
    private OBB _worldOBB;

    public Plane LeftPlane
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Plane RightPlane
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Plane BottomPlane
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Plane TopPlane
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Plane NearPlane
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Plane FarPlane
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 NearTopLeft
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 NearTopRight
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 NearBottomRight
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 NearBottomLeft
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 FarTopLeft
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 FarTopRight
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 FarBottomRight
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 FarBottomLeft
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector2 FarPlaneSize
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector2 NearPlaneSize
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public AABB WorldAABB
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public OBB WorldOBB
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CameraViewVolume() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CameraViewVolume(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void FromCamera(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<Vector3> GetNearPlanePoints() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Plane[] GetCameraWorldPlanes(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool CheckAABB(AABB aabb) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool CheckAABB(Camera camera, AABB aabb) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool CheckAABB(Camera camera, AABB aabb, Plane[] cameraWorldPlanes) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CalculateWorldPoints(Camera camera) => throw null;

    public enum VPoint
    {
      NearTopLeft,
      NearTopRight,
      NearBottomRight,
      NearBottomLeft,
      FarTopLeft,
      FarTopRight,
      FarBottomRight,
      FarBottomLeft,
    }

    public enum VPlane
    {
      Left,
      Right,
      Bottom,
      Top,
      Near,
      Far,
    }
  }
}
