// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationMaskArea
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using AwesomeTechnologies.Utility;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AwesomeTechnologies
{
  [ExecuteInEditMode]
  [AwesomeTechnologiesScriptOrder(99)]
  [HelpURL("http://www.awesometech.no/index.php/home/vegetation-studio/components/vegetation-masks/vegetation-mask-area")]
  public class VegetationMaskArea : VegetationMask
  {
    public float ReductionTolerance;
    private PolygonMaskArea _currentMaskArea;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void UpdateVegetationMask() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GenerateHullNodes(float tolerance) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VegetationMaskArea() => throw null;
  }
}
