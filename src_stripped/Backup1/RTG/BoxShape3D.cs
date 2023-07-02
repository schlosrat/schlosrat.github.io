// Decompiled with JetBrains decompiler
// Type: RTG.BoxShape3D
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public class BoxShape3D : Shape3D
  {
    private BoxShape3D.WireRenderDescriptor _wireRenderDesc;
    private Vector3 _size;
    private Vector3 _center;
    private Quaternion _rotation;
    private BoxEpsilon _epsilon;

    public Vector3 Size
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float Width
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float Height
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float Depth
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Vector3 Extents
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 Center
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public BoxEpsilon Epsilon
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Vector3 SizeEps
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float WidthEps
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float HeightEps
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float DepthEps
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Vector3 Min
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Vector3 Max
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Quaternion Rotation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Vector3 Right
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 Up
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 Look
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public BoxShape3D.WireRenderDescriptor WireRenderDesc
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static Vector3 ModelRight
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static Vector3 ModelUp
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static Vector3 ModelLook
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static Vector3 ModelCenter
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void FromOBB(OBB obb) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetSizeAlongDirection(Vector3 direction) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AlignWidth(Vector3 axis) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AlignHeight(Vector3 axis) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AlignDepth(Vector3 axis) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3 GetFaceCenter(BoxFace boxFace) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetFaceCenter(BoxFace boxFace, Vector3 newCenter) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RenderSolid() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RenderWire() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool Raycast(Ray ray, out float t) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override AABB GetAABB() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OBB GetOBB() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool ContainsPoint(Vector3 point) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BoxShape3D() => throw null;

    public enum WireRenderMode
    {
      Wire,
      WireCorners,
    }

    public class WireRenderDescriptor
    {
      private float _cornerLinePercentage;
      private BoxShape3D.WireRenderMode _wireMode;

      public BoxShape3D.WireRenderMode WireMode
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
        [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      }

      public float CornerLinePercentage
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
        [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public WireRenderDescriptor() => throw null;
    }
  }
}
