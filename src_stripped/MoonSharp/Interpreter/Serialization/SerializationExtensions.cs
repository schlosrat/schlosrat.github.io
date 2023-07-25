// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Serialization.SerializationExtensions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
