// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.CelestialBodyLensFlare
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Rendering
{
  [DisallowMultipleComponent]
  public class CelestialBodyLensFlare : MonoBehaviour
  {
    public ProFlare flare;
    public double flightFalloffDistance;
    public double mapFalloffDistance;
    public AnimationCurve flareFalloffCurve;
    public double emissionNearRange;
    public double emissionFarRange;
    public bool flightFlareEnabled;
    public float flightMinScale;
    public float flightMaxScale;
    public double flightAlphaMinRange;
    public double flightAlphaMaxRange;
    public bool mapFlareEnabled;
    public float mapMaxScale;
    public float mapMinScale;
    public double mapAlphaMinRange;
    public double mapAlphaMaxRange;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CelestialBodyLensFlare() => throw null;
  }
}
