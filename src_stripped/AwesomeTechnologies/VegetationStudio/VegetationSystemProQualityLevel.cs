// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationStudio.VegetationSystemProQualityLevel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using AwesomeTechnologies.VegetationSystem;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace AwesomeTechnologies.VegetationStudio
{
  [Serializable]
  public class VegetationSystemProQualityLevel
  {
    public int QualityLevelIndex;
    public string Name;
    public float GrassDensity;
    public float PlantDensity;
    public float TreeDensity;
    public float ObjectDensity;
    public float MediumObjectDensity;
    public float LargeObjectDensity;
    public float PlantDistance;
    public float AdditionalTreeMeshDistance;
    public float AdditionalBillboardDistance;
    public bool GrassShadows;
    public bool PlantShadows;
    public bool TreeShadows;
    public bool ObjectShadows;
    public bool MediumObjectShadows;
    public bool LargeObjectShadows;
    public bool BillboardShadows;
    public List<VegetationPackagePro> VegetationPackageProList;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VegetationSystemProQualityLevel() => throw null;
  }
}
