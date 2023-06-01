// Decompiled with JetBrains decompiler
// Type: KSP.UI.ResearchDevelopmentTechnologyMiniature
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using DG.Tweening;
using KSP.Api.CoreTypes;
using KSP.Game;
using KSP.Research;
using KSP.UI.Binding;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI
{
  public class ResearchDevelopmentTechnologyMiniature : KerbalMonoBehaviour
  {
    [SerializeField]
    private ContextBindRoot _bindRoot;
    private List<DOTweenAnimation> _tweenAnimations;
    private Property<string> _technologyName;
    private Property<Sprite> _technologyIcon;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateMiniature(TechnologyNode techNode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ChangeMiniatureVisibility(TechnologyVisibilityType visibilityType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleAnimation(string triggerType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ResearchDevelopmentTechnologyMiniature() => throw null;
  }
}
