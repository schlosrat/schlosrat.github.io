// Decompiled with JetBrains decompiler
// Type: KSP.Game.Load.CreateCelestialBodiesFlowAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim;
using KSP.Sim.Definitions;
using KSP.Sim.impl;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Game.Load
{
  public class CreateCelestialBodiesFlowAction : SaveLoadGameFlowActionBase
  {
    private Action _resolve;
    private SerializedGalaxyDefinition _galaxy;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CreateCelestialBodiesFlowAction(LoadGameData data) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void DoAction(Action resolve, Action<string> reject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnGalaxyDefinitionLoaded(TextAsset asset) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetupNeighborhood(string bodyGUID, ITransformModel galacticOrigin) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool TryGetCelestialBodyPropertiesForGUID(
      string guid,
      out CelestialBodyProperties? result)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private List<SerializedPredefinedSimObject> OrderPredefinedSimObjects(
      List<SerializedPredefinedSimObject> predefinedSimObjects)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreatePredefinedSimObjects(
      CelestialBodyComponent cbComponent,
      List<SerializedPredefinedSimObject> predefinedSimObjects)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool AddPredefinedColonyComponents(
      SerializedPredefinedColonyObject predefinedColonyObject)
    {
      throw null;
    }

    private class SimObjectDependencyComparer : IComparer<SerializedPredefinedSimObject>
    {
      [MethodImpl(MethodImplOptions.NoInlining)]
      public int Compare(SerializedPredefinedSimObject x, SerializedPredefinedSimObject y) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public SimObjectDependencyComparer() => throw null;
    }
  }
}
