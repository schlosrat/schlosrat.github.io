// Decompiled with JetBrains decompiler
// Type: KSP.OAB.ProceduralPartUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Animation;
using KSP.Api.CoreTypes;
using KSP.Game;
using KSP.Modules;
using KSP.UI.Binding;
using KSP.Utilities;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.OAB
{
  public class ProceduralPartUI : KerbalMonoBehaviour
  {
    [SerializeField]
    private ContextBindRoot _partControlSliderPrefab;
    [SerializeField]
    private ContextBindRoot _partControlTogglePrefab;
    [SerializeField]
    private ContextBindRoot _partGroupPrefab;
    [SerializeField]
    private RectTransform _controlListContainer;
    [SerializeField]
    private ContextBindRoot _uiWindowRoot;
    [SerializeField]
    private CanvasGroup _rootCanvasGroup;
    [SerializeField]
    private Sprite _defaultIcon;
    [Header("Default window position")]
    [SerializeField]
    private float _defaultXWindowOffset;
    [SerializeField]
    private float _defaultYWindowOffset;
    [SerializeField]
    private RectTransform _uiWindowRectTransform;
    private Dictionary<string, PartControlGroup> _partControlGroups;
    private GameObjectPool<ContextBindRoot> _partControlSliderPool;
    private GameObjectPool<ContextBindRoot> _partControlTogglePool;
    private GameObjectPool<ContextBindRoot> _partGroupPool;
    private Module_ProceduralPart _selectedPart;
    private DataContext _uiWindowContext;
    private Property<string> _uiWindowTitle;
    private Property<Sprite> _uiWindowIcon;
    private ObjectAssemblyBuilderEvents _events;
    private const string WINDOW_TITLE_KEY = "PartControlWindowTitle";
    private const string WINDOW_CLOSE_KEY = "PartControlCloseWindow";
    private const string WINDOW_ICON_KEY = "PartControlWindowIcon";
    private AssemblyPartsPicker _OABpartsPicker;

    private bool isOABValid
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize(ObjectAssemblyBuilderEvents events) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEditableChanged(Module_ProceduralPart part, bool isEditable) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Show() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Hide() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnCloseWindow() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateSelectedPart(Module_ProceduralPart part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ClearSymmetryCallbacks(OffsetSliderSystem targetSliderSystem) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPostDynamicMeshInstantiated() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FinishEditingSelectedPart() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GetPartControls(OffsetSliderSystem targetSliderSystem) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ValueChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ResetUI() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ProceduralPartUI() => throw null;
  }
}
