// Decompiled with JetBrains decompiler
// Type: KSP.OAB.AssemblyOABConfig
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
