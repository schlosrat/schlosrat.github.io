// Decompiled with JetBrains decompiler
// Type: KSP.OAB.PartControlSlider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
