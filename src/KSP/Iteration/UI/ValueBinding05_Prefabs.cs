// Decompiled with JetBrains decompiler
// Type: KSP.Iteration.UI.ValueBinding05_Prefabs
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.UI.Binding.Core;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Iteration.UI
{
  public class ValueBinding05_Prefabs : MonoBehaviour
  {
    [SerializeField]
    private UIValueBinder changeIndicator;
    [SerializeField]
    [Space]
    private RectTransform colorGroupLocator;
    [SerializeField]
    private UIValueBinder colorGroupPrefab;
    private UIValueBinder colorGroupInstance;
    [Header("Mock Data")]
    [SerializeField]
    private Color colorValue;
    private PropertyExternal<Color> colorProp;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ValueBinding05_Prefabs() => throw null;
  }
}
