// Decompiled with JetBrains decompiler
// Type: KSP.Networking.MP.Utils.BufferCacheReportEntry
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Networking.MP.Utils
{
  public class BufferCacheReportEntry
  {
    public const string DEFAULT_POOL_NAME = "";
    public const int DEFAULT_BUFFERS_USED = 0;
    public const int DEFAULT_BUFFERS_FREE = 0;
    public const int DEFAULT_BUFFERS_TOTAL = 0;
    public const int DEFAULT_BYTES_USED = 0;
    public const int DEFAULT_BYTES_FREE = 0;
    public const int DEFAULT_BYTES_TOTAL = 0;
    public string PoolName;
    public int NumBuffersUsed;
    public int NumBuffersFree;
    public int NumBuffersTotal;
    public int NumBytesUsed;
    public int NumBytesFree;
    public int NumBytesTotal;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BufferCacheReportEntry() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetAllValues() => throw null;
  }
}
