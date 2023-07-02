// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.BroadCircleMaskArea
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
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
