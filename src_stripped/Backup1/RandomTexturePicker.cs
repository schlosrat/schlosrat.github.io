// Decompiled with JetBrains decompiler
// Type: RandomTexturePicker
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

public class RandomTexturePicker : KerbalMonoBehaviour
{
  [SerializeField]
  [FormerlySerializedAs("targetMesh")]
  private Renderer _targetMesh;
  [SerializeField]
  [FormerlySerializedAs("textureOptions")]
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
