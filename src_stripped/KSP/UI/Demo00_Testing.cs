// Decompiled with JetBrains decompiler
// Type: KSP.UI.Demo00_Testing
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.UI.Binding;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI
{
  public class Demo00_Testing : MonoBehaviour
  {
    public ContextBindRoot bindRoot;
    [Header("Mock Data")]
    public int intValue;
    public float floatValue;
    public double doubleValue;
    public PropertyExternal<int> intValueProp;
    public PropertyExternal<float> floatValueProp;
    public PropertyExternal<double> doubleValueProp;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void IntValueChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FloatValueChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DoubleValueChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Demo00_Testing() => throw null;
  }
}
