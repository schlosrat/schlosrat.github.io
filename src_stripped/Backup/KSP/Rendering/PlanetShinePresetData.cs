// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.PlanetShinePresetData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using UnityEngine;

namespace KSP.Rendering
{
  [Serializable]
  public struct PlanetShinePresetData
  {
    public Color color;
    public float intensityAtPeriapsis;
    public float intensityAtApoapsis;
    public float altitudeToStartFadingOut;
    public float altitudeToFinishFadingOut;
    public AnimationCurve falloffCurve;
    public double falloffDistance;
    public Flare flare;
    public double lensFlareFalloff;
    public AnimationCurve lensFlareHorizonCurve;
  }
}
