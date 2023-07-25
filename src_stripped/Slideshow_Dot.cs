// Decompiled with JetBrains decompiler
// Type: Slideshow_Dot
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof (Image))]
[RequireComponent(typeof (ButtonExtended))]
public class Slideshow_Dot : KerbalMonoBehaviour
{
  [SerializeField]
  [Header("Set on Prefab")]
  protected Color _activeColour;
  [SerializeField]
  protected Color _inactiveColour;
  [SerializeField]
  protected Image _image;
  [SerializeField]
  protected Sprite _sprite;
  [SerializeField]
  protected ButtonExtended _buttonExtended;
  public Action OnClickAction;
  private bool isActive;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Awake() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDestroy() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected void Initialize() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetSprite(Sprite newSprite) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetVisuallyActive(bool bValue) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void IsVisible(bool bValue) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected void DotOnClickAction() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public Slideshow_Dot() => throw null;
}
