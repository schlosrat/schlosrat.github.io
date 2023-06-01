// Decompiled with JetBrains decompiler
// Type: UISkinning.UISkin
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace UISkinning
{
  [ExecuteInEditMode]
  public class UISkin : MonoBehaviour
  {
    public UISkinData uiSkinData;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [ContextMenu("Apply UI Skin")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ApplySkin() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ApplySkin(Transform uiTransform) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AssignUIProperties(Transform uiTransform, UISkinData.uiSkinDataProperties property) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CopyGameObjectProperties(Transform sourceObject, Transform destObject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool CheckComponentType(Component component) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UISkinData.uiSkinDataProperties FindUISkinDataWithTag(string tag) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool ApplyComponentProperties(Component source, Component dest) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ApplySkinToChildren(Transform uiTransform) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UISkin() => throw null;
  }
}
