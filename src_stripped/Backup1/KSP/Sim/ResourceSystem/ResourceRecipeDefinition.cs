// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ResourceSystem.ResourceRecipeDefinition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
