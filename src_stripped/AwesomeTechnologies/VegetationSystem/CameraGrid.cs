// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationSystem.CameraGrid
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using AwesomeTechnologies.Utility.Culling;
using System.Collections.Generic;
using UnityEngine;

namespace AwesomeTechnologies.VegetationSystem
{
  public struct CameraGrid
  {
    public JobCullingGroup JobCullingGroup;
    public Vector3 PotentialCellsCenterPosition;
    public float PotentialCellPadding;
    public float LastCellDistance;
    public List<VegetationCell> PotentialVisibleCellList;
  }
}
