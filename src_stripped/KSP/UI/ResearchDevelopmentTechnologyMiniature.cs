// Decompiled with JetBrains decompiler
// Type: KSP.UI.ResearchDevelopmentTechnologyMiniature
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
