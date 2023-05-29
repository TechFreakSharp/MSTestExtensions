# TechFreakSharp.MSTestExtensions

This repository contains extensions for the MSTest (v2+) testing framework.

## Installation

You can easily install the TechFreakSharp.MSTestExtensions package using NuGet. Simply run the following command in the Package Manager Console:
`Install-Package TechFreakSharp.MSTestExtensions`

## Usage

To use the extensions, add the following using statement to your test class:
`using TechFreakSharp.MSTestExtensions;`

Then you can use the extensions with the `Assert.That` syntax. Here's an example:

```
[TestMethod]
public void TestMethod1()
{
	string myString = "Hello World!";
	Assert.That.NotIsEmpty(myString);
}
```

## Contributing

Contributions are always welcome! If you have any issues or feature requests, please don't hesitate to submit them in the [issues](https://github.com/TechFreakSharp/MSTestExtensions/issues) section of this repository.

## Attributions

[Exam](https://www.flaticon.com/free-icon/exam_149316) icon made by [Freepik](https://www.flaticon.com/authors/freepik) from [www.flaticon.com](https://www.flaticon.com/)