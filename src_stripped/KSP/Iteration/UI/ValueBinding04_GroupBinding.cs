// Decompiled with JetBrains decompiler
// Type: KSP.Iteration.UI.ValueBinding04_GroupBinding
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
  public class ValueBinding04_GroupBinding : MonoBehaviour
  {
    [SerializeField]
    private UIValueBinder changeIndicator;
    [Space]
    [SerializeField]
    private UIValueBinder colorGroup;
    [SerializeField]
    [Header("Mock Data")]
    private Color colorValue;
    private PropertyExternal<Color> colorProp;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ValueBinding04_GroupBinding() => throw null;
  }
}
