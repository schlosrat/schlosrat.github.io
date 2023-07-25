// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ViewActions.IViewAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

namespace KSP.Sim.ViewActions
{
  public interface IViewAction
  {
    bool IsFinished { get; }

    bool ResolveDependencies(IModelViewMap modelViewMap);

    void Begin(IUniverseView universeView);

    void Update(double universalTime, double deltaTime);

    void FinalizeDependencies(IModelViewMap modelViewMap);
  }
}
