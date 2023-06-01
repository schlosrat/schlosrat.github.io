// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ResourceSystem.ResourceRecipeDefinition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;

namespace KSP.Sim.ResourceSystem
{
  [Serializable]
  public struct ResourceRecipeDefinition
  {
    public string name;
    public string displayNameKey;
    public string abbreviationKey;
    public string resourceIconAssetAddress;
    public ResourceRecipeIngredientDefinition[] ingredients;
    public string vfxFuelType;
  }
}
