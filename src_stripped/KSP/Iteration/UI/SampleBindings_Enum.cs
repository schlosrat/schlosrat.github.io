// Decompiled with JetBrains decompiler
// Type: KSP.Iteration.UI.SampleBindings_Enum
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api;
using KSP.Api.CoreTypes;
using KSP.UI.Binding;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Iteration.UI
{
  public class SampleBindings_Enum : MonoBehaviour
  {
    public ContextBindRoot bindRoot;
    private DataContext context;
    [Header("----- SELECT MOCK DATA SOURCE -----", order = 2)]
    [Space(40f, order = 1)]
    [SerializeField]
    [Space(10f, order = 3)]
    private SampleBindings_Enum.MockDataMode mockDataMode;
    private PropertyExternal<SampleBindings_Enum.MockDataMode> mockDataModeProperty;
    [SerializeField]
    [Space(30f, order = 1)]
    [Header("Mock Data Source: String Set", order = 2)]
    private string stringValue;
    [SerializeField]
    private List<string> allStringValues;
    private PropertyExternal<string> stringValueProp;
    [SerializeField]
    [Header("      - Test enum animations with 'auto change values'!", order = 5)]
    [Header("      - Animations lag if you use inspector dropdowns!", order = 4)]
    [Header("      GENERAL ENUM WARNING:", order = 3)]
    [Header("Mock Data Source: Enum", order = 2)]
    [Space(order = 1)]
    private SampleBindings_Enum.MockDemoEnum enumValue;
    private PropertyExternal<SampleBindings_Enum.MockDemoEnum> enumValueProperty;
    [Space(30f, order = 1)]
    [SerializeField]
    [Header("Backend Changes", order = 2)]
    private bool autoChangeValues;
    [SerializeField]
    private float timeBetweenChanges;
    private float lastTime;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string EnsureStringValueIsInSet(string input) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerable<string> GetAllEnumValues() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void BindUI(IProperty property) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void MockDataModeProperty_OnChangedValue(SampleBindings_Enum.MockDataMode value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void EnumValueProperty_OnChangedValue(SampleBindings_Enum.MockDemoEnum value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void StringValueProp_OnChangedValue(string value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SampleBindings_Enum() => throw null;

    private enum MockDataMode
    {
      Use_StringSet,
      Use_Enum,
    }

    private enum MockDemoEnum
    {
      ValueA,
      ValueB,
      ValueC,
      ValueD,
      ValueE,
    }
  }
}
