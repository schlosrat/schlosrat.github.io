// Decompiled with JetBrains decompiler
// Type: KSP.Sim.IPartModule
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
