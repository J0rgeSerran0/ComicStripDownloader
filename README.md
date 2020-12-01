# Comic Strip Downloader
Project writen in [**.NET 5**](https://dotnet.microsoft.com/download/dotnet/5.0)


## Proposal

Experimental project to show you:
- How to use the **Type-Safe Enum Pattern** in c#
- How to use the [**HtmlAgilityPack**](https://www.nuget.org/packages/HtmlAgilityPack/) library to scrape a content for a web page (in this case a picture)


## Parts of the project

**ComicStripDownloader** *class library*


### **IComicStripService**
*Interface with two methods*

#### **Task&lt;ComicStripResponse&gt; GetComicStripUrlAsync(*DateTime*, *ComicStripType*)** 
To get the Url of a Comic Strip

> *DateTime* indicates the year, month and day of the Comic Strip
  
> *ComicStripType* indicates the Comic Strip that we want to get
  
#### **Task&lt;ComicStripResponse&gt; GetLastComicStripUrlAsync(*ComicStripType*)** 
To get the last Comic Strip

> *ComicStripType* indicates the Comic Strip that we want to get


### **ComicStripResponse**
*Record object of the response returned by the service*

> *string Source* contains the result if the process has been executed correctly

> *bool HasErrors* indicates if any error has been detected

> *string ErrorDescription* contains details about the error if has been detected


### **ComicStripType**
Use of the **Type-Safe Enum Pattern** to have all the details needed about a Comic Strip, that will be used by the service to get the Url of the Comic Strip correctly

The use of this pattern avoid possible problems when we are programming with **Enum** value type


### **ComicStripService**
Implementation of **IComicStripService**


## How to use this project

A **demo** sample has been included in the code to show you how to use this library.

To get the last Comic Strip of Dilbert, you would write something like:

```csharp
var response = await service.GetLastComicStripUrlAsync(ComicStripType.Dilbert);
```

And to get the Comic Strip of Dilbert for the 2020/09/25, you would write something like:

```csharp
var response = await service.GetComicStripUrlAsync(new DateTime(2020, 9, 25), ComicStripType.Dilbert);
```

After this, *response* has the result of this task.

You should check if *response.HasErrors* is **true** or **false**.

If is **false**, you could get the Url in *response.Source*.

If is **true**, you could get the Error Details.

```csharp
if (response.HasErrors)
    Console.WriteLine($"Error: {response.ErrorDescription}");
else
    Console.WriteLine($"Comic Strip Url: {response.Source}");
```


## Comic Strips that you can download

- Andy Capp
- Back to B.C.
- B.C.
- Big Nate
- Big Nate: First Class
- Broom Hilda
- Calvin and Hobbes
- Cathy Classics
- Cul de Sac
- Dilbert
- Dilbert Classics
- Doonesbury
- Eyebeam Classics
- For Better or For Worse
- FoxTrot Classics
- Frank and Ernest
- Frazz
- Free Range
- Gardfield
- Gardfield Classics
- Geech
- Get Fuzzy
- Heart of the City
- Herman
- Luann
- Luann Againn
- Mutt and Jeff
- Nancy Classics
- Non Sequitur
- Peanuts
- Peanuts Begins
- Pearls Before Swine
- Phoebe and Her Unicorn
- Pickles
- Ruby Park
- Shirley and Son Classics
- Skippy
- Stone Soup Classics
- Tarzan
- The Knight Life
- Wallace the Brave
- Wizard of Id
- Wizard of Id Classics
- Ziggy
