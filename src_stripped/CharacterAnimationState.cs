// Decompiled with JetBrains decompiler
// Type: CharacterAnimationState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
