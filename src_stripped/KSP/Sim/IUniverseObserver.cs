// Decompiled with JetBrains decompiler
// Type: KSP.Sim.IUniverseObserver
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.impl;

namespace KSP.Sim
{
  public interface IUniverseObserver
  {
    ITransformFrame ObservationFrame { get; }

    Position Position { get; }

    Velocity Velocity { get; }

    CelestialBodyComponent ReferenceBody { get; }

    SimulationObjectModel ObservingSimObj { get; }

    ITransformFrame SimObjectParentFrame { get; }

    ITransformFrame SimSOIBodyParentFrame { get; }

    double GetSquaredDistanceTo(Position targetPosition);

    void ObserveSimTransformFrame(ITransformFrame frame);

    void ObserveSimTransformModel(ITransformModel transformModel);

    void ObserveSimObject(IGGuid simObjectGuid);

    void ObserveSimObject(SimulationObjectModel simObj);

    void UpdateReferenceBody();

    void Cleanup();
  }
}
