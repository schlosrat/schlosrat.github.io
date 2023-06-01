// Decompiled with JetBrains decompiler
// Type: UnityAsyncAwaitUtil.SyncContextUtil
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;

namespace UnityAsyncAwaitUtil
{
  public static class SyncContextUtil
  {
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void Install() => throw null;

    public static int UnityThreadId
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public static SynchronizationContext UnitySynchronizationContext
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }
  }
}
