// Decompiled with JetBrains decompiler
// Type: KSP.UI.MessageDescription
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.UI
{
  public class MessageDescription : KerbalMonoBehaviour
  {
    [SerializeField]
    protected Image _iconImage;
    [SerializeField]
    protected TextMeshProUGUI _descriptionTxt;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Show(MessageDescriptionData messageDescriptionData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MessageDescription() => throw null;
  }
}
