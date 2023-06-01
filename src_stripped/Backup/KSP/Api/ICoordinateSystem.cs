// Decompiled with JetBrains decompiler
// Type: KSP.Api.ICoordinateSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim;

namespace KSP.Api
{
  public interface ICoordinateSystem
  {
    Vector forward { get; }

    Vector back { get; }

    Vector up { get; }

    Vector down { get; }

    Vector right { get; }

    Vector left { get; }

    Vector3d ToLocalPosition(Position position);

    Vector3d ToLocalPosition(ICoordinateSystem coordinateSystem, Vector3d coordinateSystemPosition);

    Vector3d ToLocalVector(Vector vector);

    Vector3d ToLocalVector(ICoordinateSystem coordinateSystem, Vector3d coordinateSystemVector);

    QuaternionD ToLocalRotation(Rotation rotation);

    QuaternionD ToLocalRotation(
      ICoordinateSystem coordinateSystem,
      QuaternionD coordinateSystemRotation);

    Matrix4x4D ToLocalTransformationMatrix(ICoordinateSystem coordinateSystem);
  }
}
