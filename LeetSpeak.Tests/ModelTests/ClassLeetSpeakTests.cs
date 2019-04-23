using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetSpeak;
using System;

namespace LeetSpeak.Tests
{
  [TestClass]
  public class LeetSpeakTest
  {
      [TestMethod]
      public void Translate_DisplayTheRightChars_Letter()
      {
          LeetSpeakTranslator testLeetSpeak = new LeetSpeakTranslator();
          Assert.AreEqual("3", testLeetSpeak.Translate("e"));
          Assert.AreEqual("0", testLeetSpeak.Translate("o"));
          Assert.AreEqual("1", testLeetSpeak.Translate("I"));
          Assert.AreEqual("7", testLeetSpeak.Translate("t"));
          Assert.AreEqual("z", testLeetSpeak.Translate("s"));
          
      }
      [TestMethod]
      public void Translate_DisplayTheWrongChars_Else()
      {
          LeetSpeakTranslator testLeetSpeak = new LeetSpeakTranslator();
          Assert.AreEqual("else", testLeetSpeak.Translate("b"));
      }
  }
}