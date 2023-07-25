// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.UpdateRigidBody
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

namespace KSP.Sim.impl
{
  public delegate void UpdateRigidBody(
    Position oldPosition,
    out Position newPosition,
    Rotation oldRotation,
    out Rotation newRotation,
    Velocity oldVelocity,
    out Velocity newVelocity,
    AngularVelocity oldAngularVelocity,
    out AngularVelocity newAngularVelocity);
}
