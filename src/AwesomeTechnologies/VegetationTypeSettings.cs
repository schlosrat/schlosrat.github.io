// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationTypeSettings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using AwesomeTechnologies.VegetationSystem;
using System;
using System.Runtime.CompilerServices;

namespace AwesomeTechnologies
{
  [Serializable]
  public class VegetationTypeSettings
  {
    public VegetationTypeIndex Index;
    public float Density;
    public float Size;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VegetationTypeSettings() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VegetationTypeSettings(VegetationTypeSettings orgVegetationTypeSettings) => throw null;
  }
}
