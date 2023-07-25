// Decompiled with JetBrains decompiler
// Type: UITextAnimAssistantInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class UITextAnimAssistantInfo
{
  public UITextAnimAssistantInfo.ToggleType toggleType;
  private UITextAnimAssistantInfo.ToggleType defaultToggleType;
  [HideInInspector]
  private UITextAnimAssistantInfo.AnimationStateInfo currentState;
  public bool animatedToggleHighlight;
  public bool animatedTogglePress;
  private Color previousColor;
  private Color targetColor;
  private float timer;
  public Graphic Target;
  public Color normalColor;
  public Color highlightedColor;
  public Color pressedColor;
  public Color disabledColor;
  public Color onColor;
  public Color offColor;
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

  public UITextAnimAssistantInfo.AnimationStateInfo CurrentState
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
  public UITextAnimAssistantInfo() => throw null;

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
