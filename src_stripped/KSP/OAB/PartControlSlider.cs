// Decompiled with JetBrains decompiler
// Type: KSP.OAB.PartControlSlider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Animation;
using KSP.Api.CoreTypes;
using KSP.UI.Binding;
using System;
using System.Runtime.CompilerServices;

namespace KSP.OAB
{
  public class PartControlSlider : IDisposable
  {
    private DataContext _elementContext;
    private OffsetSliderSystem.OffsetSliderData _controlData;
    private Property<string> _controlLabel;
    private PropertyExternal<float> _controlValue;
    private const string LABEL_KEY = "PartControlLabel";
    private const string VALUE_KEY = "PartControlValue";

    public ContextBindRoot ControlElement
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartControlSlider(
      ContextBindRoot controlElement,
      OffsetSliderSystem.OffsetSliderData data)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float GetDataValue() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetDataValue(float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Dispose() => throw null;
  }
}
