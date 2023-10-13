// Decompiled with JetBrains decompiler
// Type: KSP.Navigation.ADynamicNavLayout
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Game;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace KSP.Navigation
{
  public abstract class ADynamicNavLayout : 
    KerbalMonoBehaviour,
    INavigatable,
    IHierachyGroupsLayout,
    INavigationLayout,
    ISyncCursorPosition
  {
    private DynamicGroup _rootGroup;
    [Header("Initialization - Load")]
    public LoadType LoadType;
    public int LoadDelayedFrames;
    public bool ActiveOnLoad;
    [Header("Initialization - Selection")]
    [Tooltip("Should select last selected element when this layout refocused.")]
    public bool SelectLastElement;
    public bool ResetSelectionOnUnload;
    public float StartSelectionDelayedSeconds;
    [Tooltip("Determine whether elements of this layout are accessable for parent layout.")]
    public bool IsAccessableForLayoutInParent;
    [SerializeField]
    [Header("Selection - default navigation parameters")]
    private NavigationParameter _defaultNavParameter;
    public Selectable DefaultStartElement;
    public Image SelectionCursor;
    private Selectable _currentElement;
    private Selectable _lastElement;
    private SelectableElementInfo _currentElementInfo;
    private bool _isVisibleLastFrame;
    private CanvasGroup _canvasGroup;
    private bool _isFocused;
    private bool _isEverFocused;
    private bool _isActiveBeforeUnfocused;
    private bool _isActive;
    public UnityEvent OnSelected;
    public UnityEvent OnQuit;

    public abstract Camera Camera
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    HierachyGroup IHierachyGroupsLayout.RootGroup
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public DynamicGroup RootGroup
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public DynamicGroup CurrentGroup
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public NavigationParameter NavParameter
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Selectable CurrentElement
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public SelectableElementInfo CurrentElementInfo
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    private CanvasGroup canvasGroup
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private bool Focused
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    bool INavigatable.Focused
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    private bool Active
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    bool INavigatable.Active
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    void INavigatable.UnloadComplete() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    void INavigatable.Quit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SelectStartElement() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool SelectElementAt(MoveDirection direction) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Scroll(Vector2 scrollDelta) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SyncCursorPosition() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Load() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Unload() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateElementSelection() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateCursorState() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator DelayedLoad(int delayedFrames) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator DelayedSelectStartElement(float seconds) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected ADynamicNavLayout() => throw null;

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    Transform INavigationLayout.get_transform() => throw null;
  }
}
