// Decompiled with JetBrains decompiler
// Type: KerbalIVAGlobalSettings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
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
