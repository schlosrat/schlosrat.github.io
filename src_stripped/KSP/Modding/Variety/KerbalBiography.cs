// Decompiled with JetBrains decompiler
// Type: KSP.Modding.Variety.KerbalBiography
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Networking.MP.Utils;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Modding.Variety
{
  public class KerbalBiography
  {
    private const string MAIN_BIO_KEY = "BIO";
    private const string BIO_KEY_MARKER = "BIO_";
    private const string BIO_KEY_NAME_NAME = "NAME";
    private const string BIO_KEY_NAME_FULLNAME = "FULLNAME";
    private Dictionary<string, List<int>> ChoicesAlreadyMade;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string WriteBio(
      KerbalAttributes kerbalAttributes,
      ref MPRandom randomizer,
      KerbalRosterManager manager)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string FillInBlanks(
      KerbalAttributes kerbalAttributes,
      string bioString,
      ref MPRandom randomizer,
      KerbalRosterManager manager)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string ParseBioKey(
      KerbalAttributes kerbalAttributes,
      string bioKey,
      ref MPRandom randomizer,
      KerbalRosterManager manager)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string PickRandomStringFromList(
      string bioKey,
      List<string> stringList,
      ref MPRandom randomizer)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string PickStringFromListByValue(string bioKey, List<string> stringList, float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AddEntryToChoicesMade(string bioKey, int choiceMade) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool WasChoiceAlreadyMade(string bioKey, int choiceMade) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KerbalBiography() => throw null;
  }
}
