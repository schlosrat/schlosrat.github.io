// Decompiled with JetBrains decompiler
// Type: KSP.Sim.SymmetrySet
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim.Definitions;
using KSP.Sim.impl;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Sim
{
  public class SymmetrySet
  {
    private SymmetrySetData _data;
    private List<PartComponent> _parts;
    private bool _isSynching;

    public List<PartComponent> Parts
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public SymmetrySetData Data
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SymmetrySet(SymmetrySetData serializedData, PartOwnerComponent symmetryOwner = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void RemovePart(IGGuid globalId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void SyncData(PartComponent syncSource) => throw null;
  }
}
