// Decompiled with JetBrains decompiler
// Type: SpaceGraphicsToolkit.SgtRectL
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace SpaceGraphicsToolkit
{
  public struct SgtRectL
  {
    public long minX;
    public long minY;
    public long maxX;
    public long maxY;

    public long SizeX
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public long SizeY
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClampTo(SgtRectL other) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SgtRectL GetExpanded(long amount) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SgtRectL(long newMinX, long newMinY, long newMaxX, long newMaxY) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Contains(long x, long y) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Clear() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SwapX() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SwapY() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool Equals(object obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int GetHashCode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool operator ==(SgtRectL a, SgtRectL b) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool operator !=(SgtRectL a, SgtRectL b) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToString() => throw null;
  }
}
