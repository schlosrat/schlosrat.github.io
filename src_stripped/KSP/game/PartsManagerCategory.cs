// Decompiled with JetBrains decompiler
// Type: KSP.Game.PartsManagerCategory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Api.CoreTypes;
using KSP.UI.Binding;
using KSP.Utilities;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.Game
{
  public class PartsManagerCategory : KerbalMonoBehaviour, IPooledUI
  {
    private const string CATEGORY_NAME_LOC_PREFIX = "PartsManager";
    private const string CATEGORY_NAME_LOC_SEPARATOR = "/";
    private const string CATEGORY_NAME_POSTFIX = "*";
    private const string CATEGORY_NAME_PROPERTY_KEY = "CategoryName";
    private const string UNDEFINED_CATEGORY_NAME = "Undefined Category";
    [SerializeField]
    private ContextBindRoot _contextBindRoot;
    [SerializeField]
    private Transform _accordianContent;
    [SerializeField]
    private ToggleExtended _toggle;
    [SerializeField]
    private Image _categoryIcon;
    [SerializeField]
    private List<Sprite> _categoryIcons;
    private DataContext _dataContext;
    private Property<string> _categoryName;
    private List<PartsManagerPart> _internalParts;
    private GameObjectPool<PartsManagerCategory> _pool;
    private PartsManagerPartsList parentPartsList;

    public List<PartsManagerPart> InternalParts
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public PartCategories Category
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize(
      GameObjectPool<PartsManagerCategory> pool,
      PartCategories category,
      PartsManagerPartsList partsList)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddPart(PartsManagerPart entry) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ReturnToPool() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetExpanded(bool expanded) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsExpanded() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnToggleValueChanged(bool newState) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnLocalize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartsManagerCategory() => throw null;
  }
}
