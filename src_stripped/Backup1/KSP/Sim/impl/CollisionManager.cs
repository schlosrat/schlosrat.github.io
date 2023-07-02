// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.CollisionManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim.impl
{
  public class CollisionManager : KerbalMonoBehaviour
  {
    public bool IsReady;
    public VesselBehavior Vessel;
    private bool _requireUpdate;
    private List<Collider> _tempColliderStorage;
    private List<CollisionManager.PartColliderList> _vesselPartsList;
    private bool _isCollisionsEnabled;
    public const string TAG_NO_SAME_VESSEL_COLLISION = "NoSameVesselCollision";

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetEnableCollisions(bool enableCollisions) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnCollisionIgnoreUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FixedUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private List<CollisionManager.PartColliderList> GetAllVesselColliders() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GetPartColliders(
      Transform tform,
      bool includeInactive,
      ref List<Collider> colliderList)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdatePartCollisionIgnores() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateCollisions(bool reset = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void IgnoreCollidersOnVessel(params Collider[] ignoreColliders) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void IgnoreCollidersOnVessel(List<Collider> ignoreColliders) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCollidersOnVessel(bool ignore, params Collider[] ignoreColliders) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCollidersOnVessel(bool ignore, List<Collider> ignoreColliders) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void IgnoreCollidersFromCollection(
      bool ignore,
      IReadOnlyList<Collider> ignoreColliders,
      IReadOnlyList<Collider> partColliders)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CollisionManager() => throw null;

    private class PartColliderList
    {
      public IGGuid Guid;
      public bool SameVesselCollision;
      public List<Collider> Colliders;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public PartColliderList(IGGuid guid, bool sameVslCollision) => throw null;
    }
  }
}
