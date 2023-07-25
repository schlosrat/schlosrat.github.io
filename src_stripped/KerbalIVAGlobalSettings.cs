// Decompiled with JetBrains decompiler
// Type: KerbalIVAGlobalSettings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[CreateAssetMenu(fileName = "KerbalIVAGlobalSettings", menuName = "ScriptableObjects/KerbalIVAGlobalSettings")]
[Serializable]
public class KerbalIVAGlobalSettings : ScriptableObject
{
  public float IVA_CRASH_VELOCITY_THRESHOLD;
  public float IVA_CRASHRECOVERY_WAIT_TIME_MAXIMUM;
  public float IVA_CRASHRECOVERY_VELOCTY_THRESHOLD;
  public float IVA_CRASHRECOVERY_ANGULARVELOCITY_THRESHOLD;
  public float IVA_CRASHRECOVERY_DELAY_MINIMUM;
  public float IVA_CRASHRECOVERY_DELAY_MAXIMUM;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public KerbalIVAGlobalSettings() => throw null;
}
