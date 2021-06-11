# Cipher Project for TransUnion Internship
---------------------------------

The cipher project is dedicated for the TransUnion Internship programme. The main part of this project is to focus on Caesar Cipher.
I implemented Caesar Cipher in .NET and created simple console application to use it.

## Main differences
---------------------------------
After crawling through the internet I could not find the Caesar Cipher which would not only support English but other languages as well. That is why I decided to implement Caesar Cipher which also works with custom alphabets. That means that theoretically you can use Lithuanian, Russian and other alphabets for encrypting and decrypting messages (Note: Lithuanian and English alphabets were tested).


## Usage:
First of all if you want to use this program you should build the application and then start the program through the console like this:

```
YourApplication [OPTIONS]... -t [TEXT]....
```

You can find different options by writing

```
YourApplication --help
```
After starting that program you would get this output:
```
Copyright (C) 2021 CipherProgram

  -e, --encrypt       Encrypt the message.

  -d, --decrypt       Decrypt the message.

  -s, --shift         Specify the shift of cipher. (default - 3)

  -a, --alphabet      Specify custom alphabet (default - "abcdefghijklmnopqrstuvwxyz" - English alphabet). in a form of alphabet itself
                      for example if you want to specify English alphabet you would use -a "abcdefghijklmnopqrstuvwxyz"

  -t, --text          Specify text to encrypt or decrypt.

  -c, --cipher        Specify the cipher to use (default - Caesar cipher) others are not implemented yet

  -b, --bruteforce    Specify whether to use bruteforce or not

  --help              Display this help screen.

  --version           Display version information.
```


## Examples:

Let's say I want to encrypt the message in Lithuanian: **Ąžuolėlis**
That means I need to use Lithuanian alphabet which is: **aąbcčdeęėfghiįyjklmnoprsštuųūvzž**
I will use shift of four
Then you would run the following command:
```
YourApplication -e -s 4 -a "aąbcčdeęėfghiįyjklmnoprsštuųūvzž" -t "Ąžuolėlis"
```
And we get the output of encrypted text in Lithuanian Language
```
Dczšpipkų
```

If you want to decrypt the message then the following command will help

```
YourApplication -d -s 4 -a "aąbcčdeęėfghiįyjklmnoprsštuųūvzž" -t "Dczšpipkų"
```

And we get the output of
```
Ąžuolėlis
```

But what happens if we dont know the shift? We can use -b bruteforce flag
```
YourApplication -d -b -a "aąbcčdeęėfghiįyjklmnoprsštuųūvzž" -t "Čbvsohoju"
```
In the output we can clearly see which shift makes the most sense:
```
Shift 1: Cąūrngnyt
Shift 2: Baųpmfmįš
Shift 3: Ąžuolėlis
Shift 4: Aztnkękhr
Shift 5: Žvšmjejgp
Shift 6: Zūslydyfo
Shift 7: Vųrkįčįėn
Shift 8: Ūupjicięm
Shift 9: Ųtoyhbhel
Shift 10: Ušnįgągdk
Shift 11: Tsmifafčj
Shift 12: Šrlhėžėcy
Shift 13: Spkgęzębį
Shift 14: Rojfeveąi
Shift 15: Pnyėdūdah
Shift 16: Omįęčųčžg
Shift 17: Nliecuczf
Shift 18: Mkhdbtbvė
Shift 19: Ljgčąšąūę
Shift 20: Kyfcasaųe
Shift 21: Jįėbžržud
Shift 22: Yięązpztč
Shift 23: Įheavovšc
Shift 24: Igdžūnūsb
Shift 25: Hfčzųmųrą
Shift 26: Gėcvulupa
Shift 27: Fębūtktož
Shift 28: Ėeąųšjšnz
Shift 29: Ędausysmv
Shift 30: Ečžtrįrlū
Shift 31: Dczšpipkų
```


In the future I may add more ciphers as well as tidy up the console application program, as the main focus went to Caesar Cipher implementation and unit tests.



