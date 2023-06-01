// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationMaskArea
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using AwesomeTechnologies.Utility;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AwesomeTechnologies
{
  [HelpURL("http://www.awesometech.no/index.php/home/vegetation-studio/components/vegetation-masks/vegetation-mask-area")]
  [AwesomeTechnologiesScriptOrder(99)]
  [ExecuteInEditMode]
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
