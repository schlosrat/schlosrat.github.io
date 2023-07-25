// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.UIValue_ReadNumber_DateTime
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.UI.Binding.Core;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace KSP.UI.Binding
{
  public class UIValue_ReadNumber_DateTime : UIValueNumberBinder
  {
    private int daysInYear;
    private int hoursInDay;
    [Header("Display as a single text...")]
    [SerializeField]
    private TMP_Text dateTimeText;
    [SerializeField]
    private string dateTimeFormat;
    private string _dateTimeFormatLocalised;
    [Header("... Or through multiple number binders...")]
    [SerializeField]
    private UIValueBinder yearsDisplay;
    [SerializeField]
    private UIValueBinder daysDisplay;
    [SerializeField]
    private UIValueBinder hoursDisplay;
    [SerializeField]
    private UIValueBinder minutesDisplay;
    [SerializeField]
    private UIValueBinder secondDisplay;
    [SerializeField]
    private UIValueBinder millisecondDisplay;
    private Property<double>[] timeProperties;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static UIValue_ReadNumber_DateTime.DateTime ComputeDateTime(
      double timeUT,
      int hoursInDay,
      int daysInYear)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RedrawValue(bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnMappedNumberRangeChanged(
      UIValueNumberRange oldRange,
      bool shouldRedraw)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIValue_ReadNumber_DateTime() => throw null;

    public struct DateTime
    {
      public int[] values;

      public int Years
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public int Days
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public int Hours
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public int Minutes
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public int Seconds
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public double Milliseconds
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }
    }
  }
}
