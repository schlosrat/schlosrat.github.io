// Decompiled with JetBrains decompiler
// Type: TaskExtensions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
