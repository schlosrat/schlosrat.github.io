// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.UIValue_ReadEnum_SetVisibility`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.UI.Binding.Core;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI.Binding
{
  public class UIValue_ReadEnum_SetVisibility<T> : UIValueBinder<T> where T : Enum
  {
    public CanvasGroup target;
    public T[] valuesToMatch;
    [Space]
    public bool interactableIfNotFound;
    public bool interactableIfValueMatch;
    [Space]
    public float alphaIfMatch;
    public float alphaIfNoMatch;
    [Space]
    public bool disableGameObjectIfNoMatch;
    [Tooltip("If this is not interactable for any reason, should raycast's be blocked? Defaults to true, as if we're a non-interactable button for example.")]
    [Space]
    public bool blockRaycastingWhenNotInteractable;
    private bool defaultRaycastBlockSetting;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleIsBoundChanged(bool isBound, bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RedrawValue(bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool ValueMatch(T valueToCheck) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIValue_ReadEnum_SetVisibility() => throw null;
  }
}
