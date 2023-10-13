// Decompiled with JetBrains decompiler
// Type: SpaceGraphicsToolkit.SgtBoundsL
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;
using System.Runtime.CompilerServices;

namespace SpaceGraphicsToolkit
{
  [Serializable]
  public struct SgtBoundsL
  {
    public long minX;
    public long minY;
    public long minZ;
    public long maxX;
    public long maxY;
    public long maxZ;

    public SgtBoundsL Double
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public long SizeX
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public long SizeY
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public long SizeZ
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public SgtRectL RectZY
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public SgtRectL RectXZ
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public SgtRectL RectXY
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SgtBoundsL(long x, long y, long z, long size) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SgtBoundsL(
      long newMinX,
      long newMinY,
      long newMinZ,
      long newMaxX,
      long newMaxY,
      long newMaxZ)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClampTo(SgtBoundsL other) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Contains(SgtVector3L xyz) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Contains(long x, long y, long z) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsInsideX(long x) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsInsideY(long y) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsInsideZ(long z) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Clear() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool Equals(object obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int GetHashCode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool operator ==(SgtBoundsL a, SgtBoundsL b) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool operator !=(SgtBoundsL a, SgtBoundsL b) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToString() => throw null;
  }
}
