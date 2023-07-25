// Decompiled with JetBrains decompiler
// Type: KSP.Navigation.QuickNavigationLayout
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace KSP.Navigation
{
  public class QuickNavigationLayout : 
    KerbalMonoBehaviour,
    INavigationLayout,
    INavigatable,
    IQuickNavRegister,
    INavElementRegister
  {
    [Header("Initialization")]
    public ADynamicNavLayout DefaultTargetNavLayout;
    [HideInInspector]
    [SerializeField]
    private string _layoutTag;
    public MoveDirection UpListIterateDirection;
    [SerializeField]
    private List<QuickNavigationLayout.QuickAccess> _upList;
    public MoveDirection DownListIterateDirection;
    [SerializeField]
    private List<QuickNavigationLayout.QuickAccess> _downList;
    public MoveDirection LeftListIterateDirection;
    [SerializeField]
    private List<QuickNavigationLayout.QuickAccess> _leftList;
    public MoveDirection RightListIterateDirection;
    [SerializeField]
    private List<QuickNavigationLayout.QuickAccess> _rightList;
    private MoveDirection _currentDirection;
    private List<QuickNavigationLayout.QuickAccess> _currentList;
    private QuickNavigationLayout.QuickAccess _currentAccess;
    private bool _isFocused;
    private bool _isActive;

    public string LayoutTag
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public QuickNavigationLayout.QuickAccess CurrentAccess
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public SelectableElementInfo CurrentElementInfo
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Selectable CurrentElement
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    bool INavigatable.Focused
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool Active
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    void INavigatable.UnloadComplete() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    void INavigatable.Quit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Load() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Unload() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool SelectElementAt(MoveDirection direction) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool AddAccess(
      MoveDirection direction,
      Selectable explicitSelectable = null,
      RectTransform selectionRect = null,
      SelectPoint startPoint = SelectPoint.Up,
      ADynamicNavLayout layout = null)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool RemoveAccess(MoveDirection direction, RectTransform selectionRect) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool RemoveAccess(MoveDirection direction, Selectable explicitSelectable) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ApplyQuickAccess() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Reset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SelectNextAccessByDirection(MoveDirection iterateDirection) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector2 GetBasePointByDirection(MoveDirection listIterateDirection) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public QuickNavigationLayout() => throw null;

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    Transform INavigationLayout.get_transform() => throw null;

    [Serializable]
    public struct QuickAccess
    {
      public ADynamicNavLayout Layout;
      public RectTransform SelectionRect;
      public SelectPoint StartPoint;
      public Selectable ExplicitElementToSelect;

      public Vector2 StartScreenPoint
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public MoveDirection SelectDirection
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public SelectableElementInfo ElementInfoToSelect
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public Vector2? CenterOnScreen
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }
    }
  }
}
