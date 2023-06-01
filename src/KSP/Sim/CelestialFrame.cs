// Decompiled with JetBrains decompiler
// Type: KSP.Sim.CelestialFrame
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
