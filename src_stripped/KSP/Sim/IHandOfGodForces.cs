// Decompiled with JetBrains decompiler
// Type: KSP.Sim.IHandOfGodForces
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

namespace KSP.Sim
{
  public interface IHandOfGodForces
  {
    bool ApplyImpulse(
      string simulationObjectGuid,
      ForceType forceType,
      Vector3d relativeForce,
      Vector3d relationPosition);

    string CreateForce(
      string forceInstanceGuid,
      string simulationObjectGuid,
      ForceType forceType,
      Vector3d? relativeForce,
      Vector3d? relationPosition,
      Vector3d? relativeTorque);

    void SetForce(string forceInstanceGuid, Vector3d? relativeForce, Vector3d? relativeTorque);

    void DestroyForce(string forceInstanceGuid);

    bool Debug_SetPhysicsMode(
      string instanceGuid,
      PhysicsMode vesselPhysics,
      bool enablePhysX,
      bool enablePartUnpack);
  }
}
