// Decompiled with JetBrains decompiler
// Type: KSP.UnionArray
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace KSP
{
  [StructLayout(LayoutKind.Explicit)]
  internal struct UnionArray
  {
    [FieldOffset(0)]
    public byte[] bytes;
    [FieldOffset(0)]
    private bool[] booleans;
    [FieldOffset(0)]
    private sbyte[] sbytes;
    [FieldOffset(0)]
    private char[] chars;
    [FieldOffset(0)]
    private short[] shorts;
    [FieldOffset(0)]
    private int[] ints;
    [FieldOffset(0)]
    private long[] longs;
    [FieldOffset(0)]
    private ushort[] ushorts;
    [FieldOffset(0)]
    private uint[] uints;
    [FieldOffset(0)]
    private ulong[] ulongs;
    [FieldOffset(0)]
    private float[] floats;
    [FieldOffset(0)]
    private double[] doubles;

    public bool[] Booleans
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public sbyte[] SBytes
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public char[] Chars
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public short[] Shorts
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int[] Ints
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public long[] Longs
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ushort[] UShorts
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public uint[] UInts
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ulong[] ULongs
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float[] Floats
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double[] Doubles
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int LengthOfBytes() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int LengthOfType<T>() where T : struct => throw null;
  }
}
