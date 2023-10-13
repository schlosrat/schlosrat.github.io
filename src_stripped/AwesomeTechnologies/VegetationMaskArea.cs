// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationMaskArea
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using AwesomeTechnologies.Utility;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AwesomeTechnologies
{
  [HelpURL("http://www.awesometech.no/index.php/home/vegetation-studio/components/vegetation-masks/vegetation-mask-area")]
  [ExecuteInEditMode]
  [AwesomeTechnologiesScriptOrder(99)]
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
