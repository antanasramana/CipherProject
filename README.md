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

If I want to use vanilla Caesar Cipher encryption I would write
```
YourApplication -e -t "textToEncrypt"
```
Or if I want to decrypt
```
YourApplication -d -t "textToDecrypt"
```

### More difficult examples

Let's say I want to encrypt the message in Lithuanian: **????uol??lis**
That means I need to use Lithuanian alphabet which is: **a??bc??de????fghi??yjklmnoprs??tu????vz??**
I will use shift of four
Then you would run the following command:
```
YourApplication -e -s 4 -a "a??bc??de????fghi??yjklmnoprs??tu????vz??" -t "????uol??lis"
```
And we get the output of encrypted text in Lithuanian Language
```
Dcz??pipk??
```

If you want to decrypt the message then the following command will help

```
YourApplication -d -s 4 -a "a??bc??de????fghi??yjklmnoprs??tu????vz??" -t "Dcz??pipk??"
```

And we get the output of
```
????uol??lis
```

But what happens if we dont know the shift? We can use -b bruteforce flag
```
YourApplication -d -b -a "a??bc??de????fghi??yjklmnoprs??tu????vz??" -t "??bvsohoju"
```
In the output we can clearly see which shift makes the most sense:
```
Shift 1: C????rngnyt
Shift 2: Ba??pmfm????
Shift 3: ????uol??lis
Shift 4: Aztnk??khr
Shift 5: ??v??mjejgp
Shift 6: Z??slydyfo
Shift 7: V??rk????????n
Shift 8: ??upjici??m
Shift 9: ??toyhbhel
Shift 10: U??n??g??gdk
Shift 11: Tsmifaf??j
Shift 12: ??rlh??????cy
Shift 13: Spkg??z??b??
Shift 14: Rojfeve??i
Shift 15: Pny??d??dah
Shift 16: Om????????????g
Shift 17: Nliecuczf
Shift 18: Mkhdbtbv??
Shift 19: Ljg????????????
Shift 20: Kyfcasa??e
Shift 21: J????b??r??ud
Shift 22: Yi????zpzt??
Shift 23: ??heavov??c
Shift 24: Igd????n??sb
Shift 25: Hf??z??m??r??
Shift 26: G??cvulupa
Shift 27: F??b??tkto??
Shift 28: ??e??????j??nz
Shift 29: ??dausysmv
Shift 30: E????tr??rl??
Shift 31: Dcz??pipk??
```


In the future I may add more ciphers as well as tidy up the console application program, as the main focus went to Caesar Cipher implementation and unit tests.



