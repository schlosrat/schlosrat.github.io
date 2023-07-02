// Decompiled with JetBrains decompiler
// Type: CelestialBodyRingSimHelper
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Rendering;
using KSP.Sim;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CelestialBodyRingSimHelper
{
  private IPhysicsSpaceProvider PhysicsSpace;
  private IScaledSpaceProvider ScaledSpace;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public CelestialBodyRingSimHelper(
    IPhysicsSpaceProvider physicsSpace,
    IScaledSpaceProvider scaledSpace)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public Plane CreateRingPlanePhysics(CelestialBodyRing ring) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void UpdateRingPlanePhysics(CelestialBodyRing ring, out Vector3 position) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool PositionInRingBounds(
    CelestialBodyRing ring,
    Position pos,
    float verticalBound,
    out Vector3 ringPosPhysics,
    out Vector3 closestPosPhysics)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool PositionInRingBoundsHorizontal(
    Vector3 pos,
    Vector3 ringPos,
    float inner,
    float outer)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool PositionInRingBoundsVertical(Vector3 pos, Vector3 closestPos, float range) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public float PositionBlendInRingBounds(
    CelestialBodyRing ring,
    Position pos,
    float horizontalPadding,
    float verticalPadding)
  {
    throw null;
  }
}
