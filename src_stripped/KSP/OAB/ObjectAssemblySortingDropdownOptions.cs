// Decompiled with JetBrains decompiler
// Type: KSP.OAB.ObjectAssemblySortingDropdownOptions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.OAB
{
  public class ObjectAssemblySortingDropdownOptions : KerbalMonoBehaviour
  {
    [Tooltip("List of Sorting options to be used in Dropdown List. This will replace Options list from DropdownExtended")]
    public List<SortingDropdownOption> OptionsList;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<string> GetLocalizedOptions() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectAssemblySortingDropdownOptions() => throw null;
  }
}
