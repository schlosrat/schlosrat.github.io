// Decompiled with JetBrains decompiler
// Type: KerbalRosterGlobalSettings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

[CreateAssetMenu(fileName = "KerbalRosterGlobalSettings", menuName = "ScriptableObjects/KerbalRosterGlobalSettings")]
[Serializable]
public class KerbalRosterGlobalSettings : ScriptableObject
{
  public uint VETERAN_KERBAL_CAN_RESPAWN_AFTER_X;
  [FormerlySerializedAs("SPECIAL_KERBAL_SPAWNS_AFTER_X")]
  public uint UNCOMMON_KERBAL_SPAWNS_AFTER_X;
  [FormerlySerializedAs("SPECIAL_KERBAL_SPAWN_IS_GENPOP_AFTER_X")]
  public uint RARE_KERBAL_SPAWN_AFTER_X_UNCOMMON_SPAWNS;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public KerbalRosterGlobalSettings() => throw null;
}
