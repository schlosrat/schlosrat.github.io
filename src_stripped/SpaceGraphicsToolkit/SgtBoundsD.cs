// Decompiled with JetBrains decompiler
// Type: SpaceGraphicsToolkit.SgtBoundsD
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SpaceGraphicsToolkit
{
  [Serializable]
  public struct SgtBoundsD
  {
    public bool set;
    public double minX;
    public double minY;
    public double minZ;
    public double maxX;
    public double maxY;
    public double maxZ;

    public double SizeX
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double SizeY
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double SizeZ
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public SgtVector3D Center
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public SgtVector3D Size
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double ExtentsX
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double ExtentsY
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double ExtentsZ
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public SgtVector3D Extents
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(SgtVector3D xyz) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Contains(SgtVector3D xyz) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Contains(long x, long y, long z) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Clear() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool Equals(object obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int GetHashCode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool operator ==(SgtBoundsD a, SgtBoundsD b) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool operator !=(SgtBoundsD a, SgtBoundsD b) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static explicit operator Bounds(SgtBoundsD a) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToString() => throw null;
  }
}
