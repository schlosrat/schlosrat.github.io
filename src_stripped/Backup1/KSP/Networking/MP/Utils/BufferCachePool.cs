// Decompiled with JetBrains decompiler
// Type: KSP.Networking.MP.Utils.BufferCachePool
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
