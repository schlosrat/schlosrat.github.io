// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.CrewMemberBehavior
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim.impl
{
  public class CrewMemberBehavior : ViewObjectComponent<CrewMemberComponent>, IPhysicsDebuggable
  {
    private IModelViewMap modelViewMap;
    private GameObject instance;
    private RigidbodyBehavior _rigidBody;

    public System.Type ModelType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private RigidbodyBehavior rigidBody
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Destroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void SyncTo(CrewMemberComponent simObjectComponent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyPhysics(PhysicsMode physics) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void BeginEva() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void EndEva() => throw null;

    public CrewMemberComponent Model
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public VesselBehavior InVessel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void IVADisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void IVAEnable() => throw null;

    public Transform eyeTransform
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool inactive
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [ContextMenu("PhysX RigidBody")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void startViewPhysX() => throw null;

    [ContextMenu("Model RigidBody")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void stopPhysXPhysX() => throw null;

    [ContextMenu("Model Orbital")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void orbital() => throw null;

    [ContextMenu("At Rest")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void atRest() => throw null;

    private Transform AtRestParent
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Debug_SetPhysicsMode(
      PhysicsMode vesselPhysics,
      bool isPhysXEnabled,
      bool isUnpacked = false)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CrewMemberBehavior() => throw null;
  }
}
