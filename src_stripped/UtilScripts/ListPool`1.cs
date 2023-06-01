// Decompiled with JetBrains decompiler
// Type: UtilScripts.ListPool`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UtilScripts
{
  public static class ListPool<T>
  {
    private static readonly Pool<List<T>> _Instance;

    public static Pool<List<T>> Instance
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    static ListPool() => throw null;
  }
}
