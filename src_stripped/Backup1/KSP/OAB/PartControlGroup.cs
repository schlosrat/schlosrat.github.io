// Decompiled with JetBrains decompiler
// Type: KSP.OAB.PartControlGroup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Animation;
using KSP.Api.CoreTypes;
using KSP.UI.Binding;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.OAB
{
  public class PartControlGroup : IDisposable
  {
    private Dictionary<string, PartControlSlider> _sliders;
    private PartControlToggle _toggle;
    private string _groupName;
    private RectTransform _groupParent;
    private DataContext _groupContext;
    private const string GROUP_KEY = "PartControlGroup";

    public ContextBindRoot GroupElement
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartControlGroup(ContextBindRoot groupElement, string groupName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddToggle(ContextBindRoot toggleElement, OffsetSliderSystem.OffsetToggleData data) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddSlider(ContextBindRoot controlElement, OffsetSliderSystem.OffsetSliderData data) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Dispose() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ToggleElements() => throw null;
  }
}
