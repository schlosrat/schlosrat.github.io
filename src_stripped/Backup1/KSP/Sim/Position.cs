// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Position
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace KSP.Sim
{
  [DebuggerDisplay("{_Value_ForDebuggerOnly}")]
  public struct Position
  {
    public ICoordinateSystem coordinateSystem
    {
      [MethodImpl(MethodImplOptions.NoInlining)] readonly get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Vector3d localPosition
    {
      [MethodImpl(MethodImplOptions.NoInlining)] readonly get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Position(ICoordinateSystem coordinateSystem, Vector3d localPosition) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Reframe(ICoordinateSystem newcoordinateSystem) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Position Reframed(Position position, ICoordinateSystem newCoordinateSystem) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector Delta(Position end, Position start) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Position Move(Position start, Vector delta) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector operator -(Position p1, Position p2) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Position operator +(Position p, Vector v) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double Distance(Position p1, Position p2) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double DistanceSqr(Position p1, Position p2) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Position Lerp(Position from, Position to, double lerp) => throw null;
  }
}
