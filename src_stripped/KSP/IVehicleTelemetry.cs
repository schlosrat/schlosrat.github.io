// Decompiled with JetBrains decompiler
// Type: KSP.IVehicleTelemetry
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
