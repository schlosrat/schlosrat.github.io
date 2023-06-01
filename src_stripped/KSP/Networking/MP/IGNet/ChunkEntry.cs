// Decompiled with JetBrains decompiler
// Type: KSP.Networking.MP.IGNet.ChunkEntry
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
