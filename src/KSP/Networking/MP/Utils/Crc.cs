// Decompiled with JetBrains decompiler
// Type: KSP.Networking.MP.Utils.Crc
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Networking.MP.Utils
{
  public class Crc
  {
    public const uint INVALID_CRC = 0;
    public const uint TABLE_SIZE = 256;
    public const uint NUM_BITS_PER_BYTE = 8;
    public const uint BYTE_MASK = 255;
    public const uint DEFAULT_REVERSE_POLYNOMIAL = 3988292384;
    public const uint DEFAULT_SEED = 4294967295;
    public static readonly Crc Instance;
    private uint _polynomial;
    private readonly uint[] _crcTable;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Crc(uint reversePoly = 3988292384) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetReversePolynomial(uint polynomial) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public uint CalculateCrc32(byte[] byteArray, int srcByteIndex, int numBytesToCrc, uint seed = 4294967295) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public uint CalculateCrc32(string str, uint seed = 4294967295) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void SetupTable(uint[] table, uint polynomial) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static Crc() => throw null;
  }
}
