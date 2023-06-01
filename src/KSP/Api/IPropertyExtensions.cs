// Decompiled with JetBrains decompiler
// Type: KSP.Api.IPropertyExtensions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Api.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Api
{
  public static class IPropertyExtensions
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IPropertyWritable<T> Cast<T>(this IPropertyWritable prop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IProperty<T> Cast<T>(this IProperty prop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static T CastGetValue<T>(this IProperty prop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool CastSetValue<T>(this IPropertyWritable prop, T newValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IPropertyWritable<T> CastWritable<T>(this IProperty prop) => throw null;
  }
}
