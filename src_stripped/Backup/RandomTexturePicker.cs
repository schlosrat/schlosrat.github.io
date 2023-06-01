// Decompiled with JetBrains decompiler
// Type: RandomTexturePicker
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

public class RandomTexturePicker : KerbalMonoBehaviour
{
  [FormerlySerializedAs("targetMesh")]
  [SerializeField]
  private Renderer _targetMesh;
  [FormerlySerializedAs("textureOptions")]
  [SerializeField]
  private Texture2D[] _textureOptions;
  [SerializeField]
  private bool _setEmissiveToo;
  [SerializeField]
  private string _emissionParamName;
  private static System.Random _randomizer;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Awake() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnEnable() => throw null;

  [ContextMenu("Re-RandomizeTexture")]
  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdateRandomTexture() => throw null;

  [ContextMenu("Re-RandomizeTexture", true)]
  [MethodImpl(MethodImplOptions.NoInlining)]
  private bool IsGameRunning() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public RandomTexturePicker() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  static RandomTexturePicker() => throw null;
}
