﻿// Decompiled with JetBrains decompiler
// Type: KerbalRosterGlobalSettings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
