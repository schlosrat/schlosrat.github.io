// Decompiled with JetBrains decompiler
// Type: KSP.Sim.MathDP
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Api;
using System.Runtime.CompilerServices;

namespace KSP.Sim
{
  public static class MathDP
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Rotation FlipRotation(Rotation toFlip, Vector axis, double angleDeg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector Delta(Position end, Position start) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Position Move(Position lhs, Vector rhs) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector Minus(Vector lhs, Vector rhs) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector Scale(double scale, Vector vector) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double Magnitude(Vector vector) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double SqrMagnitude(Vector vector) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector CrossProduct(Vector lhs, Vector rhs) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double DotProduct(Vector lhs, Vector rhs) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector Normalize(Vector v) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double Angle(Vector lhs, Vector rhs) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector Hadamard(Vector lhs, Vector rhs) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector RotateVector(Rotation rotation, Vector vector) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Rotation LookRotation(Vector forward, Vector upwards) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Position AsPosition(ICoordinateSystem coordinateSystem, Vector3d point) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector AsVector(ICoordinateSystem coordinateSystem, Vector3d vector) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Rotation AsRotation(ICoordinateSystem coordinateSystem, QuaternionD quaternion) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Rotation AsRotation(ICoordinateSystem coordinateSystem, Vector3d eulerAngles) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Velocity AsVelocity(IMotion relativeTo, Vector relativeVelocity) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static AngularVelocity AsAngularVelocity(
      IMotion relativeTo,
      Vector relativeAngularVelocity)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double SignedPlanePointDistance(
      Vector planeNormal,
      Position planePoint,
      Position point)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Position ProjectPointToPlane(
      Vector planeNormal,
      Position planePoint,
      Position point)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ProjectPointToPlane(
      Vector planeNormal,
      Position planePoint,
      Position point,
      out double signedDistance,
      out Vector pointToPlaneOffset,
      out Position pointOnPlane)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector ProjectVectorToPlane(Vector planeNormal, Vector toProject) => throw null;
  }
}
