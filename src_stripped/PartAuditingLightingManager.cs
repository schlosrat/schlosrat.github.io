// Decompiled with JetBrains decompiler
// Type: PartAuditingLightingManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[CreateAssetMenu(fileName = "Part Auditing Lighting Manager", menuName = "KSP Lighting/Part Auditing Lighting", order = 120)]
[Serializable]
public class PartAuditingLightingManager : ScriptableObject
{
  public List<GameObject> prefabLightingSetups;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public PartAuditingLightingManager() => throw null;
}
