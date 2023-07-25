// Decompiled with JetBrains decompiler
// Type: KSP.UI.InfoPanelStickyHeaderTarget
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
