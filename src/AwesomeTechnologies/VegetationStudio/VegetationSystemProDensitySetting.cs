// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationStudio.VegetationSystemProDensitySetting
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace AwesomeTechnologies.VegetationStudio
{
  [Serializable]
  public struct VegetationSystemProDensitySetting
  {
    public int QualityLevelIndex;
    public string Name;
    public float GlobalDensityMultipler;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VegetationSystemProDensitySetting(int index, string name, float multiplier) => throw null;
  }
}
