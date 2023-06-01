// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Interop.LuaStateInterop.Tools
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.IO;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace MoonSharp.Interpreter.Interop.LuaStateInterop
{
  internal static class Tools
  {
    internal static Regex r;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool IsNumericType(object o) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool IsPositive(object Value, bool ZeroIsPositive) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static object ToUnsigned(object Value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static object ToInteger(object Value, bool Round) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static long UnboxToLong(object Value, bool Round) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string ReplaceMetaChars(string input) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static string ReplaceMetaCharsMatch(Match m) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void fprintf(TextWriter Destination, string Format, params object[] Parameters) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string sprintf(string Format, params object[] Parameters) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static string FormatOct(
      string NativeFormat,
      bool Alternate,
      int FieldLength,
      int FieldPrecision,
      bool Left2Right,
      char Padding,
      object Value)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static string FormatHex(
      string NativeFormat,
      bool Alternate,
      int FieldLength,
      int FieldPrecision,
      bool Left2Right,
      char Padding,
      object Value)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static string FormatNumber(
      string NativeFormat,
      bool Alternate,
      int FieldLength,
      int FieldPrecision,
      bool Left2Right,
      bool PositiveSign,
      bool PositiveSpace,
      char Padding,
      object Value)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    static Tools() => throw null;
  }
}
