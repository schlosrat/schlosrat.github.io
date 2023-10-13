// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ISkyboxSpaceFrame
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Api;

namespace KSP.Sim
{
  public interface ISkyboxSpaceFrame
  {
    ITransformFrame ReferenceFrame { get; }

    Rotation SkyboxToRotation(QuaternionD physicsSpaceRotation);

    QuaternionD SkyboxToRotation(QuaternionD physicsSpaceRotation, ICoordinateSystem outputFrame);

    QuaternionD RotationToSkybox(Rotation rotation);

    QuaternionD RotationToSkybox(ICoordinateSystem referenceFrame, QuaternionD localRotation);
  }
}
