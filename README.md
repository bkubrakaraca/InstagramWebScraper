# About

Information on the web page of the Instagram account is getted by web scraper. Scraped data is exported as Excel file.

# Installation

Installations required to run the program.

## .Net6.0

- You can download Net6.0 by the link:
  [dotnet.microsoft.com/en-us/download/dotnet/6.0](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)

- Install .Net Runtime and .Net SDK.

## Playwright

`pwsh bin\Debug\net6.0\playwright.ps1 install`

- Install to the project folder using Terminal,

- Or install using Visual Stduio Developer Command Prompt
  (Tools -> Command Line -> Developer Command Prompt.)

## IronXL

IronXL can be installed in three different ways:

### 1. Visual Studio Nuget Packages

You can install IronXL by the Visual Studio Project Menu.

- Project -> Manage NuGet Packages
- Browse -> IronXL.Excel -> Install

### 2. Package Manager Console

You can install IronXL by the Visual Studio Package Manager Console.

- Tools -> NuGet Package Manager -> Package Manager Console
- `Install-Package IronXL.Excel`

### 3. Install by Direct Download of the Library

Install IronXL is by downloading it directly from the URL:
[ironsoftware.com/csharp/excel](https://ironsoftware.com/csharp/excel/)

## RestSharp

RestSharp can be downloaded using the Package Manager Console.

- Tools -> NuGet Package Manager -> Package Manager Console

- `Install-Package RestSharp`
