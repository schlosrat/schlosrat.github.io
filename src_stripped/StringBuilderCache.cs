// Decompiled with JetBrains decompiler
// Type: StringBuilderCache
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
