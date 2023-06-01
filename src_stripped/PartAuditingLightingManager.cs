// Decompiled with JetBrains decompiler
// Type: PartAuditingLightingManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
