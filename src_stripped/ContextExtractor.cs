// Decompiled with JetBrains decompiler
// Type: ContextExtractor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Api;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

public static class ContextExtractor
{
  [MethodImpl(MethodImplOptions.NoInlining)]
  public static IDataContextReadonly Extract<T>(
    T source,
    IDataContextReadonly parentContext = null,
    bool requireAttribute = false)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void ExtractTo<T>(IDataContextWritable target, T source, bool requireAttribute = false) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static void ExtractPropertiesTo<T>(
    IDataContextWritable target,
    T source,
    Dictionary<string, FieldInfo> fields,
    Dictionary<string, MethodInfo> methods,
    Dictionary<string, PropertyInfo> properties,
    bool requireAttribute)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static void ExtractActionsTo<T>(
    IDataContextWritable target,
    T source,
    Dictionary<string, FieldInfo> fields,
    Dictionary<string, MethodInfo> methods,
    Dictionary<string, PropertyInfo> properties,
    bool requireAttribute)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static void ExtractSubContextsTo<T>(
    IDataContextWritable target,
    T source,
    Dictionary<string, FieldInfo> fields,
    Dictionary<string, MethodInfo> methods,
    Dictionary<string, PropertyInfo> properties,
    bool requireAttribute)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static void ExtractListsTo<T>(
    IDataContextWritable target,
    T source,
    Dictionary<string, FieldInfo> fields,
    Dictionary<string, MethodInfo> methods,
    Dictionary<string, PropertyInfo> properties,
    bool requireAttribute)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static bool GetMemberInfoIsPrivate(MemberInfo member) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static void GetDataMembersInfos<TSource, TAttrib>(
    TSource source,
    Dictionary<string, FieldInfo> fields,
    Dictionary<string, MethodInfo> methods,
    Dictionary<string, PropertyInfo> properties,
    bool requireAttribute = false)
    where TAttrib : DataBaseAttribute
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static Delegate CreateDelegate(MethodInfo methodInfo, object target) => throw null;
}
