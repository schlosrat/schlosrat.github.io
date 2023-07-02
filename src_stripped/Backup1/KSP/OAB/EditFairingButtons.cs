// Decompiled with JetBrains decompiler
// Type: KSP.OAB.EditFairingButtons
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
