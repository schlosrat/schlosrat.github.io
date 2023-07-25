// Decompiled with JetBrains decompiler
// Type: KSP.OAB.PartControlToggle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Animation;
using KSP.Api.CoreTypes;
using KSP.UI.Binding;
using System;
using System.Runtime.CompilerServices;

namespace KSP.OAB
{
  public class PartControlToggle : IDisposable
  {
    private DataContext _elementContext;
    private OffsetSliderSystem.OffsetToggleData _controlData;
    private Property<string> _controlLabel;
    private PropertyExternal<bool> _controlValue;
    private const string LABEL_KEY = "PartControlLabel";
    private const string VALUE_KEY = "PartControlValue";

    public ContextBindRoot ControlElement
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool IsActive
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartControlToggle(
      ContextBindRoot controlElement,
      OffsetSliderSystem.OffsetToggleData data,
      Action onToggle)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool GetDataValue() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetDataValue(bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Dispose() => throw null;
  }
}
