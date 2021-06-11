using System;
using System.Text;
using BusinessLogic.Ciphers;
using BusinessLogic.SupportedCipherLangs;
using System.Linq;
using CommandLine;

namespace CipherProgram
{
    class Program
    {
        private class Options
        {
            [Option('e', "encrypt", Required = false, HelpText = "Encrypt the message.")]
            public bool Encrypt { get; set; }
            [Option('d', "decrypt", Required = false, HelpText = "Decrypt the message.")]
            public bool Decrypt { get; set; }
            [Option('s', "shift", Required = false, HelpText = "Specify the shift of cipher. (default - 3)")]
            public int Shift { get; set; } = 3;
            [Option('a', "alphabet", Required = false, HelpText = "Specify custom " +
                "alphabet (default - \"abcdefghijklmnopqrstuvwxyz\" - English alphabet)." +
                " in a form of alphabet itself for example if you want to specify " +
                "English alphabet you would use -a \"abcdefghijklmnopqrstuvwxyz\"")]
            public string Alphabet { get; set; }
            [Option('t', "text", Required = false, HelpText = "Specify text to encrypt or decrypt.")]
            public string Text { get; set; }
            [Option('c', "cipher", Required = false, HelpText = "Specify the cipher to use (default - Caesar cipher) others are not implemented yet")]
            public string CipherToUse { get; set; } = "Caesar";

            [Option('b', "bruteforce", Required = false, HelpText = "Specify whether to use bruteforce or not")]
            public bool BruteForce { get; set; }

        }
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Parser.Default.ParseArguments<Options>(args).WithParsed<Options>(
                o =>
                {
                    if (o.Encrypt)
                    {
                        if(o.Alphabet != null)
                        {
                            if(o.Text != null && o.Text.Length > 0)
                            {
                                if (o.CipherToUse == "Caesar")
                                {
                                    CaesarCipher caesarCipher = new CaesarCipher(o.Shift, new CustomCipherLang(o.Alphabet));
                                    Console.WriteLine(caesarCipher.Cipher(o.Text));
                                }
                                else
                                {
                                    Console.WriteLine("You specified cipher that is not supported");
                                }
                            }
                            else
                            {
                                Console.WriteLine("You should specify text with -t " +
                                    "flag or see --help for more info");
                            }
                        }
                        else
                        {
                            if (o.Text != null && o.Text.Length > 0)
                            {
                                if (o.CipherToUse == "Caesar")
                                {
                                    CaesarCipher caesarCipher = new CaesarCipher(o.Shift, new EnglishCipherLang());
                                    Console.WriteLine(caesarCipher.Cipher(o.Text));
                                }
                                else
                                {
                                    Console.WriteLine("You specified cipher that is not supported");
                                }
                            }
                            else
                            {
                                Console.WriteLine("You should specify text with -t " +
                                    "flag or see --help for more info");
                            }
                        }
                    }
                    else if (o.Decrypt)
                    {
                        if (o.Alphabet != null)
                        {
                            if (o.Text != null && o.Text.Length > 0)
                            {
                                if (o.CipherToUse == "Caesar")
                                {
                                    if (o.BruteForce)
                                    {
                                        CustomCipherLang customCipherLang = new CustomCipherLang(o.Alphabet);
                                        for (int i = 1; i < customCipherLang.GetAlphabetSize(); i++)
                                        {
                                            CaesarCipher caesarCipher = new CaesarCipher(i, customCipherLang);
                                            Console.WriteLine($"Shift {i}: {caesarCipher.Decipher(o.Text)}");
                                        }
                                    }
                                    else
                                    {
                                        CaesarCipher caesarCipher = new CaesarCipher(o.Shift, new CustomCipherLang(o.Alphabet));
                                        Console.WriteLine(caesarCipher.Decipher(o.Text));
                                    }
                                    
                                }
                                else
                                {
                                    Console.WriteLine("You specified cipher that is not supported");
                                }
                            }
                            else
                            {
                                Console.WriteLine("You should specify text with -t " +
                                    "flag or see --help for more info");
                            }
                        }
                        else
                        {
                            if (o.Text != null && o.Text.Length > 0)
                            {
                                if (o.CipherToUse == "Caesar")
                                {
                                    if (o.BruteForce)
                                    {
                                        EnglishCipherLang englishCipherLang = new EnglishCipherLang();
                                        for (int i = 1; i < englishCipherLang.GetAlphabetSize(); i++)
                                        {
                                            CaesarCipher caesarCipher = new CaesarCipher(i, englishCipherLang);
                                            Console.WriteLine($"Shift {i}: {caesarCipher.Decipher(o.Text)}");
                                        }
                                    }
                                    else
                                    {
                                        CaesarCipher caesarCipher = new CaesarCipher(o.Shift, new EnglishCipherLang());
                                        Console.WriteLine(caesarCipher.Decipher(o.Text));
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("You specified cipher that is not supported");
                                }
                            }
                            else
                            {
                                Console.WriteLine("You should specify text with -t " +
                                    "flag or see --help for more info");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Usage: \n\t{System.Reflection.Assembly.GetExecutingAssembly().GetName().Name}" +
                            $" [OPTIONS]... [TEXT]... \n\tFor more info use --help");
                    }
                });
            

        }
    }
}
