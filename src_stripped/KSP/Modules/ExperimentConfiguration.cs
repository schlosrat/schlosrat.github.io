// Decompiled with JetBrains decompiler
// Type: KSP.Modules.ExperimentConfiguration
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Sim.Definitions;
using System;
using UnityEngine;

namespace KSP.Modules
{
  [Serializable]
  public struct ExperimentConfiguration
  {
    [Tooltip("The key to look the experiment up in the experiment storage. As defined in the json files in Assets\\Data\\ScienceExperimentDefinitions")]
    [SerializeField]
    public string ExperimentDefinitionID;
    [Tooltip("The amount of crew members needed to conduct the experiment.")]
    [SerializeField]
    public int CrewRequired;
    [Tooltip("The time that needs to pass in order for the experiment to finish.")]
    [SerializeField]
    public float TimeToComplete;
    [SerializeField]
    [Tooltip("The resource configuration of the experiemnt.")]
    public PartModuleResourceSetting ResourceCost;
    [Tooltip("The name of the animation.")]
    [SerializeField]
    public string AnimationName;
    [Tooltip("The id of the CFX this experiment uses.")]
    [SerializeField]
    public string CFXName;
    [Tooltip("The id of the sfx the experiment uses.")]
    [SerializeField]
    public string SFXName;
  }
}
