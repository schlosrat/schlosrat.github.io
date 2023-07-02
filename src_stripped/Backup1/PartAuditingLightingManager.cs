// Decompiled with JetBrains decompiler
// Type: PartAuditingLightingManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
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
