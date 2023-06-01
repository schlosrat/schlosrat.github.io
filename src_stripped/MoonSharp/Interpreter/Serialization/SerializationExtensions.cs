// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Serialization.SerializationExtensions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Serialization
{
  public static class SerializationExtensions
  {
    private static HashSet<string> LUAKEYWORDS;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string Serialize(this Table table, bool prefixReturn = false, int tabs = 0) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static bool IsStringIdentifierValid(DynValue dynValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string SerializeValue(this DynValue dynValue, int tabs = 0) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static string EscapeString(string s) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static SerializationExtensions() => throw null;
  }
}
