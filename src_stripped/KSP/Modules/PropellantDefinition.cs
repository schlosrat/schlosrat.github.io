// Decompiled with JetBrains decompiler
// Type: KSP.Modules.PropellantDefinition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim;
using KSP.Sim.ResourceSystem;
using System;
using System.Runtime.CompilerServices;

namespace KSP.Modules
{
  [Serializable]
  public class PropellantDefinition
  {
    public string mixtureName;
    public float mixtureMultiplier;
    public bool ignoreForThrustCurve;
    [KSPDefinition]
    public ResourceRecipeIngredientDefinitionOverride[] ingredientOverrides;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PropellantDefinition() => throw null;
  }
}
