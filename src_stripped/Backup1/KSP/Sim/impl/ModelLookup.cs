// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.ModelLookup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Sim.impl
{
  public class ModelLookup
  {
    public static readonly List<SimulationObjectModel> gEmptySimulationObjectModelList;
    public const byte MAX_PLAYER_COUNT = 1;
    private List<SimulationObjectModel> _allModels;
    private Dictionary<IGGuid, SimulationObjectModel> _globalIdDict;
    private Dictionary<string, SimulationObjectModel> _nameKeyDict;
    private Dictionary<ulong, SimulationObjectModel> _objectIdDict;
    private ModelLookup.PlayerEntry[] _playerEntryArray;

    public int NumModels
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public List<SimulationObjectModel> AllModels
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Dictionary<IGGuid, SimulationObjectModel> GlobalIdDict
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Dictionary<string, SimulationObjectModel> NameKeyDict
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Dictionary<ulong, SimulationObjectModel> ObjectIdDict
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ModelLookup.PlayerEntry[] PlayerEntryArray
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ModelLookup() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    ~ModelLookup() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Uninit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Empty() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool AddSimulationObject(SimulationObjectModel model) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool RemoveSimulationObject(SimulationObjectModel model) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ModelLookup.PlayerEntry FindPlayerEntry(byte playerId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerable<SimulationObjectModel> GetAllSimObjectsForPlayerId(byte playerId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool DoesGlobalIdExist(IGGuid globalId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool DoesGlobalNameKeyExist(string globalNameKey) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool DoesObjectIdExist(ulong objectId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SimulationObjectModel FindSimObject(IGGuid globalId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SimulationObjectModel FindSimObjectByNameKey(string globalNameKey) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SimulationObjectModel FindSimObjectByString(string simObjectId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SimulationObjectModel FindSimObjectByObjectId(ulong objectId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static ModelLookup() => throw null;

    public class PlayerEntry
    {
      private byte _playerId;
      private List<SimulationObjectModel> _playerModels;
      private Dictionary<IGGuid, SimulationObjectModel> _globalIdDict;
      private Dictionary<string, SimulationObjectModel> _nameKeyDict;
      private Dictionary<ulong, SimulationObjectModel> _objectIdDict;

      public byte PlayerId
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public int NumModels
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public List<SimulationObjectModel> PlayerModels
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public Dictionary<IGGuid, SimulationObjectModel> GlobalIdDict
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public Dictionary<string, SimulationObjectModel> NameKeyDict
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public Dictionary<ulong, SimulationObjectModel> ObjectIdDict
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public PlayerEntry(byte playerId) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      ~PlayerEntry() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Init(byte playerId) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Uninit() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Empty() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public bool AddSimulationObject(SimulationObjectModel model) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public bool RemoveSimulationObject(SimulationObjectModel model) => throw null;
    }
  }
}
