// Decompiled with JetBrains decompiler
// Type: KSP.Audio.BiomeSwitchPair
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using AK.Wwise;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Audio
{
  [Serializable]
  public class BiomeSwitchPair
  {
    [HideInInspector]
    public string Name;
    public Switch AudioSwitch;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BiomeSwitchPair() => throw null;
  }
}
