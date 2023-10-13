// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Data_ScienceExperiment
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Sim;
using KSP.Sim.Definitions;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Modules
{
  [Serializable]
  public sealed class Data_ScienceExperiment : ModuleData
  {
    [PAMDisplayControl(SortIndex = 5)]
    [LocalizedField("PartModules/ScienceExperiment/Location")]
    [KSPState(CopyToSymmetrySet = true)]
    public ModuleProperty<string> Location;
    [KSPDefinition]
    public List<ExperimentConfiguration> Experiments;

    public override Type ModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Data_ScienceExperiment() => throw null;
  }
}
