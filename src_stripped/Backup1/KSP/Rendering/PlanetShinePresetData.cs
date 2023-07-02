// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.PlanetShinePresetData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
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
