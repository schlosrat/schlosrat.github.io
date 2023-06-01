// Decompiled with JetBrains decompiler
// Type: KSP.UI.InfoPanelStickyHeaderTarget
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using DG.Tweening;
using KSP.Game;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.UI
{
  public class InfoPanelStickyHeaderTarget : KerbalMonoBehaviour
  {
    [SerializeField]
    private TMP_Text _headerText;
    [SerializeField]
    private ToggleExtended _dropdownToggle;
    [SerializeField]
    private DOTweenAnimation _closeIconAnimation;

    public string HeaderText
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsDropdownOpen
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CloseAccordion() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public InfoPanelStickyHeaderTarget() => throw null;
  }
}
