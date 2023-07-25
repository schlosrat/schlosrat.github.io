// Decompiled with JetBrains decompiler
// Type: KSP.UI.ResearchButton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Research;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.UI
{
  [RequireComponent(typeof (ButtonExtended))]
  public class ResearchButton : KerbalMonoBehaviour
  {
    [SerializeField]
    private CanvasGroup _canvasGroup;
    private ButtonExtended _researchButton;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateResearchButton(TechnologyVisibilityType visibilityType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ResearchButton() => throw null;
  }
}
