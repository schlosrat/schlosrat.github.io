// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.UpdatePhysicsVelocities
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using UnityEngine;

namespace KSP.Sim.impl
{
  public delegate void UpdatePhysicsVelocities(
    Vector3 oldVelocity,
    out Velocity newVelocity,
    Vector3 oldAngularVelocity,
    out AngularVelocity newAngularVelocity,
    Vector3 observerPosition);
}
