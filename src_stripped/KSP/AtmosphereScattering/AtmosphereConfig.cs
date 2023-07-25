// Decompiled with JetBrains decompiler
// Type: KSP.AtmosphereScattering.AtmosphereConfig
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.AtmosphereScattering
{
  [CreateAssetMenu]
  public class AtmosphereConfig : ScriptableObject
  {
    private static readonly Vector3 OZoneConst;
    private static readonly Vector3 RayleighScatteringConst;
    private static readonly float MieScatteringConst;
    public float atmosphereDensity;
    public Vector3 sunIrradianceOnAtmosphere;
    public float LightingScale;
    public float atmosphere_top_radius;
    public float atmosphere_bot_radius;
    public float atmosphere_sun_angular_radius;
    public float rayleigh_scattering;
    public float rayleigh_scale_height;
    public float mie_scattering;
    public float mie_scale_height;
    public float mie_phase_function_g;
    public float ozone_extinction;
    public float ozone_scale_height;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Apply(Material mat) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Apply(ComputeShader shader) => throw null;

    public Vector3 rayleigh_scattering_spectrum
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 ozone_extinction_spectrum
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float mie_extinction
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float mie_extinction_spectrum
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CopyDataFrom(AtmosphereConfig config) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AtmosphereConfig() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static AtmosphereConfig() => throw null;

    private static class Keys
    {
      public static int atmosphere_top_radius;
      public static int atmosphere_bot_radius;
      public static int atmosphere_sun_angular_radius;
      public static int rayleigh_scattering;
      public static int rayleigh_scale_height;
      public static int mie_scattering;
      public static int mie_extinction;
      public static int mie_scale_height;
      public static int mie_phase_function_g;
      public static int absorption_extinction;
      public static int absorption_extinction_scale_height;
      public static int lightingScale;
      public static int sunIrradianceOnAtm;

      [MethodImpl(MethodImplOptions.NoInlining)]
      static Keys() => throw null;
    }
  }
}
