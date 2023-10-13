// Decompiled with JetBrains decompiler
// Type: StringBuilderCache
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
