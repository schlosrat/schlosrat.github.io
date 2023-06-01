// Decompiled with JetBrains decompiler
// Type: Slideshow_Dot
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof (Image))]
[RequireComponent(typeof (ButtonExtended))]
public class Slideshow_Dot : KerbalMonoBehaviour
{
  [Header("Set on Prefab")]
  [SerializeField]
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
