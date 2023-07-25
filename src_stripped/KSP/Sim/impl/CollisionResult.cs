// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.CollisionResult
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
