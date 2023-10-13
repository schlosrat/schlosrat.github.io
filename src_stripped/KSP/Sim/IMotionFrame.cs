// Decompiled with JetBrains decompiler
// Type: KSP.Sim.IMotionFrame
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Api;

namespace KSP.Sim
{
  public interface IMotionFrame : IMotion, IMotionRelative
  {
    TransformFrameType type { get; }

    ITransformFrame localFrame { get; }

    IMotionModel motion { get; }

    Vector relativeVelocity { get; }

    Vector relativeAngularVelocity { get; set; }

    IRigidbodyDriver atRestDriver(Position position, Rotation rotation);

    Vector3d ToLocalVelocity(Velocity otherVelocity, Position position);

    Vector3d ToLocalAngularVelocity(AngularVelocity angularVelocity);

    Vector3d ToLocalVelocity(IMotion relativeTo, Vector3d localVelocity, Position position);

    Vector3d ToLocalAngularVelocity(IMotion relativeTo, Vector3d localAngularVelocity);
  }
}
