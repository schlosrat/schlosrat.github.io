// Decompiled with JetBrains decompiler
// Type: TaskExtensions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

public static class TaskExtensions
{
  [MethodImpl(MethodImplOptions.NoInlining)]
  public static IEnumerator AsIEnumerator(this Task task) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static IEnumerator<T> AsIEnumerator<T>(this Task<T> task) where T : class => throw null;
}
