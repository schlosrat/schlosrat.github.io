// Decompiled with JetBrains decompiler
// Type: KSP.IVehicleTelemetry
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim;

namespace KSP
{
  public interface IVehicleTelemetry
  {
    ITransformFrame ObservationFrame { get; }

    Vector ObservationForward { get; }

    Rotation GetNavballRotationForForward(Vector viewerForward);

    Vector TargetVelocity { get; }

    double TargetSpeed { get; }

    double SpecificAcceleration { get; }

    AngularVelocity AngularVelocity { get; }

    Position Position { get; }

    Position CenterOfMass { get; }

    Vector MomentOfInertia { get; }

    Vector AngularMomentum { get; }

    Rotation Rotation { get; }

    Velocity Velocity { get; }

    double Heading { get; }

    Vector GetDisplayVelocityVector();

    double GetDisplayAltitude();
  }
}
