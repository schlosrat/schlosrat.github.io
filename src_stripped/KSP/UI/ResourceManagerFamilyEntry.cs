// Decompiled with JetBrains decompiler
// Type: KSP.UI.ResourceManagerFamilyEntry
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.Sim.impl;
using System.Runtime.CompilerServices;

namespace KSP.UI
{
  public class ResourceManagerFamilyEntry : ApiDataContext
  {
    private const string FAMILY_TITLE_FORMAT_LOC_PATH = "Flight/ResourceManager/FamilyTitleFormat";
    [DataProperty("PartFamily")]
    public PropertyReadonly<string> PartFamily;
    [DataProperty("TotalParts")]
    public PropertyReadonly<int> TotalParts;
    [DataProperty("FamilyTitle")]
    public PropertyExternal<string> Title;
    [DataList("PartsList")]
    public ContextListProperty<ResourceManagerPartEntry> Parts;
    private ResourceManagerUI _resourceManagerUI;
    private string _partNameLocalized;
    private string _familyTitleFormat;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ResourceManagerFamilyEntry(ResourceManagerUI resourceManagerUI, PartComponent part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool AddPart(VesselComponent activeVessel, PartComponent part, bool fireEvent = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPartsListChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string GetTitle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitEntry() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void Cleanup(VesselComponent activeVessel) => throw null;
  }
}
