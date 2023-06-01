// Decompiled with JetBrains decompiler
// Type: RTG.Plane2D
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public class Plane2D
  {
    private Vector2 _normal;
    private float _distance;

    public Vector2 Normal
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float Distance
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Plane2D(Vector2 normal, float distance) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Plane2D(Vector2 normal, Vector2 pointOnPlane) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetDistanceToPoint(Vector2 point) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Raycast(Vector2 rayOrigin, Vector2 rayDir, out float t) => throw null;
  }
}
