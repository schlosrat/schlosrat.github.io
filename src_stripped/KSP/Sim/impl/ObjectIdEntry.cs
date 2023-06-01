// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.ObjectIdEntry
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Sim.impl
{
  public class ObjectIdEntry
  {
    public const ObjectIdCollection DEFAULT_OBJECT_ID_COLLECTION = null;
    public const ulong DEFAULT_OBJECT_ID = 0;
    public const bool DEFAULT_ALLOCATED = false;
    private ObjectIdCollection _objectIdCollection;
    private ulong _objectId;
    private bool _allocated;

    public ObjectIdCollection ObjectIdCollection
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetObjectIdCollection(ObjectIdCollection objectIdCollection) => throw null;

    public ulong ObjectId
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetObjectId(ulong objectId) => throw null;

    public bool Allocated
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAllocated(bool allocated) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectIdEntry() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectIdEntry(
      ObjectIdCollection objectIdCollection,
      ulong objectId,
      bool allocated,
      SimulationObjectModel simulationObjectModel)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init(ObjectIdCollection objectIdCollection, ulong objectId, bool allocated) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetAllValues() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Set(ObjectIdCollection objectIdCollection, ulong objectId, bool allocated) => throw null;
  }
}
