<div align="center">

![Zeats](https://zeatsbalancaautomatica.blob.core.windows.net/icons/nuget.png)

</div>

# zeats-legacy-random

Extensions to solve common problems when using random values

[![Build Status](https://dev.azure.com/zeats/Legacy/_apis/build/status/zeats-legacy-random?branchName=master)](https://dev.azure.com/zeats/Legacy/_build/latest?definitionId=17&branchName=master)
[![NuGet](https://img.shields.io/nuget/v/Zeats.Legacy.Random.svg)](https://www.nuget.org/packages/Zeats.Legacy.Random)

## Installation

```PM>
Install-Package Zeats.Legacy.Random
```

## Extensions

### RandomGenerator.NextBool(double chance = 0.5)
Return a random bool
```c#
RandomGenerator.NextBool() /* returns true or false with a 50% chance of true */
RandomGenerator.NextBool(0.3) /* returns true or false with a 30% chance of true */
```
---

### RandomGenerator.NextDouble()
Return a random double
```c#
RandomGenerator.NextDouble() /* returns value beetwen 0..1 */
```
---

### RandomGenerator.NextInt32(int min, int max)
Return a random int
```c#
RandomGenerator.NextInt32(10, 20) /* returns value beetwen 10..20 */
```
---

### RandomGenerator.NextDate(DateTime min, DateTime max)
Return a random DateTime
```c#
var min = new DateTime(2000, 9, 5, 8, 0, 0);
var max = new DateTime(2020, 9, 5, 8, 0, 0);
RandomGenerator.NextDate(min, max) /* returns value beetwen min..max */
```
---

### RandomGenerator.NextDecimal(int min, int max)
Return a random decimal
```c#
RandomGenerator.NextDecimal(10, 20) /* returns value beetwen 10..20 */
```
---

### RandomGenerator.NextEnum()
Return a random enum value
```c#
private enum SampleEnum
{
    Value01,
    Value02,
    Value03
}

RandomGenerator.NextEnum<SampleEnum>() /* returns Value01 or Value02 or Value03 */
```
---