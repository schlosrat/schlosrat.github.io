// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.CollisionResult
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim.impl
{
  public struct CollisionResult
  {
    private static readonly CollisionResult _emptyCollision;
    [HideInInspector]
    public Rigidbody ContactRigidbody;
    [HideInInspector]
    public Vector3 ContactPosition;
    [HideInInspector]
    public Vector3 ContactNormal;
    [HideInInspector]
    public bool HasRigidbody;
    [HideInInspector]
    public bool HasContact;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CollisionResult(
      Rigidbody contactRigidbody,
      Vector3 contactPosition,
      Vector3 contactNormal,
      bool hasContact)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static CollisionResult BuildCollisionResult(
      RaycastHit raycastHit,
      Rigidbody ignoreRigidbody)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    static CollisionResult() => throw null;
  }
}
