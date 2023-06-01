// Decompiled with JetBrains decompiler
// Type: KSP.UI.ResearchButton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
