// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationSystem.EnvironmentSettings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AwesomeTechnologies.VegetationSystem
{
  [Serializable]
  public class EnvironmentSettings
  {
    public float SnowAmount;
    public float SnowMinHeight;
    public float RainAmount;
    public Color SnowColor;
    public Color SnowSpecularColor;
    public Color BillboardSnowColor;
    public float SnowBlendFactor;
    public float SnowBrightness;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public EnvironmentSettings() => throw null;
  }
}
