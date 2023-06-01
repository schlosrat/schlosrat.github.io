// Decompiled with JetBrains decompiler
// Type: KSP.Iteration.UI.ValueBinding03_CustomValues
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
  public class ValueBinding03_CustomValues : MonoBehaviour
  {
    [SerializeField]
    private UIValueBinder changeIndicator;
    [Space]
    [SerializeField]
    private UIValueBinder colorImageTint;
    [SerializeField]
    private UIValueBinder colorText;
    [SerializeField]
    private UIValueBinder colorRGBFields;
    [SerializeField]
    private UIValueBinder colorHSVFields;
    [Header("Mock Data")]
    [SerializeField]
    private Color colorValue;
    private PropertyExternal<Color> colorProp;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ValueBinding03_CustomValues() => throw null;
  }
}
