// Decompiled with JetBrains decompiler
// Type: KSP.Networking.MP.Utils.BufferCacheReport
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Networking.MP.Utils
{
  public class BufferCacheReport
  {
    public const int DEFAULT_NUM_POOLS = 0;
    public const int DEFAULT_BUFFERS_USED = 0;
    public const int DEFAULT_BUFFERS_FREE = 0;
    public const int DEFAULT_BUFFERS_TOTAL = 0;
    public const int DEFAULT_BYTES_USED = 0;
    public const int DEFAULT_BYTES_FREE = 0;
    public const int DEFAULT_BYTES_TOTAL = 0;
    public int NumPools;
    public int NumBuffersUsed;
    public int NumBuffersFree;
    public int NumBuffersTotal;
    public int NumBytesUsed;
    public int NumBytesFree;
    public int NumBytesTotal;
    public readonly List<BufferCacheReportEntry> ReportEntryList;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BufferCacheReport() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetAllValues() => throw null;
  }
}
