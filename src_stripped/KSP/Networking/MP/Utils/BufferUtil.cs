// Decompiled with JetBrains decompiler
// Type: KSP.Networking.MP.Utils.BufferUtil
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Networking.MP.Utils
{
  public static class BufferUtil
  {
    public const int SIZE_OF_BYTE = 1;
    public const int SIZE_OF_SBYTE = 1;
    public const int SIZE_OF_INT16 = 2;
    public const int SIZE_OF_UINT16 = 2;
    public const int SIZE_OF_INT32 = 4;
    public const int SIZE_OF_UINT32 = 4;
    public const int SIZE_OF_INT64 = 8;
    public const int SIZE_OF_UINT64 = 8;
    public const int SIZE_OF_FLOAT = 4;
    public const int SIZE_OF_DOUBLE = 8;
    public const int BYTE_VALUE_MIN = 0;
    public const int BYTE_VALUE_MAX = 255;
    public const int SBYTE_VALUE_MIN = -128;
    public const int SBYTE_VALUE_MAX = 127;
    public const int INT16_VALUE_MIN = -32768;
    public const int INT16_VALUE_MAX = 32767;
    public const int UINT16_VALUE_MIN = 0;
    public const int UINT16_VALUE_MAX = 65535;
    public const long INT32_VALUE_MIN = -2147483648;
    public const long INT32_VALUE_MAX = 2147483647;
    public const long UINT32_VALUE_MIN = 0;
    public const long UINT32_VALUE_MAX = 4294967295;
    public const long INT64_VALUE_MIN = -9223372036854775808;
    public const long INT64_VALUE_MAX = 9223372036854775807;
    public const ulong UINT64_VALUE_MIN = 0;
    public const ulong UINT64_VALUE_MAX = 18446744073709551615;
    public const float FLOAT_VALUE_MIN = -3.40282347E+38f;
    public const float FLOAT_VALUE_MAX = 3.40282347E+38f;
    public const double DOUBLE_VALUE_MIN = -1.7976931348623157E+308;
    public const double DOUBLE_VALUE_MAX = 1.7976931348623157E+308;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static byte[] ConvertByteToByteArray(byte val) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static byte[] ConvertSByteToByteArray(sbyte val) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static byte[] ConvertInt16ToByteArray(short val) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static byte[] ConvertUInt16ToByteArray(ushort val) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static byte[] ConvertInt32ToByteArray(int val) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static byte[] ConvertUInt32ToByteArray(uint val) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static byte[] ConvertInt64ToByteArray(long val) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static byte[] ConvertUInt64ToByteArray(ulong val) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static byte[] ConvertFloatToByteArray(float val) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static byte[] ConvertDoubleToByteArray(double val) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static byte ConvertByteArrayToByte(byte[] byteArray) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static sbyte ConvertByteArrayToSByte(byte[] byteArray) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static short ConvertByteArrayToInt16(byte[] byteArray) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static ushort ConvertByteArrayToUInt16(byte[] byteArray) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int ConvertByteArrayToInt32(byte[] byteArray) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static uint ConvertByteArrayToUInt32(byte[] byteArray) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static long ConvertByteArrayToInt64(byte[] byteArray) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static ulong ConvertByteArrayToUInt64(byte[] byteArray) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float ConvertByteArrayToFloat(byte[] byteArray) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double ConvertByteArrayToDouble(byte[] byteArray) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static byte[] ConvertUTF8StringToByteArray(string str) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string ConvertByteArrayToUTF8String(byte[] byteArray) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string ConvertByteArrayToUTF8String(byte[] byteArray, int index, int numBytes) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ConvertNativeEndianToNetworkEndian(
      byte[] byteArray,
      int startIndex,
      int numBytes)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ConvertNetworkEndianToNativeEndian(
      byte[] byteArray,
      int startIndex,
      int numBytes)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Reverse(byte[] byteArray, int startIndex, int numBytes) => throw null;
  }
}
