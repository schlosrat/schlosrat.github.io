// Decompiled with JetBrains decompiler
// Type: KSP.UI.ESCMenuActionElements
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using System;
using System.Collections;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.UI
{
  [DisableCustomEditorBase]
  [Serializable]
  public class ESCMenuActionElements : KerbalMonoBehaviour
  {
    private const string ACTION_ELEMENTS_LOCALIZATION_PATH = "Menu/Escape/";
    public bool IsEmpty;
    [SerializeField]
    private Image iconObject;
    [SerializeField]
    private TextMeshProUGUI idObject;
    [SerializeField]
    private TextMeshProUGUI nameObject;
    [Header("Localization Key")]
    public string NameText;
    [SerializeField]
    private Sprite Icon;
    private string ID;
    private IEnumerator PopulateIDs;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetLocalizedNameText(string localizationKey) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetID(string id) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator PopulateSideindex() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ESCMenuActionElements() => throw null;
  }
}
