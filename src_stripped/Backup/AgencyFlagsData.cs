// Decompiled with JetBrains decompiler
// Type: AgencyFlagsData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[DisableCustomEditorBase]
[CreateAssetMenu(fileName = "AgencyFlags", menuName = "ScriptableObjects/AgencyFlags", order = 1)]
[Serializable]
public class AgencyFlagsData : ScriptableObject
{
  public List<AgencyFlag> Flags;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public AgencyFlagsData() => throw null;
}
