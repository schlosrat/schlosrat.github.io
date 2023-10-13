// Decompiled with JetBrains decompiler
// Type: AgencyFlagsData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
