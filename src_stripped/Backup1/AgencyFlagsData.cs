// Decompiled with JetBrains decompiler
// Type: AgencyFlagsData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
