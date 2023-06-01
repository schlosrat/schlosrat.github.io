// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationMaskLine
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using AwesomeTechnologies.Utility;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AwesomeTechnologies
{
  [AwesomeTechnologiesScriptOrder(99)]
  [HelpURL("http://www.awesometech.no/index.php/home/vegetation-studio/components/vegetation-masks/vegetation-mask-line")]
  public class VegetationMaskLine : VegetationMask
  {
    public float LineWidth;
    private readonly List<LineMaskArea> _lineMaskList;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Reset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void UpdateVegetationMask() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VegetationMaskLine() => throw null;
  }
}
