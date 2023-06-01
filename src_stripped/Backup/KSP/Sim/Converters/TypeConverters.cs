// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Converters.TypeConverters
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace KSP.Sim.Converters
{
  public static class TypeConverters
  {
    private static Dictionary<string, PropertyInfo> fromProperties;
    private static Dictionary<string, PropertyInfo> toProperties;
    private static Dictionary<string, FieldInfo> fromFields;
    private static Dictionary<string, FieldInfo> toFields;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void FillDictionaryWithProperties(
      Type type,
      Dictionary<string, PropertyInfo> dictionary,
      bool includeIgnoredTypes = false)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void FillDictionaryWithFields(
      Type type,
      Dictionary<string, FieldInfo> dictionary,
      bool includeIgnoredTypes = false)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void CopyPropertiesFromProperties(
      this object self,
      object parent,
      bool errorIfSourceNotFound = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void CopyPropertiesFromFields(
      this object self,
      object parent,
      bool errorIfSourceNotFound = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void CopyFieldsFromFields<T>(
      ref T self,
      object parent,
      bool errorIfSourceNotFound = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void CopyFieldsFromProperties<T>(
      ref T self,
      object parent,
      bool errorIfSourceNotFound = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    static TypeConverters() => throw null;
  }
}
