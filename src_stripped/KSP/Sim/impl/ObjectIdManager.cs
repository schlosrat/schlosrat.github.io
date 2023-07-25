// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.ObjectIdManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Sim.impl
{
  public class ObjectIdManager
  {
    public const int DEFAULT_GLOBAL_ARRAY_SIZE_INITIAL = 256;
    public const int DEFAULT_GLOBAL_ARRAY_SIZE_GROW = 128;
    public const int DEFAULT_PLAYER_ARRAY_SIZE_INITIAL = 64;
    public const int DEFAULT_PLAYER_ARRAY_SIZE_GROW = 64;
    public const int DEFAULT_MAX_PLAYERS = 0;
    private int _globalArraySizeInitial;
    private int _globalArraySizeGrow;
    private int _playerArraySizeInitial;
    private int _playerArraySizeGrow;
    private int _maxPlayers;
    private ObjectIdCollection[] _objectIdCollection;

    public int GlobalArraySizeInitial
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetGlobalArraySizeInitial(int globalArraySizeInitial) => throw null;

    public int GlobalArraySizeGrow
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetGlobalArraySizeGrow(int globalArraySizeGrow) => throw null;

    public int PlayerArraySizeInitial
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetPlayerArraySizeInitial(int playerArraySizeInitial) => throw null;

    public int PlayerArraySizeGrow
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetPlayerArraySizeGrow(int playerArraySizeGrow) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectIdManager(
      int globalArraySizeInitial,
      int globalArraySizeGrow,
      int playerArraySizeInitial,
      int playerArraySizeGrow,
      int maxPlayers)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    ~ObjectIdManager() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init(
      int globalArraySizeInitial,
      int globalArraySizeGrow,
      int playerArraySizeInitial,
      int playerArraySizeGrow,
      int maxPlayers)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Uninit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetupCollection(int maxPlayers) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void TeardownCollection() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectIdCollection FindObjectIdCollectionByPlayerId(byte playerId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectIdEntry FindObjectIdEntryByObjectId(ulong objectId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MarkAsAllocated(ulong objectId, bool allocated) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MarkAsAllocated(ulong objectId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MarkAsUnallocated(ulong objectId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ulong GenerateNewObjectId(byte playerId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ReturnObjectId(ulong objectId) => throw null;
  }
}
