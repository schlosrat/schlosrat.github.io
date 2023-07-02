// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.UIValue_ReadString_Translated_Text
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
