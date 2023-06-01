// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.HandOfGodForces
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Sim.impl
{
  public class HandOfGodForces : IHandOfGodForces
  {
    private ISimulationModelMap simulationModelMap;
    private IModelViewMap modelViewMap;
    private Dictionary<string, HandOfGodForces.GodForce> hogForces;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public HandOfGodForces(ISimulationModelMap simulationModelMap, IModelViewMap modelViewMap) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool ApplyImpulse(
      string simulationObjectGuid,
      ForceType forceType,
      Vector3d relativeForce,
      Vector3d relativePosition)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string CreateForce(
      string forceInstanceGuid,
      string simulationObjectGuid,
      ForceType forceType,
      Vector3d? relativeForce,
      Vector3d? relativePosition,
      Vector3d? relativeTorque)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetForce(
      string forceInstanceGuid,
      Vector3d? relativeForce,
      Vector3d? relativeTorque)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DestroyForce(string forceInstanceGuid) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Debug_SetPhysicsMode(
      string instanceGuid,
      PhysicsMode vesselPhysics,
      bool enablePhysX,
      bool enablePartUnpack)
    {
      throw null;
    }

    public class GodForce : IForce, ITorque
    {
      public RigidbodyComponent rigidbody
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
        [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
      }

      public ForceType ForceMode
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
        [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
      }

      public ForceType TorqueMode
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
        [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
      }

      public Vector3d RelativeForce
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
        [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      }

      public Vector3d RelativePosition
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
        [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      }

      public Vector3d RelativeTorque
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
        [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public GodForce(
        RigidbodyComponent rigidbody,
        ForceType mode,
        Vector3d relativeForce,
        Vector3d relativePosition,
        Vector3d relativeTorque)
      {
        throw null;
      }
    }
  }
}
