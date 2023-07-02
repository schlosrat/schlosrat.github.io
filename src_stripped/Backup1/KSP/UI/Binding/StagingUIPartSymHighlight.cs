// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.StagingUIPartSymHighlight
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
    [Tooltip("Highlight prefab, set in inspector!")]
    [SerializeField]
    private GameObject highlightPrefab;
    [Tooltip("Set this as it's required to read properly the spacing between elements")]
    [SerializeField]
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
