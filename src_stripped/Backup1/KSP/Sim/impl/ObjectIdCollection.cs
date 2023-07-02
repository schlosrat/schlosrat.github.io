// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.ObjectIdCollection
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Sim.impl
{
  public class ObjectIdCollection
  {
    public const ObjectIdManager DEFAULT_OBJECT_ID_MANAGER = null;
    public const byte DEFAULT_PLAYER_ID = 0;
    public const int DEFAULT_ARRAY_SIZE_INITIALIZE = 1;
    public const int DEFAULT_ARRAY_SIZE_GROW = 1;
    private ObjectIdManager _objectIdManager;
    private byte _playerId;
    private int _arraySizeInitial;
    private int _arraySizeGrow;
    private ObjectIdEntry[] _objectIdEntryArray;

    public ObjectIdManager ObjectIdManager
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public byte PlayerId
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int ArraySizeInitial
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int ArraySizeGrow
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectIdCollection(
      ObjectIdManager objectIdManager,
      byte playerId,
      int arraySizeInitial,
      int arraySizeGrow)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init(
      ObjectIdManager objectIdManager,
      byte playerId,
      int arraySizeInitial,
      int arraySizeGrow)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Uninit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetupArray(int numItems) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void TeardownArray() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GrowArray() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ulong FindNextAvailableIndex() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectIdEntry FindObjectIdEntryByPartId(ulong partId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectIdEntry FindObjectIdEntryByPartIndex(ulong partIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ulong GenerateNewObjectId() => throw null;
  }
}
