// Decompiled with JetBrains decompiler
// Type: KSP.Networking.MP.CollisionDetails
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Networking.MP
{
  public class CollisionDetails
  {
    public CollisionDetails.CollisionEventType CollisionEvent;
    public Guid SimulationObjectGuid;
    public Vector3 RelativeVelocity;
    public Vector3 ContactPoint;
    public Vector3 ContactNormal;
    public int CollisionLayer;
    public bool IsOceanImpact;
    public bool IsSurvivable;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CollisionDetails() => throw null;

    public enum CollisionEventType : byte
    {
      None,
      Enter,
      Exit,
      Stay,
    }
  }
}
