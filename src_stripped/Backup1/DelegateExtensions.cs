﻿// Decompiled with JetBrains decompiler
// Type: DelegateExtensions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
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
