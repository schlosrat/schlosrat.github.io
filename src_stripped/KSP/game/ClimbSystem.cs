// Decompiled with JetBrains decompiler
// Type: KSP.Game.ClimbSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim;
using KSP.Sim.impl;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Game
{
  public class ClimbSystem : SpatialRegistrySystem
  {
    private ClimbFlags _playerFlags;
    private Position _playerPosition;
    private Vector3 _instancePosition;
    private float _climbDistance;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<ClimbInstance> GetNeighboringClimbInstances(float range) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<ClimbInstance> GetNeighboringClimbInstances(float range, VesselComponent vessel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ClimbSystem() => throw null;
  }
}
