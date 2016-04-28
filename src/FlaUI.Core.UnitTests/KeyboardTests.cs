﻿using System.Text;
using FlaUI.Core.Input;
using FlaUI.Core.WindowsAPI;
using NUnit.Framework;

namespace FlaUI.Core.UnitTests
{
    [TestFixture]
    public class KeyboardTests
    {
        [Test]
        public void KeyboardTest()
        {
            var app = Application.Launch("notepad.exe");
            app.Automation.Keyboard.Write("ééééééööööö aaa | ");

            app.Automation.Keyboard.TypeVirtualKeyCode(VirtualKeyShort.KEY_Z);
            app.Automation.Keyboard.TypeVirtualKeyCode(VirtualKeyShort.LEFT);
            app.Automation.Keyboard.TypeVirtualKeyCode(VirtualKeyShort.DELETE);
            app.Automation.Keyboard.TypeVirtualKeyCode(VirtualKeyShort.KEY_Y);
            app.Automation.Keyboard.TypeVirtualKeyCode(VirtualKeyShort.BACK);
            app.Automation.Keyboard.TypeVirtualKeyCode(VirtualKeyShort.KEY_X);

            app.Automation.Keyboard.Write(" | ");

            app.Automation.Keyboard.Write("ঋ ঌ এ ঐ ও ঔ ক খ গ ঘ ঙ চ ছ জ ঝ ঞ ট ঠ ড ঢ");


            /*var chars = Encoding.Unicode.GetBytes("Hoiüüüèèèéééö | ");
            for (var x = 0; x < chars.Length; x++)
            {
                inp = KEYBDINPUT.UnicodeInput(chars[x], User32.GetMessageExtraInfo());
                SendInput(inp);
            }*/

            System.Threading.Thread.Sleep(2000);
            app.Dispose();
        }
    }
}