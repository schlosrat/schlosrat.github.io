// Decompiled with JetBrains decompiler
// Type: KSP.Networking.MP.CollisionDetails
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
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
