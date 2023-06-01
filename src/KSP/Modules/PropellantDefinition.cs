// Decompiled with JetBrains decompiler
// Type: KSP.Modules.PropellantDefinition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
