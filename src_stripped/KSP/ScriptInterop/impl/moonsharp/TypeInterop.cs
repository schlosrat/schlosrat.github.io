// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.TypeInterop
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using MoonSharp.Interpreter;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  public class TypeInterop
  {
    private Type[] componentTypes;
    private Dictionary<Type, Type> converterTypes;
    private Dictionary<Type, object> valueConverters;
    private Dictionary<Type, TypeInteropAttribute> genericAttributes;
    private Dictionary<Type, Type> genericConverters;
    private Dictionary<string, Type> typeMap;
    private Dictionary<Type, string> typeNicknames;
    private static HashSet<string> warned;

    public static string objectTypeKey
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator<KeyValuePair<Type, Attribute[]>> typesToExamine() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TypeInterop() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Dictionary<string, string> GetTypes() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddTypeNicknameOverrides() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Type TypeFromNickname(string typeNickname) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string NicknameForType(Type type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SelectivelyRegister(Type t) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CollectConverters() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UsedOnlyForAOTCodeGeneration() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private object addConverter(
      ConstructorInfo ctor,
      string nickname,
      string[] altNicknames,
      Type converterType,
      params Type[] genericTypes)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool addNicknames(
      string typeNickname,
      string[] typeAltNames,
      Type dataType,
      params Type[] genericTypes)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Type resolveBaseType(string rawName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Type resolveFullType(string resolvedTypeName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string getGenericArgsString(Type[] genericArguments) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string resolveFullNickname(Type dataType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool resolveNickNamesForType(
      ref string typeNickname,
      ref string[] typeAltNames,
      Type dataType,
      params Type[] genericArguments)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool locateConverter(Type dataType, out object converterObject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Type DecodeTypeFromValue(DynValue from, out DynValue value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Type GetTypeOfTable(DynValue dynValueTable) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void EncodeTypeToTable(DynValue table, Type type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(Type dotNetType, object objectValue, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue<T>(T objectValue, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public object ToValue(Type dotNetType, DynValue dynValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public T ToValue<T>(DynValue dynValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public T ToValue<T>(DynValue dynValue, T defaultValue) where T : struct => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public T ToValueThrowOnFailure<T>(DynValue dynValue) where T : struct => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string ToStringThrowOnFailure(DynValue dynValue, string errorMessage = "") => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int ToIntThrowOnFailure(DynValue dynValue, string errorMessage = "") => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double ToDoubleThrowOnFailure(DynValue dynValue, string errorMessage = "") => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool ToBoolThrowOnFailure(DynValue dynValue, string errorMessage = "") => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float ToFloatThrowOnFailure(DynValue dynValue, string errorMessage = "") => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string ToString(DynValue dynValue, string defaultValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int ToInt(DynValue dynValue, int defaultValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int? ToIntRef(DynValue dynValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double ToDouble(DynValue dynValue, double defaultValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double? ToDoubleRef(DynValue dynValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool ToBool(DynValue dynValue, bool defaultValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool? ToBoolRef(DynValue dynValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float ToFloat(DynValue dynValue, float defaultValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float? ToFloatRef(DynValue dynValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DynValue GetIndexedChannel(
      MoonSharp.Interpreter.Table from,
      int index,
      string shortName,
      string longName)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    static TypeInterop() => throw null;
  }
}
