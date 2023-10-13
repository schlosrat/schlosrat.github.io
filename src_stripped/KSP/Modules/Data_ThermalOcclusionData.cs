// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Data_ThermalOcclusionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Sim;
using KSP.Sim.Definitions;
using System;
using System.Runtime.CompilerServices;

namespace KSP.Modules
{
  [Serializable]
  public sealed class Data_ThermalOcclusionData : ModuleData
  {
    [KSPState(CopyToSymmetrySet = true)]
    [LocalizedField("Show Occlusion Data")]
    public ModuleProperty<bool> ShowOcclusionData;
    [KSPState(CopyToSymmetrySet = true)]
    [LocalizedField("Reentry Flux")]
    public ModuleProperty<float> ReentryFlux;
    [KSPState(CopyToSymmetrySet = true)]
    [LocalizedField("Exposed area percentage")]
    public ModuleProperty<float> ExposedAreaPercentage;

    public override Type ModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static string GetReentryFlux(object value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static string GetExposedAreaProp(object value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Data_ThermalOcclusionData() => throw null;
  }
}
