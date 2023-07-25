// Decompiled with JetBrains decompiler
// Type: DelegateExtensions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

public static class DelegateExtensions
{
  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void Clear<T>(this Func<T> f, T defaultValue) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void Clear<T, R>(this Func<T, R> f, R defaultValue) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void Clear<T, U, R>(this Func<T, U, R> f, R defaultValue) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void Clear<T, U, V, R>(this Func<T, U, V, R> f, R defaultValue) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void Clear<T, U, V, W, R>(this Func<T, U, V, W, R> f, R defaultValue) => throw null;
}
