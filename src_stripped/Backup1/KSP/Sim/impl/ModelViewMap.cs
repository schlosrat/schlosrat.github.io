// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.ModelViewMap
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Sim.impl
{
  public class ModelViewMap : IModelViewMap
  {
    private readonly ModelViewBinding<SimulationObjectModel, SimulationObjectView> _simObjectToViewObjectMap;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Clear() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SimulationObjectModel FromView(SimulationObjectView viewObject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SimulationObjectView FromModel(SimulationObjectModel simObject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Bind(SimulationObjectModel model, SimulationObjectView view, bool allowRebind = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Unbind(SimulationObjectView view) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ModelViewMap() => throw null;
  }
}
