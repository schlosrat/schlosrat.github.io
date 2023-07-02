// Decompiled with JetBrains decompiler
// Type: ObjectExtensions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

public static class ObjectExtensions
{
  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void Use<T>(this T @this, Action<T> action) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static T Apply<T>(this T @this, Action<T> action) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static R Let<T, R>(this T @this, Func<T, R> action) => throw null;
}
