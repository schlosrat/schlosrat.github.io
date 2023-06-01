// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.BroadCircleMaskArea
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
