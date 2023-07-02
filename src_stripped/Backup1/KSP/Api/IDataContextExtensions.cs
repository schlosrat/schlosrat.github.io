// Decompiled with JetBrains decompiler
// Type: KSP.Api.IDataContextExtensions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.Generic;
using KSP.UI.Binding.Core;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Api
{
  public static class IDataContextExtensions
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IEnumerable<KeyValuePair<string, IProperty>> GetAllProperties(
      this IDataContextReadonly context)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IEnumerable<KeyValuePair<string, IPropertyWritable>> GetAllPropertiesWritable(
      this IDataContextReadonly context)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IEnumerable<KeyValuePair<string, IProperty<T>>> GetAllProperties<T>(
      this IDataContextReadonly context)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IEnumerable<KeyValuePair<string, IPropertyWritable<T>>> GetAllPropertiesWritable<T>(
      this IDataContextReadonly context)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool TryResolveProperty<T>(
      this IDataContextReadonly context,
      string keyPath,
      out IProperty<T> property,
      bool searchStack = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IProperty ResolveProperty(
      this IDataContextReadonly context,
      string keyPath,
      bool searchStack = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IProperty<T> ResolveProperty<T>(
      this IDataContextReadonly context,
      string keyPath,
      bool searchStack = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool TryResolvePropertyWritable(
      this IDataContextReadonly context,
      string keyPath,
      out IPropertyWritable property,
      bool searchStack = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool TryResolvePropertyWritable<T>(
      this IDataContextReadonly context,
      string keyPath,
      out IPropertyWritable<T> property,
      bool searchStack = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool TryWriteProperty<T>(
      this IDataContextReadonly context,
      string keyPath,
      T newValue,
      bool attemptToConvert = false)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IPropertyWritable ResolvePropertyWritable(
      this IDataContextReadonly context,
      string keyPath,
      bool searchStack = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IPropertyWritable<T> ResolvePropertyWritable<T>(
      this IDataContextReadonly context,
      string keyPath,
      bool searchStack = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IAction ResolveAction(
      this IDataContextReadonly context,
      string keyPath,
      bool searchStack = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IContextListProperty ResolveList(
      this IDataContextReadonly context,
      string keyPath,
      bool searchStack = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IDataContextReadonly ResolveSubContext(
      this IDataContextReadonly context,
      string keyPath,
      bool searchStack = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static UIValueNumberRange ResolveNumberRange(
      this IDataContextReadonly context,
      string keyPath,
      bool searchStack = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string ResolveLabel(
      this IDataContextReadonly context,
      string keyPath,
      bool searchStack = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void CopyFrom(
      this IDataContextWritable @this,
      IDataContextReadonly context,
      bool searchStack = false)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IAction AddAction(this IDataContextWritable @this, string key, Delegate action) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IAction AddAction(this IDataContextWritable @this, string key, Action action) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void AddPropertyWithRange(
      this IDataContextWritable @this,
      string key,
      IProperty property,
      UIValueNumberRange numberRange)
    {
      throw null;
    }
  }
}
