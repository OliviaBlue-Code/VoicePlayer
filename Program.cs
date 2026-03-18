using System;
using static System.Console;//if you do this, you can just write, writeline and readline(); and print whatever you want without saying console.
using System.Speech.Synthesis; // import this to use voice input
namespace VoicePlayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /*example for using writeline without adding console
            * WriteLine("Hello, Please Enter Your Name: ");
            string name = ReadLine();
            WriteLine(name);//
           remember you can just print the user input alone by calling the variable name in brackets only but if you want to add text plus the answer, use $"" add text in qoutation marks then use calibraces and put variable name inside them
        */

            SpeechSynthesizer speak = new SpeechSynthesizer(); //object for voice recorder. wav format is used to save your recorder.
            //to change or manipulate speed say
            speak.Volume = 100;
            speak.Rate = -2;
            speak.SelectVoiceByHints(VoiceGender.Female);// to change voice or age
            string greeting = "Hello user. Welcome to the chatbot. Please input your name: ";
            speak.Speak(greeting);
            }
    }
}
