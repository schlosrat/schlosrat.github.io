// Decompiled with JetBrains decompiler
// Type: KSP.Networking.MP.IGNet.ChunkEntry
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Networking.MP.Serialize;
using System.Runtime.CompilerServices;

namespace KSP.Networking.MP.IGNet
{
  public class ChunkEntry : IMPSyncable
  {
    public const string DEFAULT_CHUNK_NAME = "";
    public const string DEFAULT_CHUNK_VALUE = "";
    private string _chunkName;
    private string _chunkValue;

    public string ChunkName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetChunkName(string chunkName) => throw null;

    public string ChunkValue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetChunkValue(string chunkValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ChunkEntry() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ChunkEntry(ChunkEntry src) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ChunkEntry(string chunkName, string chunkValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init(ChunkEntry src) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init(string chunkName, string chunkValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Uninit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetAllValues() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Set(ChunkEntry src) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Set(string chunkName, string chunkValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MPSync(IMPSerializer mpSerializer) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetDebugString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToString() => throw null;
  }
}
