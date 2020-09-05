<div align="center">

![Zeats](https://zeatsbalancaautomatica.blob.core.windows.net/icons/nuget.png)

</div>

# zeats-legacy-random

Extensions to solve common problems when using strings

[![Build Status](https://dev.azure.com/zeats/Legacy/_apis/build/status/zeats-legacy-random?branchName=master)](https://dev.azure.com/zeats/Legacy/_build/latest?definitionId=17&branchName=master)
[![NuGet](https://img.shields.io/nuget/v/Zeats.Legacy.Random.svg)](https://www.nuget.org/packages/Zeats.Legacy.Random)

## Installation

```PM>
Install-Package Zeats.Legacy.Random
```

## Extensions

### string.FirstCharToUpper()
Upercase the first position of the string
```c#
"lorem ipsum dolor".FirstCharToUpper() /* return "Lorem ipsum dolor" */
"lOREM IPSUM DOLOR".FirstCharToUpper() /* return "LOREM IPSUM DOLOR" */
"LOREM IPSUM DOLOR".FirstCharToUpper() /* return "LOREM IPSUM DOLOR" */
```
---

### string.SafeSubstring(int start, int length)
Ensures the realization of the substring without throwing exception
```c#
"12345 7890".SafeSubstring(start: 0, length: 9999) /* return "12345 7890" */
"12345 7890".SafeSubstring(start: 0, length: 1) /* return "1" */
"12345 7890".SafeSubstring(start: 0, length: 6) /* return "12345 " */
```
---

### string.AlignRight(char paddingChar = ' ')
Right align content of a string
```c#
"Lorem Ipsum".AlignRight() /* return "Lorem Ipsum" */
"  Lorem Ipsum  ".AlignRight() /* return "    Lorem Ipsum" */
"  Lorem Ipsum  ".AlignRight('X') /* return "XXXXLorem Ipsum" */
```
---

### string.PadBoth(char paddingChar = ' ')
### string.PadBoth(int length, char paddingChar = ' ')
Pad both sides of a string
```c#
"Lorem Ipsum".PadBoth() /* return "Lorem Ipsum" */
"Lorem Ipsum".PadBoth(length: 20) /* return "    Lorem Ipsum     " */
"  Lorem Ipsum  ".PadBoth(paddingChar: 'X') /* "XXLorem IpsumXX" */
"  Lorem Ipsum  ".PadBoth(length: 20, paddingChar:'X') /* return "XX  Lorem Ipsum  XXX" */
```
---

### string.HasOnlyNumbers()
Checks if a string has only 0-9 numbers
```c#
"123a".HasOnlyNumbers() /* return false */
"192".HasOnlyNumbers() /* return true */
```
---

### string.OnlyNumbers()
Returns a new string containing only the numbers from the original string
```c#
"123a".OnlyNumbers() /* return "123" */
"192".OnlyNumbers() /* return "192" */
```
---

### string.OnlyNumbersOrWhiteSpace()
Returns a new string containing only the numbers or white space from the original string
```c#
"123a".OnlyNumbersOrWhiteSpace() /* return "123" */
"192".OnlyNumbersOrWhiteSpace() /* return "192" */
"1 23a".OnlyNumbersOrWhiteSpace() /* return "1 23" */
"1 92".OnlyNumbersOrWhiteSpace() /* return "1 92" */
```
---