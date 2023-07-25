// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.BroadCircleMaskArea
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using AwesomeTechnologies.Vegetation;
using AwesomeTechnologies.VegetationSystem;
using System.Runtime.CompilerServices;
using Unity.Jobs;

namespace AwesomeTechnologies
{
  public class BroadCircleMaskArea : CircleMaskArea
  {
    public bool MaskGrass;
    public bool MaskPlants;
    public bool MaskTrees;
    public bool MaskObjects;
    public bool MaskLargeObjects;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public new void Init() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override JobHandle SampleMask(
      VegetationInstanceData instanceData,
      VegetationType vegetationType,
      JobHandle dependsOn)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BroadCircleMaskArea() => throw null;
  }
}
