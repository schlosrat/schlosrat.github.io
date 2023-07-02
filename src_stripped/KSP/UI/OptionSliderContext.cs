// Decompiled with JetBrains decompiler
// Type: KSP.UI.OptionSliderContext
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using System.Runtime.CompilerServices;

namespace KSP.UI
{
  public class OptionSliderContext : ApiDataContext
  {
    public string Id;
    [DataProperty("sliderText")]
    public Property<string> SliderText;
    [DataProperty("sliderMinValue")]
    public Property<float> SliderMinValue;
    [DataProperty("sliderMaxValue")]
    public Property<float> SliderMaxValue;
    [DataProperty("increment")]
    public Property<float> Increment;
    [DataProperty("isPercentage")]
    public Property<bool> IsPercentage;
    [DataProperty("sliderValue")]
    public Property<float> SliderValue;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OptionSliderContext(
      string id,
      string sliderText,
      float minValue,
      float maxValue,
      float increment,
      bool isPercentage)
    {
      throw null;
    }
  }
}
