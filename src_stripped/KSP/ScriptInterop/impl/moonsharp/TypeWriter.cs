// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.TypeWriter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using MoonSharp.Interpreter;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;

namespace KSP.ScriptInterop.impl.moonsharp
{
  public class TypeWriter : ITypeWriter
  {
    private string clrTypeKey;
    private StringBuilder sb;
    private static readonly HashSet<DataType> InvalidKeyDataTypes;
    private static readonly HashSet<DataType> InvalidValueDataTypes;
    private static StringBuilder escapeBuilder;
    private static Regex simpleVariableRegex;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string Write(DynValue value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string Write(DynValue value, FormatOptions options) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Write(DynValue value, StringBuilder stringBuilder) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Write(DynValue value, StringBuilder stringBuilder, FormatOptions options) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TypeWriter(string clrTypeKey) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static string escape(string str) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool DynValueToScript(
      DynValue dynValue,
      StringBuilder sb,
      bool includeTypeComments = true,
      int tabs = 0,
      string tab = "\t",
      bool includeNils = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Type GetListElementType(Type listType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static object GetDefaultValue(Type type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool SafeParseEnum(
      Type enumType,
      string enumString,
      out object enumValue,
      object enumDefault = null)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool SafeParseEnum<T>(string enumString, out T enumValue, T enumDefault = default (T)) where T : struct, IConvertible => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static TypeWriter() => throw null;
  }
}
