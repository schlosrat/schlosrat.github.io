// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.PlanetShinePresetData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
