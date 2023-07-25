// Decompiled with JetBrains decompiler
// Type: KSP.Game.PartsManagerCategory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
    private DataContext _dataContext;
    private Property<string> _categoryName;
    private List<PartsManagerPart> _internalParts;
    private GameObjectPool<PartsManagerCategory> _pool;

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
    public void Initialize(GameObjectPool<PartsManagerCategory> pool, PartCategories category) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddPart(PartsManagerPart entry) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ReturnToPool() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetExpanded(bool expanded) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartsManagerCategory() => throw null;
  }
}
