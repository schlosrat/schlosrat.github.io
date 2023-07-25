// Decompiled with JetBrains decompiler
// Type: KSP.Networking.MP.CollisionDetails
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
