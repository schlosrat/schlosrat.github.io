// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Hacks
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Sim.impl;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim
{
  public static class Hacks
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void CreateFXGroupFromPrefab<T>(
      ISimulationObjectView simObject,
      PartBehavior part,
      string fxGroupName,
      string fxPrefabName,
      Transform transform,
      Action<T> resultCallback)
      where T : FXGroup
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static FXGroup CreateFXGroupFromPrefab(GameObject prefabObject, Transform transform) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void AddParticleSystemsToGroup(GameObject prefab, FXGroup fxGroup) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static FXGroup CreateFXGroupFromPrefab(
      ISimulationObjectView simObject,
      PartBehavior part,
      string fxGroupName,
      GameObject prefabObject,
      Transform transform)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static GameObject InstantiatePrefab(GameObject prefabObject, Transform transform) => throw null;
  }
}
