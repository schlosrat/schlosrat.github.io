// Decompiled with JetBrains decompiler
// Type: KSP.Game.StartupFlow.LegalSubmenu
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace KSP.Game.StartupFlow
{
  public class LegalSubmenu : KerbalMonoBehaviour
  {
    public string Name;
    public TMP_Text LegalText;
    [SerializeField]
    private GameObject _link;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetActive(bool isActive) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LegalSubmenu() => throw null;
  }
}
