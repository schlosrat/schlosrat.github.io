// Decompiled with JetBrains decompiler
// Type: RandomTexturePicker
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Game;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

public class RandomTexturePicker : KerbalMonoBehaviour
{
  [SerializeField]
  [FormerlySerializedAs("targetMesh")]
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
