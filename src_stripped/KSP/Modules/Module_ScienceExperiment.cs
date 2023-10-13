// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Module_ScienceExperiment
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Sim.Definitions;
using KSP.Sim.impl;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Modules
{
  [DisallowMultipleComponent]
  public class Module_ScienceExperiment : PartBehaviourModule
  {
    [SerializeField]
    protected Data_ScienceExperiment dataScienceExperiment;
    private KSPPartAudioManager _kspPartAudioManager;
    private VesselComponent _vesselComponent;
    private PartComponentModule_ScienceExperiment _scienceExperimentComponent;
    private ExperimentPAMItem[] _pamItems;

    public override System.Type PartComponentModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Module_ScienceExperiment() => throw null;
  }
}
