// Decompiled with JetBrains decompiler
// Type: OABModifiedInputModule
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Input;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

public class OABModifiedInputModule : StandaloneInputModule
{
  private static Dictionary<string, List<OABModifiedInputModule.ControlBindingSerializable>> controlOverrides;

  private static OABModifiedInputModule Instance
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  private static GameInput GameInput
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public static bool OABControlsModifier
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private bool TrySetAsCurrent() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected override void Awake() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected override void OnEnable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected override void OnDisable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static BaseInput Input() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static RectTransform GetUIObjectUnderCursor() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static Vector2 GetCursorPos() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static RectTransform GetUIObjectUnderCursorEx(out Vector3 hitPos) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static RectTransform GetClickedUIObject() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static GameObject GetGameObjectUnderCursor() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static bool IsCursorOverRespectedUI() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static bool IsCursorOverUI() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private bool IsCursorOverUIOnLayer(int layer) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static bool IsCursorOverAnyUIWithTag(string tag) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnModifier(bool isPressed) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public OABModifiedInputModule() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  static OABModifiedInputModule() => throw null;

  [HideInInspector]
  [Serializable]
  public struct ControlBindingSerializable
  {
    public int index;
    public string id;
    public string actionMapName;
    public string path;
    public string overridePath;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ControlBindingSerializable(
      int bindingIndex,
      string bindingId,
      string bindingActionMapName,
      string bindingPath,
      string bindingOverridePath)
    {
      throw null;
    }
  }

  [HideInInspector]
  [Serializable]
  private class BindingWrapperClass
  {
    public List<OABModifiedInputModule.ControlBindingSerializable> bindings;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BindingWrapperClass() => throw null;
  }
}
