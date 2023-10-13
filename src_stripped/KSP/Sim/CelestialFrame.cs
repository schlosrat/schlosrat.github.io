// Decompiled with JetBrains decompiler
// Type: KSP.Sim.CelestialFrame
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Runtime.CompilerServices;

namespace KSP.Sim
{
  public struct CelestialFrame
  {
    public Vector3d X;
    public Vector3d Y;
    public Vector3d Z;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d WorldToLocal(Vector3d r) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d LocalToWorld(Vector3d r) => throw null;

    public QuaternionD Rotation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void SetFrame(double A, double B, double C, ref CelestialFrame cf) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void OrbitalFrame(double LAN, double Inc, double ArgPe, ref CelestialFrame cf) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void PlanetaryFrame(double ra, double dec, double rot, ref CelestialFrame cf) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void RotateFrame(QuaternionD rotation, ref CelestialFrame cf) => throw null;
  }
}
