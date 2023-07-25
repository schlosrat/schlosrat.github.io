// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.OverrideLightingData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Rendering
{
  [Serializable]
  public class OverrideLightingData
  {
    public string name;
    public bool enabled;
    public SphericalGaussianSettings sphericalGaussianSettings;
    public float intensityAtPeriapsis;
    public float intensityAtApoapsis;
    public Color color;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OverrideLightingData() => throw null;
  }
}
