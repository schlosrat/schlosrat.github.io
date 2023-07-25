// Decompiled with JetBrains decompiler
// Type: KSP.Networking.MP.Utils.BufferCache
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Networking.MP.Utils
{
  public class BufferCache
  {
    public static readonly BufferCache Instance;
    private object _lockObject;
    private Dictionary<string, BufferCachePool> _bufferCachePoolDict;

    public object LockObject
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Buffer Acquire(string poolName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Release(Buffer buffer) => throw null;

    public static int NumFree
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static int NumUsed
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BufferCache() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    ~BufferCache() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Uninit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Flush() => throw null;

    public int NumFreeBuffers
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int NumUsedBuffers
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Buffer AcquireBuffer(string poolName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ReleaseBuffer(Buffer buffer) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BufferCacheReport GenerateBufferCacheReport() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static BufferCache() => throw null;
  }
}
