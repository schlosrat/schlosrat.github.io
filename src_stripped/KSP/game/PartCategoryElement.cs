// Decompiled with JetBrains decompiler
// Type: KSP.Game.PartCategoryElement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.Sim;
using KSP.Sim.impl;
using System.Runtime.CompilerServices;

namespace KSP.Game
{
  public class PartCategoryElement : ApiDataContext
  {
    private const string PARTCATEGORY_PREFIX = "PartsManager/";
    [DataProperty("Category")]
    public PropertyReadonly<PartCategories> Category;
    [DataProperty("DisplayName")]
    public Property<string> DisplayName;
    [DataList("PartsList")]
    public ContextListProperty<PartElement> Parts;
    [DataProperty("PartsCount")]
    public PropertyReadonly<int> PartsCount;
    [DataProperty("HasParts")]
    public PropertyReadonly<bool> HasParts;
    [DataProperty("SelectedActionPartsCount")]
    public PropertyReadonly<int> SelectedActionPartsCount;
    [DataProperty("HasSelectedActionParts")]
    public PropertyReadonly<bool> HasSelectedActionParts;
    private DictionaryValueList<IGGuid, PartElement> _partElementMapping;
    private string _categoryName;

    internal DictionaryValueList<IGGuid, PartElement> PartElementMapping
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartCategoryElement(
      IInteractivePart part,
      PropertyReadonly<KSPActionGroup> selectedActionGroupProperty)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnLocalizeEvent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateElement(
      IInteractivePart part,
      PropertyReadonly<KSPActionGroup> selectedActionGroupProperty)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemovePart(IGGuid partId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdatePartCounts() => throw null;
  }
}
