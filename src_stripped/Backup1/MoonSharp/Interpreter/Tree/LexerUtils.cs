// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Tree.LexerUtils
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Tree
{
  internal static class LexerUtils
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double ParseNumber(Token T) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double ParseHexInteger(Token T) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string ReadHexProgressive(string s, ref double d, out int digits) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double ParseHexFloat(Token T) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int HexDigit2Value(char c) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool CharIsDigit(char c) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool CharIsHexDigit(char c) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string AdjustLuaLongString(string str) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string UnescapeLuaString(Token token, string str) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static string ConvertUtf32ToChar(int i) => throw null;
  }
}
