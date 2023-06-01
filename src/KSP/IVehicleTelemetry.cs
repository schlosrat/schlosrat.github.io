// Decompiled with JetBrains decompiler
// Type: KSP.IVehicleTelemetry
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
