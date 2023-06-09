﻿// Decompiled with JetBrains decompiler
// Type: KSP.Game.ClimbSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
