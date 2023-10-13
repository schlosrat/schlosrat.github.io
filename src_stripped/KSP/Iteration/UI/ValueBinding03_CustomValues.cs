// Decompiled with JetBrains decompiler
// Type: KSP.Iteration.UI.ValueBinding03_CustomValues
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
