// Decompiled with JetBrains decompiler
// Type: KSP.Sim.IModelViewMap
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.impl;

namespace KSP.Sim
{
  public interface IModelViewMap
  {
    void Clear();

    SimulationObjectView FromModel(SimulationObjectModel ufoModel);

    void Bind(SimulationObjectModel model, SimulationObjectView view, bool allowRebind = true);

    void Unbind(SimulationObjectView view);
  }
}
