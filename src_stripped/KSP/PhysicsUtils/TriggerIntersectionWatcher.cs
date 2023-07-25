// Decompiled with JetBrains decompiler
// Type: KSP.PhysicsUtils.TriggerIntersectionWatcher
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.PhysicsUtils
{
  [RequireComponent(typeof (Collider))]
  public class TriggerIntersectionWatcher : MonoBehaviour
  {
    [LayerProperty]
    public int layer;
    private Collider colliderRef;
    private HashSet<Collider> activeColliders;
    private Dictionary<Collider, int> activeColliderLayers;

    public event TriggerIntersectionWatcher.OnTriggerChange TriggerEntered
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public event TriggerIntersectionWatcher.OnTriggerChange TriggerExited
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public event TriggerIntersectionWatcher.OnTriggerChange TriggerStayed
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetIntersectionResolutionOffset(out Vector3 offset, int layer = 0) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<TriggerIntersectionWatcher.CollisionInfo> GetActiveIntersections(int layer = 0) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnTriggerEnter(Collider other) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnTriggerExit(Collider other) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnTriggerStay(Collider other) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DoInvoke(TriggerIntersectionWatcher.OnTriggerChange handler, Collider other) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool GetCollisionInfo(Collider other, ref TriggerIntersectionWatcher.CollisionInfo info) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnDrawGizmos() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TriggerIntersectionWatcher() => throw null;

    public delegate void OnTriggerChange(Collider trigger, Collider other);

    public struct CollisionInfo
    {
      public Vector3 offset;
      public Collider collider;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public override string ToString() => throw null;
    }
  }
}
