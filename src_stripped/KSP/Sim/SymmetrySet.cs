// Decompiled with JetBrains decompiler
// Type: KSP.Sim.SymmetrySet
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
