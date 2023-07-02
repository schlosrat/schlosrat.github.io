// Decompiled with JetBrains decompiler
// Type: UtilScripts.ListPool`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
