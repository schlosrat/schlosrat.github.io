// Decompiled with JetBrains decompiler
// Type: KSP.Audio.BiomeAudioMapping
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Audio
{
  [CreateAssetMenu(fileName = "BiomeAudioMapping", menuName = "ScriptableObjects/BiomeAudioMapping")]
  public class BiomeAudioMapping : ScriptableObject
  {
    [SerializeField]
    public List<BiomeSwitchPair> BiomeTypeToAudioPairs;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BiomeAudioMapping() => throw null;
  }
}
