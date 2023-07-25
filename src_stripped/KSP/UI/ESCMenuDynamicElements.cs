// Decompiled with JetBrains decompiler
// Type: KSP.UI.ESCMenuDynamicElements
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.UI
{
  [DisableCustomEditorBase]
  [Serializable]
  public class ESCMenuDynamicElements : KerbalMonoBehaviour
  {
    public const string PLAYER_INFORMATION_LOCALIZATION_KEY = "Menu/Escape/";
    [SerializeField]
    private Image iconObject;
    [SerializeField]
    private TextMeshProUGUI nameObject;
    public string NameText;
    public Sprite Icon;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeNameIcon() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ESCMenuDynamicElements() => throw null;
  }
}
