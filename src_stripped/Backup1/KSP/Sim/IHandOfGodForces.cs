// Decompiled with JetBrains decompiler
// Type: KSP.Sim.IHandOfGodForces
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
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
