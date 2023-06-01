// Decompiled with JetBrains decompiler
// Type: KSP.UI.TechnologyNodeTooltipTarget
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using KSP.Research;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI
{
  [RequireComponent(typeof (TechnologyNode))]
  public class TechnologyNodeTooltipTarget : KerbalMonoBehaviour, ITooltipTarget
  {
    [SerializeField]
    private TechnologyNodeTooltip _tooltipPrefab;
    private TechnologyNodeTooltip _currentTooltip;
    private TechnologyNodeTooltipData _tooltipData;
    private TechnologyNode _technologyNode;

    public int Priority
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize(string name, Sprite icon, int cost) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnEnter() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnExit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ManageTooltip() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TechnologyNodeTooltipTarget() => throw null;
  }
}
