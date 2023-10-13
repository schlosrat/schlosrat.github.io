// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Vector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Api;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace KSP.Sim
{
  [DebuggerDisplay("{_Value_ForDebuggerOnly}")]
  public struct Vector
  {
    public ICoordinateSystem coordinateSystem
    {
      [MethodImpl(MethodImplOptions.NoInlining)] readonly get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Vector3d vector
    {
      [MethodImpl(MethodImplOptions.NoInlining)] readonly get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector(ICoordinateSystem coordinateSystem, Vector3d vector) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Reframe(ICoordinateSystem newCoordinateSystem) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector Reframed(Vector vector, ICoordinateSystem newcoordinateSystem) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector(Position end, Position start) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CopyFrom(Vector otherVector) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector operator *(Vector v1, double scale) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector operator +(Vector v1, Vector v2) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector operator -(Vector v1, Vector v2) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector plus(Vector v1, Vector v2) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector minus(Vector v1, Vector v2) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector normalize(Vector v1) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector scale(Vector v1, double scale) => throw null;

    public double magnitude
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double sqrMagnitude
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector negate(Vector v) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector cross(Vector v1, Vector v2) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double dot(Vector v1, Vector v2) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double getMagnitude(Vector vector) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double getSqrMagnitude(Vector vector) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector Lerp(Vector from, Vector to, double lerp) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector rotate(Vector input, Rotation rotation) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double Distance(Position from, Position to) => throw null;
  }
}
