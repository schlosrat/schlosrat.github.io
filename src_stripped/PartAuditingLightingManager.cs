// Decompiled with JetBrains decompiler
// Type: PartAuditingLightingManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
