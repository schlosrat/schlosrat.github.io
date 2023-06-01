// Decompiled with JetBrains decompiler
// Type: KSP.Sim.LegacySerializedVessel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim.Definitions;
using KSP.Sim.State;
using System;
using System.Collections.Generic;

namespace KSP.Sim
{
  [Obsolete("Please use SerializedAssembly instead")]
  public struct LegacySerializedVessel
  {
    public AssemblyDefinition vesselDefinition;
    public StagingState? stagingState;
    public PartOwnerState? partOwnerState;
    public IEnumerable<PartDefinitionContainer> partDefinitions;
  }
}
