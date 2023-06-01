// Decompiled with JetBrains decompiler
// Type: UtilScripts.PoolsStatus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UtilScripts
{
  public class PoolsStatus
  {
    public static readonly Dictionary<Type, PoolsStatus> poolsInfo;
    public int maxSize;
    public int allocated;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PoolsStatus() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static PoolsStatus() => throw null;
  }
}
