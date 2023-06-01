// Decompiled with JetBrains decompiler
// Type: KSP.Networking.MP.Utils.BufferCachePool
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Networking.MP.Utils
{
  public class BufferCachePool
  {
    public BufferCache BufferCache;
    public string PoolName;
    public List<Buffer> UsedList;
    public List<Buffer> FreeList;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BufferCachePool(BufferCache bufferCache, string poolName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ReleaseBuffer(Buffer buffer) => throw null;
  }
}
