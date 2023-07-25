// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.ContextListView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api;
using KSP.Api.CoreTypes;
using KSP.Api.Generic;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI.Binding
{
  public class ContextListView
  {
    private ContextListView.InjectKeys m_elementInjectKeys;
    private IContextListProperty m_itemSourceProperty;
    private IDataContextReadonly m_itemHierarchyParentOverride;
    private Func<Transform, UIList_ListElement> m_createElement;
    private bool m_isReverseBindOrder;
    private Action<UIList_ListElement> m_deleteElement;
    private Transform m_elementContainer;

    protected bool IsBeingDestroyed
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ContextListView.InjectKeys ElementInjectKeys
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public IContextListProperty ItemSourceProperty
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public IReadOnlyList<IDataContextReadonly> ItemSource
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public PropertyReadonly<int> ItemSourceCountProperty
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public PropertyReadonly<int> ItemSourceCountMinusProperty
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private Func<Transform, UIList_ListElement> CreateElement
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool IsReverseBindOrder
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    private Action<UIList_ListElement> DeleteElement
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Transform ElementContainer
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool CanUpdateListView
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private List<ContextListView.ViewElementEntry> ViewElementEntries
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int ViewElementCount
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ContextListView(
      IContextListProperty itemSource,
      Func<Transform, UIList_ListElement> makeElement,
      Action<UIList_ListElement> deleteElement,
      Transform elementContainer,
      IDataContextReadonly itemHierarchyParentOverride = null,
      ContextListView.InjectKeys elementInjectKeys = null,
      bool destroyElementContainerChildren = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void BindItemSourceProperty(IContextListProperty itemSourceProperty) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RefreshViewBindings() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateViewElementLifetime() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void ClearViewElements() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ClearViewElementEntry(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIList_ListElement GetElementOnScreen(
      Vector2 mouseScreenPosition,
      Func<RectTransform, bool> funcValidator = null)
    {
      throw null;
    }

    [Serializable]
    public class InjectKeys
    {
      [SerializeField]
      private string keyPrefix;
      private const string listViewElementFormat = "#listViewElement";
      private const string sourceCountFormat = "#count";
      private const string sourceIndexFormat = "#index";
      private const string sourceReverseIndexFormat = "#reverseIndex";
      private const string viewFirstFormat = "#isFirst";
      private const string viewLastFormat = "#isLast";
      private const string nextIndexFormat = "#nextIndex";
      private const string prevIndexFormat = "#prevIndex";
      private const string insertBeforeIndexFormat = "#insertBeforeIndex";
      private const string insertAfterIndexFormat = "#insertAfterIndex";
      [HideInInspector]
      public string listViewElement;
      [HideInInspector]
      public string count;
      [HideInInspector]
      public string index;
      [HideInInspector]
      public string reverseIndex;
      [HideInInspector]
      public string isFirst;
      [HideInInspector]
      public string isLast;
      [HideInInspector]
      public string nextIndex;
      [HideInInspector]
      public string prevIndex;
      [HideInInspector]
      public string insertAfterIndex;
      [HideInInspector]
      public string insertBeforeIndex;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public InjectKeys(string prefix = null) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void UpdateWithPrefix(string prefix) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private static string DoFormat(string format, string prefix) => throw null;
    }

    public class ViewElementEntry
    {
      public UIList_ListElement viewElementInstance;
      private DataContext viewElementContext;
      private ContextListView.InjectKeys injectKeys;
      private IProperty<int> sourceCount;
      public PropertyReadonly<int> sourceIndex;
      public PropertyReadonly<int> sourceReverseIndex;
      public PropertyReadonly<bool> isFirst;
      public PropertyReadonly<bool> isLast;
      public PropertyReadonly<int> prevIndex;
      public PropertyReadonly<int> nextIndex;
      public PropertyReadonly<int> insertBeforeIndex;
      public PropertyReadonly<int> insertAfterIndex;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public ViewElementEntry(
        UIList_ListElement element,
        IProperty<int> sourceCountProp,
        ContextListView.InjectKeys keys)
      {
        throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Unbind() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Bind(
        IDataContextReadonly elementHierarchyParent,
        IDataContextReadonly sourceElement)
      {
        throw null;
      }
    }
  }
}
