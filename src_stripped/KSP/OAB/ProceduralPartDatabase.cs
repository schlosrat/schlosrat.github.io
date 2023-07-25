// Decompiled with JetBrains decompiler
// Type: KSP.OAB.ProceduralPartDatabase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Logging;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.OAB
{
  public class ProceduralPartDatabase
  {
    private const LogFilter LOG_FILTER = (LogFilter) 8388608;
    private bool _isDefinitionDataFrozen;
    private readonly List<ProceduralPartDatabase.ProceduralPartDefinitionWrapper> _proceduralPartDefinitionWrappers;
    private readonly Dictionary<string, ProceduralPartDefinitionID> _proceduralPartNameIDMap;
    private readonly List<string> _proceduralPartNameLookup;
    private readonly List<ProceduralPartDefinition> _proceduralPartDefinitionCache;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string LOG_PREFIX([CallerMemberName] string memberName = "") => throw null;

    public bool IsDefinitionDataFrozen
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int DataCount
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerable<ProceduralPartDefinitionID> GetAllProceduralPartIDs() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void FreezeAndCacheDefinitionValues() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ProceduralPartDefinitionID GetProceduralPartIDFromName(string proceduralPartName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsValidProceduralPartID(ProceduralPartDefinitionID definitionID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ProceduralPartDefinition GetDefinitionData(ProceduralPartDefinitionID definitionID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ProceduralPartDefinitionID AddOrUpdateDefinition(
      ProceduralPartDefinition proceduralPartDefinition)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void StoreResourceDataAtIndex(
      ProceduralPartDatabase.ProceduralPartDefinitionWrapper proceduralPartWrapper,
      int resourceDataIndex)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void EnsureDataIndexAllocations(int resourceDataIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int NextPowerOf2(int number) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void EnsureListIsLargeEnough<T>(List<T> list, int requestedIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static ProceduralPartDatabase.ProceduralPartDefinitionWrapper CreateDataFromProceduralPartDefinition(
      ProceduralPartDefinition definition,
      ProceduralPartDefinitionID resourceID)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    private bool IsValidDataIndex(int dataIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    private int GetDataIndexFromID(ProceduralPartDefinitionID definitionID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    private ProceduralPartDefinitionID GetIDFromDataIndex(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    private string SanitizeNameString(string proceduralPartName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ProceduralPartDatabase() => throw null;

    private class ProceduralPartDefinitionWrapper
    {
      public ProceduralPartDefinitionID ProceduralPartID;
      public ProceduralPartDefinition originalProceduralPartDefinition;
      public string DefinitionName;
      public string DisplayNameKey;
      public string EditMenuHeaderKey;
      public List<ProceduralPartAttribute> Attributes;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public ProceduralPartDefinitionWrapper() => throw null;
    }
  }
}
