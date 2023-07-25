// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.Core.UIValue_ReadEnum_TextSet
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace KSP.UI.Binding.Core
{
  public class UIValue_ReadEnum_TextSet : UIValueEnumBinder
  {
    private const string DEFAULT_FORMAT = "Value is: {0}";
    [SerializeField]
    private TMP_Text targetText;
    [SerializeField]
    private string textFormat;
    [SerializeField]
    private bool updateColor;
    [SerializeField]
    private float colorFadeDuration;
    [SerializeField]
    [Header("Choose Text to print for each Value")]
    private UIValue_ReadEnum_TextSet.TextEntry[] textValues;
    [SerializeField]
    [Header("Fallback - used when value is not mapped")]
    private UIValue_ReadEnum_TextSet.FallbackTextEntry fallbackValue;
    protected Dictionary<string, UIValue_ReadEnum_TextSet.TextEntry> valueMap;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void PopulateValueMap() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RedrawValue(bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateText(string textValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateColor(Color color, bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIValue_ReadEnum_TextSet() => throw null;

    [Serializable]
    public struct TextEntry
    {
      public string enumValue;
      public string textValue;
      public Color textColor;

      public static UIValue_ReadEnum_TextSet.TextEntry Default
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }
    }

    [Serializable]
    public struct FallbackTextEntry
    {
      public string textValue;
      public Color textColor;

      public static UIValue_ReadEnum_TextSet.FallbackTextEntry Default
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }
    }
  }
}
