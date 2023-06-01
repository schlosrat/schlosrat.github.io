// Decompiled with JetBrains decompiler
// Type: KSP.Api.IContextListPropertyExtensions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Api.Generic;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Api
{
  public static class IContextListPropertyExtensions
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void GetElementPropertyObjects(
      this IContextListProperty list,
      string key,
      ICollection<object> target,
      bool searchStack = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void GetElementPropertyValues<T>(
      this IContextListProperty list,
      string key,
      ICollection<T> target,
      bool searchStack = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void GetElementProperties<T>(
      this IContextListProperty list,
      string key,
      ICollection<IPropertyWritable> target,
      bool searchStack = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void GetElementProperties<T>(
      this IContextListProperty list,
      string key,
      ICollection<IPropertyWritable<T>> target,
      bool searchStack = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void GetElementProperties(
      this IContextListProperty list,
      string key,
      ICollection<IProperty> target,
      bool searchStack = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void GetElementProperties<T>(
      this IContextListProperty list,
      string key,
      ICollection<IProperty<T>> target,
      bool searchStack = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void GetElementActions(
      this IContextListProperty list,
      string key,
      ICollection<IAction> target,
      bool searchStack = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void GetElementSubContexts(
      this IContextListProperty list,
      string key,
      ICollection<IDataContextReadonly> target,
      bool searchStack = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void GetElementList(
      this IContextListProperty list,
      string key,
      ICollection<IContextListProperty> target,
      bool searchStack = true)
    {
      throw null;
    }
  }
}
