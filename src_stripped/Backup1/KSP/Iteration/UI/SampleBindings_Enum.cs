// Decompiled with JetBrains decompiler
// Type: KSP.Iteration.UI.SampleBindings_Enum
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
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
    [Space(40f, order = 1)]
    [SerializeField]
    [Header("----- SELECT MOCK DATA SOURCE -----", order = 2)]
    [Space(10f, order = 3)]
    private SampleBindings_Enum.MockDataMode mockDataMode;
    private PropertyExternal<SampleBindings_Enum.MockDataMode> mockDataModeProperty;
    [Space(30f, order = 1)]
    [Header("Mock Data Source: String Set", order = 2)]
    [SerializeField]
    private string stringValue;
    [SerializeField]
    private List<string> allStringValues;
    private PropertyExternal<string> stringValueProp;
    [Space(order = 1)]
    [Header("Mock Data Source: Enum", order = 2)]
    [Header("      GENERAL ENUM WARNING:", order = 3)]
    [Header("      - Animations lag if you use inspector dropdowns!", order = 4)]
    [Header("      - Test enum animations with 'auto change values'!", order = 5)]
    [SerializeField]
    private SampleBindings_Enum.MockDemoEnum enumValue;
    private PropertyExternal<SampleBindings_Enum.MockDemoEnum> enumValueProperty;
    [Header("Backend Changes", order = 2)]
    [Space(30f, order = 1)]
    [SerializeField]
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
