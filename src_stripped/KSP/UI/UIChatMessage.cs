// Decompiled with JetBrains decompiler
// Type: KSP.UI.UIChatMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace KSP.UI
{
  public class UIChatMessage : MonoBehaviour
  {
    public TextMeshProUGUI messageText;
    public ChatMessageType type;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetContent(ChatMessageType type, string msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Display(bool display) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIChatMessage() => throw null;
  }
}
