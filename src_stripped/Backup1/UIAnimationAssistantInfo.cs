// Decompiled with JetBrains decompiler
// Type: UIAnimationAssistantInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class UIAnimationAssistantInfo
{
  public UIAnimationAssistantInfo.ToggleType toggleType;
  private UIAnimationAssistantInfo.ToggleType defaultToggleType;
  [HideInInspector]
  private UIAnimationAssistantInfo.AnimationStateInfo currentState;
  public bool animatedToggleHighlight;
  public bool animatedTogglePress;
  private Color previousColor;
  private Color targetColor;
  private float timer;
  public Image Target;
  public Sprite normalSprite;
  public Sprite highlightedSprite;
  public Sprite pressedSprite;
  public Sprite disabledSprite;
  public Sprite onSprite;
  public Sprite offSprite;
  public Color normalColor;
  public Color highlightedColor;
  public Color pressedColor;
  public Color disabledColor;
  public Color onColor;
  public Color offColor;
  public bool changeSprite;
  public bool changeColor;
  public bool interpolateColor;
  public float interpolationTime;

  public bool canAnimateHighlight
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public bool canAnimatePress
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public UIAnimationAssistantInfo.AnimationStateInfo CurrentState
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  private bool transitioning
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  private float progress
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void ResetState() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public UIAnimationAssistantInfo() => throw null;

  public enum ToggleType
  {
    None,
    On,
    Off,
  }

  public enum AnimationStateInfo
  {
    Normal,
    Highlighted,
    Pressed,
    Disabled,
  }
}
