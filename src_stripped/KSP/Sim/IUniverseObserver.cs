// Decompiled with JetBrains decompiler
// Type: KSP.Sim.IUniverseObserver
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
