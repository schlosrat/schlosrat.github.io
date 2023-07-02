// Decompiled with JetBrains decompiler
// Type: KSP.OAB.ObjectAssemblyCategoryButton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.OAB
{
  public class ObjectAssemblyCategoryButton : MonoBehaviour
  {
    public PartCategories category;
    [SerializeField]
    private GameObject highlightBG;
    [SerializeField]
    private Color highlightColor;
    [SerializeField]
    public bool ShowWhenEmpty;
    [SerializeField]
    public Image Icon;
    private ToggleExtended toggle;
    public Action<PartCategories> OnCategoryButtonClicked;
    private bool isSettingFromCode;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSelected(bool toggleState) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnToggleChangedByUI(bool newValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectAssemblyCategoryButton() => throw null;
  }
}
