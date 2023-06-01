// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationSystem.EnvironmentSettings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
