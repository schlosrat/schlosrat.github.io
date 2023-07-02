// Decompiled with JetBrains decompiler
// Type: KSP.OAB.ObjectAssemblySortingDropdownOptions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
