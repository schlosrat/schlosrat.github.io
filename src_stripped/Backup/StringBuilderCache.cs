﻿// Decompiled with JetBrains decompiler
// Type: StringBuilderCache
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using System.Text;

public static class StringBuilderCache
{
  private const int MAX_BUILDER_SIZE = 360;
  [ThreadStatic]
  private static StringBuilder CachedInstance;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static StringBuilder Acquire(int capacity = 256) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void Release(this StringBuilder sb) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static string ToStringAndRelease(this StringBuilder sb) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static string Format(string format, params object[] args) => throw null;
}
