// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.UIList_ListView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Api;
using KSP.UI.Binding.Core;
using KSP.Utilities;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace KSP.UI.Binding
{
  public class UIList_ListView : UIListBinder
  {
    [Header("Values Injected in each view element")]
    [FormerlySerializedAs("keysToInject")]
    public ContextListView.InjectKeys injectKeys;
    [Header("Leave blank to get prefab from context")]
    [SerializeField]
    protected ContextBindRoot elementPrefab;
    [Header("if set will be resolve Element Prefab")]
    [SerializeField]
    protected string elementPropertyKeyPath;
    [Header("if set will resolve Element Pool")]
    [SerializeField]
    protected string _elementPoolPropetyKeyPath;
    protected MultiDragDropLogic multiDragDropLogic;
    [SerializeField]
    [Header("if set will be resolve MultiDragDropLogic Reference")]
    protected string multiDragDropPropertyKeyPath;
    private bool multiDragDropAdded;
    protected HighlightedDragDropLogic highlightedDragDropLogic;
    [Tooltip("If set will be resolve HighlightDragDropLogic Reference")]
    [SerializeField]
    protected string highlightedDragDropPropertyKeyPath;
    private bool highlightedDragDropAdded;
    [SerializeField]
    protected string useHighlightedDragDropPropertyKeyPath;
    [Space]
    public Transform elementContainer;
    [SerializeField]
    protected bool destroyChildrenOnStart;
    [Space]
    [SerializeField]
    protected bool reverseOrder;
    protected GameObjectPool<ContextBindRoot> _elementPool;
    public UIList_ListView.ElementModifyDelegate modifyElementOnCreation;
    public UIList_ListView.ElementModifyDelegate modifyElementOnDeletion;
    public RectTransform DragDropDummyObject;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void HandleListRebind() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void CheckForKeyRebinds(IDataContextReadonly context) => throw null;

    public ContextListView ListView
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetSourceIndexFromUnityIndex(int unityChildIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ManageListViewCreation() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private UIList_ListElement CreateListElement(Transform newParent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DestroyListElement(UIList_ListElement toDelete) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIList_ListView() => throw null;

    public delegate void ElementModifyDelegate(UIList_ListElement elementPrefab);
  }
}
