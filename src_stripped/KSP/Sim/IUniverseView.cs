// Decompiled with JetBrains decompiler
// Type: KSP.Sim.IUniverseView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Sim.impl;
using KSP.Sim.ViewActions;
using KSP.Utilities;
using UnityEngine;

namespace KSP.Sim
{
  public interface IUniverseView
  {
    IUniverseObserver FlightObserver { get; set; }

    UniverseTime UniverseTime { get; }

    float PhysicsDeltaTime { get; }

    UniverseModel Model { get; }

    IScaledSpaceProvider ScaledSpace { get; }

    IPhysicsSpaceProvider PhysicsSpace { get; }

    IInternalSpaceProvider InternalSpace { get; }

    CelestialBodyAssetLoader AssetLoader { get; }

    Transform CelestialTransform { get; }

    Transform ScaledSpaceTransform { get; }

    Transform PhysicsSpaceTransform { get; }

    Transform InternalSpaceTransform { get; }

    Transform PhysXReferenceTransform { get; }

    Transform PhysXCounterRotatingTransform { get; }

    CelestialUtilities CelestialUtilities { get; }

    IViewActionQueue ViewActionQueue { get; }

    void Destroy();
  }
}
