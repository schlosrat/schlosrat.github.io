// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.CelestialBodyLensFlare
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
