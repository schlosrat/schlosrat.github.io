// Decompiled with JetBrains decompiler
// Type: KSP.Research.TechnologyNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using DG.Tweening;
using KSP.Api.CoreTypes;
using KSP.Game;
using KSP.UI;
using KSP.UI.Binding;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace KSP.Research
{
  public class TechnologyNode : KerbalMonoBehaviour
  {
    public ContextBindRoot BindRoot;
    public UnityAction UpdateUI;
    public Image TechnologyIcon;
    [SerializeField]
    private CanvasGroup _highlightBorder;
    private ToggleExtended _toggle;
    private DataContext _technologyNodeContext;
    private Technology _technology;
    private ResearchDevelopmentController _researchDevelopmentController;
    private List<DOTweenAnimation> _tweenAnimations;
    public Property<string> Id;
    public Property<string> Name;
    public Property<Sprite> Icon;
    [DataProperty("technology.technologyCategory")]
    public Property<TechnologyCategoryType> TechnologyCategory;
    public Property<string> Description;
    public Property<int> ScienceCost;
    [DataList("technology.prerequisites")]
    public List<string> Prerequisites;
    [DataProperty("technology.prerequisiteLogic")]
    public Property<PrerequisiteLogicType> PrerequisiteLogic;
    [DataProperty("technology.technologyVisibility")]
    public Property<TechnologyVisibilityType> TechnologyVisibility;
    [DataList("technology.children")]
    public List<TechnologyNode> Children;
    [DataList("technology.parents")]
    public List<TechnologyNode> Parents;

    private GameInstance _game
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public TechnologyNode Parent
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void InitializeTechNode(Technology techData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeContextBinding() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateTechNodeVisibilityAndInteraction() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CheckIfTechnologyNodeIsPurchasable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateTechNodeInteraction(bool isInteractable, bool isOn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DisplayInfoSideBar() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UnlockTechnology() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleAnimation(string triggerType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SelectNode(bool isSelected) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddChild(TechnologyNode techNode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddParent(TechnologyNode techNode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool RemoveChild(TechnologyNode techNode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TechnologyNode() => throw null;
  }
}
