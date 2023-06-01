// Decompiled with JetBrains decompiler
// Type: KSP.Networking.MP.IGNet.ChunkList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Networking.MP.Serialize;
using KSP.Networking.MP.Utils;
using System.Collections.Generic;
using System.Net;
using System.Runtime.CompilerServices;

namespace KSP.Networking.MP.IGNet
{
  public class ChunkList : IMPSyncable
  {
    public const string TOKEN_STRING_SEPERATOR = ";";
    public const string TOKEN_STRING_EQUALS = "=";
    public const string TOKEN_STRING_SEPERATOR_ESCAPED = "%3B";
    public const string TOKEN_STRING_EQUALS_ESCAPED = "%3D";
    private List<ChunkEntry> _chunkEntryList;

    public int NumEntries
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ChunkList() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ChunkList(ChunkList src) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ChunkList(string uberString) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init(ChunkList src) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init(string uberString) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Uninit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Empty() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(ChunkList src) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Set(ChunkList src) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ChunkEntry FindChunkEntryByIndex(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ChunkEntry FindChunkEntryByChunkName(string chunkName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ChunkEntry Set(string chunkName, string chunkValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ChunkEntry Set<T>(string chunkName, T chunkValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Exist(string chunkName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Remove(string chunkName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool ExtractString(string chunkName, out string chunkValueRef, string defaultChunkValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool ExtractValue<T>(
      string chunkName,
      out T chunkValueRef,
      T defaultChunkValue,
      ChunkList.ParseCB<T> parseCB)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool ExtractInt32(string chunkName, out int chunkValueRef, int defaultChunkValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool ExtractUInt32(string chunkName, out uint chunkValueRef, uint defaultChunkValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool ExtractInt64(string chunkName, out long chunkValueRef, long defaultChunkValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool ExtractUInt64(string chunkName, out ulong chunkValueRef, ulong defaultChunkValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool ExtractByte(string chunkName, out byte chunkValueRef, byte defaultChunkValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool ExtractBool(string chunkName, out bool chunkValueRef, bool defaultChunkValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool ExtractEnum<T>(string chunkName, out T chunkValueRef, T defaultChunkValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool ExtractFloat(string chunkName, out float chunkValueRef, float defaultChunkValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool ExtractDouble(string chunkName, out double chunkValueRef, double defaultChunkValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool ExtractIPEndPoint(
      string chunkName,
      out IPEndPoint chunkValueRef,
      IPEndPoint defaultChunkValue)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetString(string chunkName, string defaultChunkValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public T GetValue<T>(string chunkName, T defaultChunkValue, ChunkList.ParseCB<T> parseCB) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetInt32(string chunkName, int defaultChunkValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public uint GetUInt32(string chunkName, uint defaultChunkValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public long GetInt64(string chunkName, long defaultChunkValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ulong GetUInt64(string chunkName, ulong defaultChunkValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public byte GetByte(string chunkName, byte defaultChunkValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool GetBool(string chunkName, bool defaultChunkValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public T GetEnum<T>(string chunkName, T defaultChunkValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IPEndPoint GetIPEndPoint(string chunkName, IPEndPoint defaultChunkValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MPSync(IMPSerializer mpSerializer) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool WriteBinaryDataToBuffer(Buffer writer) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool ReadBinaryDataFromBuffer(Buffer reader) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string EscapeString(string rawText) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string UnescapeString(string escapedText) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string ExportUberString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ImportUberString(string uberString) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetDebugString(bool abbrev) => throw null;

    public delegate T ParseCB<T>(string str);
  }
}
