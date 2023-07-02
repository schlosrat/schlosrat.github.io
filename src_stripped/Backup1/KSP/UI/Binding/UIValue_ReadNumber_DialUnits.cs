// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.UIValue_ReadNumber_DialUnits
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.UI.Binding.Core;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI.Binding
{
  [DisallowMultipleComponent]
  public class UIValue_ReadNumber_DialUnits : UIValueBinder<double>
  {
    [SerializeField]
    private RectTransform unitTransform;
    [SerializeField]
    private float startSwitchThreshold;
    [SerializeField]
    private UIValue_ReadNumber_DialUnits.UnitEntry[] unitEntryArray;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateDialToMatchUnits() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RedrawValue(bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIValue_ReadNumber_DialUnits() => throw null;

    [Serializable]
    public struct UnitEntry
    {
      public float unitMultiplier;
      public RectTransform unitNewTransform;
    }
  }
}
