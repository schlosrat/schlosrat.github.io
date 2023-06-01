// Decompiled with JetBrains decompiler
// Type: KSP.Audio.BiomeSwitchPair
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
