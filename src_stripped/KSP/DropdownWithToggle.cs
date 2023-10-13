// Decompiled with JetBrains decompiler
// Type: KSP.DropdownWithToggle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace KSP
{
  public class DropdownWithToggle : Dropdown
  {
    public float minHoldTime;
    public bool shiftReversesCycle;
    public List<DropdownWithToggle.ActionCondition> actionConditions;
    private PointerEventData.InputButton lastButtonDown;
    private bool pendingHold;
    private float curHoldTime;
    public GameObject curBlocker;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetIndexFromText(string text) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool SetIndexFromText(string text) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override GameObject CreateBlocker(Canvas rootCanvas) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator UpdateBlockerButton() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void DestroyBlocker(GameObject blocker) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnBlockerClicked(PointerEventData data) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnPointerDown(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnPointerUp(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnPointerExit(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnPointerClick(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void EvaluatedActionConditions() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PerformTriggerAction(DropdownWithToggle.ActionMode mode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DropdownWithToggle() => throw null;

    [Serializable]
    public class ActionCondition
    {
      public PointerEventData.InputButton button;
      public DropdownWithToggle.ConditionMode condition;
      public DropdownWithToggle.ActionMode action;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public ActionCondition() => throw null;
    }

    public enum ConditionMode
    {
      ClickShort,
      HoldAndRelease,
      HoldTimed,
    }

    public enum ActionMode
    {
      OpenDropdown,
      CycleNext,
      CyclePrev,
      None,
    }
  }
}
