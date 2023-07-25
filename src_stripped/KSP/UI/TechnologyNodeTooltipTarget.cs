// Decompiled with JetBrains decompiler
// Type: KSP.UI.TechnologyNodeTooltipTarget
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
