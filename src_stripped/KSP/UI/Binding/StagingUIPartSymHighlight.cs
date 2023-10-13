// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.StagingUIPartSymHighlight
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Api.CoreTypes;
using KSP.Staging.UI;
using KSP.UI.Binding.Core;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.UI.Binding
{
  public class StagingUIPartSymHighlight : UIValueBinder<bool>
  {
    [SerializeField]
    [Tooltip("Highlight prefab, set in inspector!")]
    private GameObject highlightPrefab;
    [SerializeField]
    [Tooltip("Set this as it's required to read properly the spacing between elements")]
    private VerticalLayoutGroup verticalLayoutGroup;
    [Tooltip("(OAB) Property key for getting the part Symmetry Eet from the part being highlighted")]
    [SerializeField]
    private string _symmetrySetKey;
    [Tooltip("(Flight) Sim side Property key for getting the part Symmetry Eet from the part being highlighted")]
    [SerializeField]
    private string _symmetrySetKeyFlight;
    [Tooltip("Property key is for letting this folder know it has a part with sym highlighted.")]
    [SerializeField]
    private string _partWithSymHighlightedKey;
    private Property<bool> _partWithsymHighlightValue;
    private KSP.OAB.SymmetrySet _partSymmetrySetOAB;
    private KSP.Sim.SymmetrySet _partSymmetrySetFlight;
    private List<int> _indexes;
    private List<RectTransform> _highlightTransforms;
    private int _currentHighlightIndex;
    private StagingPartGroupHoverComponent _stagingPartGroupHoverComponent;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RedrawValue(bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GetSymmetryDataAndIndexes() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HighlightPartsByIndex(List<int> partIndexGroup) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetAndScaleHighlightatIndex(int startIndex, int endIndex, int itemCount) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Cleanup() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StagingUIPartSymHighlight() => throw null;
  }
}
