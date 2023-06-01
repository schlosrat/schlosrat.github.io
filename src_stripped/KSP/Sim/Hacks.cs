// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Hacks
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
