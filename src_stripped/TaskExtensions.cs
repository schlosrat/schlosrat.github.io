// Decompiled with JetBrains decompiler
// Type: TaskExtensions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
