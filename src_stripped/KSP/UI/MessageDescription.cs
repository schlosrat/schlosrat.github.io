// Decompiled with JetBrains decompiler
// Type: KSP.UI.MessageDescription
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
