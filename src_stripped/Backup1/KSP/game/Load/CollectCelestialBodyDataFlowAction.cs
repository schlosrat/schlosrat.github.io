// Decompiled with JetBrains decompiler
// Type: KSP.Game.Load.CollectCelestialBodyDataFlowAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim;
using KSP.Sim.impl;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Game.Load
{
  [Obsolete("THis action should not be used in its current state as the CB data is held in a GalaxyDefinition Addressable", true)]
  public class CollectCelestialBodyDataFlowAction : SaveLoadGameFlowActionBase
  {
    public List<SerializedCelestialBody> CelestialBodies;
    private LoadGameData _gameData;

    public GameInstance Game
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CollectCelestialBodyDataFlowAction(LoadGameData data) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void DoAction(Action resolve, Action<string> reject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CollectCelestialBodyComponents() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private SerializedOrbitProperties OrbitFromComponent(CelestialBodyComponent bodyComp) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private SerializedOribiterDefinition OrbiterFromComponent(CelestialBodyComponent bodyComp) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SerializedCelestialBody CelestialBodyToSerializable(
      SimulationObjectModel objectModel,
      bool isAutosave)
    {
      throw null;
    }
  }
}
