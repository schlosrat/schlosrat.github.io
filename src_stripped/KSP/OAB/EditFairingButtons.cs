// Decompiled with JetBrains decompiler
// Type: KSP.OAB.EditFairingButtons
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.OAB
{
  public class EditFairingButtons : KerbalMonoBehaviour
  {
    [SerializeField]
    private RectTransform exitEditTransform;
    [SerializeField]
    private ButtonExtended acceptButton;
    [SerializeField]
    private ButtonExtended cancelButton;
    [SerializeField]
    private RectTransform editRingsTransform;
    [SerializeField]
    private ButtonExtended addRingButton;
    [SerializeField]
    private ButtonExtended removeRingButton;
    private ObjectAssemblyBuilder builder;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize(ObjectAssemblyBuilder builder) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnAcceptClicked() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnCancelClicked() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnAddRingClicked() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnDeleteRingClicked() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAcceptCancelButtonsAnchoredPosition(Vector2 newAnchoredPosition) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAddRemoveButtonsAnchoredPosition(Vector2 newAnchoredPosition) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ToggleAddRingButton(bool enable) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ToggleRemoveRingButton(bool enable) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public EditFairingButtons() => throw null;
  }
}
