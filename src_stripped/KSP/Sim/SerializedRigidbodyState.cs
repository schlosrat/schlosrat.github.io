// Decompiled with JetBrains decompiler
// Type: KSP.Sim.SerializedRigidbodyState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

namespace KSP.Sim
{
  public struct SerializedRigidbodyState
  {
    public string referenceTransformGuid;
    public TransformFrameType referenceFrameType;
    public Vector3d localVelocity;
    public Vector3d localAngularVelocity;
    public Vector3d localPosition;
    public QuaternionD localRotation;
    public PhysicsMode PhysicsMode;
  }
}
