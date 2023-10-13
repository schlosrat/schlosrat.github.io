// Decompiled with JetBrains decompiler
// Type: KSP.Research.Technology
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Assets;
using KSP.Game;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Research
{
  public class Technology
  {
    public string ID;
    public string Name;
    public string IconAssetName;
    private Texture2D _icon;
    public bool IconLoadFinished;
    public TechnologyCategoryType TechnologyCategory;
    public string Description;
    public int ScienceCost;
    public List<Benefit> Benefits;
    public List<string> Prerequisites;
    public PrerequisiteLogicType PrerequisiteLogic;
    public TechnologyVisibilityType TechnologyVisibility;
    public Vector2 TechTreePosition;
    public List<Technology> Parents;
    public List<Technology> Children;

    private GameInstance _game
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private AssetProvider _assetProvider
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Texture2D Icon
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateVisibilityState() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Unlock() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Technology() => throw null;
  }
}
