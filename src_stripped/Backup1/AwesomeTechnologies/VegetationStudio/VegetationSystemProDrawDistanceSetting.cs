// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationStudio.VegetationSystemProDrawDistanceSetting
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace AwesomeTechnologies.VegetationStudio
{
  [Serializable]
  public struct VegetationSystemProDrawDistanceSetting
  {
    public int QualityLevelIndex;
    public string Name;
    public float GlobalDrawDistanceMultipler;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VegetationSystemProDrawDistanceSetting(int index, string name, float multiplier) => throw null;
  }
}
