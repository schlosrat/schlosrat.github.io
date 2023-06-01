// Decompiled with JetBrains decompiler
// Type: KSP.OAB.AssemblyOABConfig
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim.Definitions;
using KSP.Sim.impl;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.OAB
{
  [Serializable]
  public struct AssemblyOABConfig
  {
    public IGGuid RootGuid;
    public KSP.Sim.State.StagingState? StagingState;
    public List<KSP.Sim.PartRelationshipData> PartRelationshipData;
    public List<SymmetrySetData> SymmetrySets;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AssemblyOABConfig UpdateGuids(IGGuid oldGuid, IGGuid newGuid) => throw null;
  }
}
