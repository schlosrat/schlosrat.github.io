// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Serialization.Json.JsonTableConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using MoonSharp.Interpreter.Tree;
using System.Runtime.CompilerServices;
using System.Text;

namespace MoonSharp.Interpreter.Serialization.Json
{
  public static class JsonTableConverter
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string TableToJson(this Table table) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void TableToJson(StringBuilder sb, Table table) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string ObjectToJson(object obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void ValueToJson(StringBuilder sb, DynValue value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static string EscapeString(string s) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static bool IsValueJsonCompatible(DynValue value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Table JsonToTable(string json, Script script = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void AssertToken(Lexer L, TokenType type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static Table ParseJsonArray(Lexer L, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static Table ParseJsonObject(Lexer L, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static DynValue ParseJsonValue(Lexer L, Script script) => throw null;
  }
}
