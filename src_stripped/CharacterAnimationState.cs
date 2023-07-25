// Decompiled with JetBrains decompiler
// Type: CharacterAnimationState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class CharacterAnimationState
{
  public AnimationClip clip;
  public string name;
  public WrapMode wrapMode;
  public AnimationBlendMode blendMode;
  public float weight;
  public int layer;
  public float start;
  public float end;
  public float speed;
  public Transform[] addMixingTransforms;
  public bool addRecursive;
  public Transform[] excludeMixingTransforms;
  public AudioClip audioClip;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static implicit operator string(CharacterAnimationState st) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public CharacterAnimationState() => throw null;
}
