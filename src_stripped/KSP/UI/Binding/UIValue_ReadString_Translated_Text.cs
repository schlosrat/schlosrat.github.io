// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.UIValue_ReadString_Translated_Text
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI.Binding
{
  public class UIValue_ReadString_Translated_Text : UIValue_ReadString_Text
  {
    [SerializeField]
    [Tooltip("Localization string we are adding before our read value")]
    private string prefix;
    [SerializeField]
    [Tooltip("Localization string we are adding after our read value")]
    private string suffix;
    private string _stringCache;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RedrawValue(bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIValue_ReadString_Translated_Text() => throw null;
  }
}
