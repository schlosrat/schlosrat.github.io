// Decompiled with JetBrains decompiler
// Type: KSP.Sim.IPartModule
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.Definitions;
using KSP.Sim.impl;

namespace KSP.Sim
{
  public interface IPartModule
  {
    ITransformModel transform { get; }

    VesselBehavior vessel { get; }

    PartBehavior part { get; set; }

    ISimulationObjectView simulationObject { get; set; }

    bool stagingEnabled { get; }

    bool moduleIsEnabled { get; }

    ModuleAction executedAction { get; set; }

    void Init();

    void OnActive();

    string GetModuleDisplayName();

    string GetInfo();

    bool IsStageable();
  }
}
