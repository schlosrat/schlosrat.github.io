// Decompiled with JetBrains decompiler
// Type: UnityEngine.UI.TransitionVisualData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine.Serialization;

namespace UnityEngine.UI
{
  [Serializable]
  public struct TransitionVisualData
  {
    [HideInInspector]
    [SerializeField]
    private bool m_IgnoreColorTransition;
    [FormerlySerializedAs("colorPreset")]
    [SerializeField]
    [HideInInspector]
    private ColorBlockPreset m_ColorPreset;
    [HideInInspector]
    [SerializeField]
    [FormerlySerializedAs("m_ColorFadeDuration")]
    private float m_ColorDuration;
    [SerializeField]
    [HideInInspector]
    private bool m_IgnoreScaleTransition;
    [SerializeField]
    [HideInInspector]
    private float m_ScaleDuration;
    [FormerlySerializedAs("OnRest")]
    [SerializeField]
    private SpriteEntry OnRest;
    [FormerlySerializedAs("OnHover")]
    [SerializeField]
    private SpriteEntry OnHover;
    [FormerlySerializedAs("OnPress")]
    [SerializeField]
    private SpriteEntry OnPress;
    [SerializeField]
    [FormerlySerializedAs("OnDisabled")]
    private SpriteEntry OnDisabled;
    [SerializeField]
    private SpriteEntry OnSelect;

    public static TransitionVisualData Default
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool ignoreColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public ColorBlockPreset colorPreset
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float colorDuration
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool ignoreScale
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float scaleDuration
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [HideInInspector]
    public SpriteEntry spriteEntryOnRest
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [HideInInspector]
    public SpriteEntry spriteEntryOnHover
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [HideInInspector]
    public SpriteEntry spriteEntryOnPress
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [HideInInspector]
    public SpriteEntry spriteEntryOnDisabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [HideInInspector]
    public SpriteEntry spriteEntryOnSelect
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SpriteEntry GetSpriteEntry(SelectionState state, bool useColorPreset = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Color GetStateColor(SelectionState state, ColorBlock colors) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ApplyColorBlock(
      ref TransitionVisualData data,
      ColorBlock block,
      bool applyDuration = false)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ApplySpriteBlock(ref TransitionVisualData data, SpriteBlockExtended block) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ApplyScaleBlock(
      ref TransitionVisualData data,
      ScaleBlock block,
      bool applyDuration = false)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ApplySpriteEntryLabels(ref TransitionVisualData data) => throw null;
  }
}
