// Decompiled with JetBrains decompiler
// Type: RTG.MeshTransform
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public class MeshTransform
  {
    private Vector3 _position;
    private Quaternion _rotation;
    private Vector3 _scale;

    public Vector3 Position
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Quaternion Rotation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 Scale
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MeshTransform(Vector3 position, Quaternion rotation, Vector3 scale) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MeshTransform(Transform transform) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OBB InverseTransformOBB(OBB obb) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3 TransformPoint(Vector3 point) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3 InverseTransformPoint(Vector3 point) => throw null;
  }
}
