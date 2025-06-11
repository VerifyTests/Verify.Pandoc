# <img src="/src/icon.png" height="30px"> Verify.Pandoc

[![Discussions](https://img.shields.io/badge/Verify-Discussions-yellow?svg=true&label=)](https://github.com/orgs/VerifyTests/discussions)
[![Build status](https://ci.appveyor.com/api/projects/status/f1j7ka007s5uea82?svg=true)](https://ci.appveyor.com/project/SimonCropp/Verify-Pandoc)
[![NuGet Status](https://img.shields.io/nuget/v/Verify.Pandoc.svg)](https://www.nuget.org/packages/Verify.Pandoc/)

Extends [Verify](https://github.com/VerifyTests/Verify) to allow verification of documents via [PandocNet](https://github.com/SimonCropp/PandocNet).

Converts documents to markdown.

Currently supported documents:

 * docx
 * rtf

**See [Milestones](../../milestones?state=closed) for release notes.**


## Sponsors


### Entity Framework Extensions<!-- include: zzz. path: /docs/zzz.include.md -->

[Entity Framework Extensions](https://entityframework-extensions.net/) is a major sponsor and is proud to contribute to the development this project.

[![Entity Framework Extensions](docs/zzz.png)](https://entityframework-extensions.net)<!-- endInclude -->


## NuGet package

https://nuget.org/packages/Verify.Pandoc/


## Usage


### Enable Verify.Pandoc

<!-- snippet: enable -->
<a id='snippet-enable'></a>
```cs
[ModuleInitializer]
public static void Initialize() =>
    VerifyPandoc.Initialize();
```
<sup><a href='/src/Tests/ModuleInitializer.cs#L3-L9' title='Snippet source file'>snippet source</a> | <a href='#snippet-enable' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->


### Rtf


#### Verify a file

<!-- snippet: VerifyRtf -->
<a id='snippet-VerifyRtf'></a>
```cs
[Test]
public Task VerifyRtf() =>
    VerifyFile("sample.rtf");
```
<sup><a href='/src/Tests/Samples.cs#L4-L10' title='Snippet source file'>snippet source</a> | <a href='#snippet-VerifyRtf' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->


#### Verify a Stream

<!-- snippet: VerifyRtfStream -->
<a id='snippet-VerifyRtfStream'></a>
```cs
[Test]
public Task VerifyRtfStream()
{
    var stream = new MemoryStream(File.ReadAllBytes("sample.rtf"));
    return Verify(stream, "rtf");
}
```
<sup><a href='/src/Tests/Samples.cs#L12-L21' title='Snippet source file'>snippet source</a> | <a href='#snippet-VerifyRtfStream' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->


#### Result

<!-- snippet: Samples.VerifyRtf.verified.md -->
<a id='snippet-Samples.VerifyRtf.verified.md'></a>
```md
**Lorem ipsum **

- **Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc ac
  faucibus odio. **

Vestibulum neque massa, scelerisque sit amet ligula eu, congue molestie
mi. Praesent ut varius sem. Nullam at porttitor arcu, nec lacinia nisi.
Ut ac dolor vitae odio interdum condimentum. **Vivamus dapibus sodales
ex, vitae malesuada ipsum cursus convallis. Maecenas sed egestas nulla,
ac condimentum orci. **Mauris diam felis, vulputate ac suscipit et,
iaculis non est. Curabitur semper arcu ac ligula semper, nec luctus nisl
blandit. Integer lacinia ante ac libero lobortis imperdiet. *Nullam
mollis convallis ipsum, ac accumsan nunc vehicula vitae. *Nulla eget
justo in felis tristique fringilla. Morbi sit amet tortor quis risus
auctor condimentum. Morbi in ullamcorper elit. Nulla iaculis tellus sit
amet mauris tempus fringilla.

Maecenas mauris lectus, lobortis et purus mattis, blandit dictum tellus.

- **Maecenas non lorem quis tellus placerat varius. **

- *Nulla facilisi. *

- <u>Aenean congue fringilla justo ut aliquam. </u>

- Nunc vulputate neque vitae justo facilisis, non condimentum ante
  sagittis.

- Morbi viverra semper lorem nec molestie.

- Maecenas tincidunt est efficitur ligula euismod, sit amet ornare est
  vulputate.

In non mauris justo. Duis vehicula mi vel mi pretium, a viverra erat
efficitur. Cras aliquam est ac eros varius, id iaculis dui auctor. Duis
pretium neque ligula, et pulvinar mi placerat et. Nulla nec nunc sit
amet nunc posuere vestibulum. Ut id neque eget tortor mattis tristique.
Donec ante est, blandit sit amet tristique vel, lacinia pulvinar arcu.
Pellentesque scelerisque fermentum erat, id posuere justo pulvinar ut.
Cras id eros sed enim aliquam lobortis. Sed lobortis nisl ut eros
efficitur tincidunt. Cras justo mi, porttitor quis mattis vel, ultricies
ut purus. Ut facilisis et lacus eu cursus.

In eleifend velit vitae libero sollicitudin euismod. Fusce vitae
vestibulum velit. Pellentesque vulputate lectus quis pellentesque
commodo. Aliquam erat volutpat. Vestibulum in egestas velit.
Pellentesque fermentum nisl vitae fringilla venenatis. Etiam id mauris
vitae orci maximus ultricies.

<table>
<tbody>
<tr class="odd">
<td></td>
<td><ul>
<li><p><strong>Cras fringilla ipsum magna, in fringilla dui commodo
a.</strong></p></li>
</ul>
<p>Lorem ipsum</p></td>
<td><p>Lorem ipsum</p></td>
<td><p>Lorem ipsum</p></td>
</tr>
<tr class="even">
<td><p>1</p></td>
<td><p>In eleifend velit vitae libero sollicitudin euismod.</p></td>
<td><p>Lorem</p></td>
<td></td>
</tr>
<tr class="odd">
<td><p>2</p></td>
<td><p>Cras fringilla ipsum magna, in fringilla dui commodo a.</p></td>
<td><p>Ipsum</p></td>
<td></td>
</tr>
<tr class="even">
<td><p>3</p></td>
<td><p>Fusce vitae vestibulum velit.</p></td>
<td><p>Lorem</p></td>
<td></td>
</tr>
<tr class="odd">
<td><p>4</p></td>
<td><p>Etiam vehicula luctus fermentum.</p></td>
<td><p>Ipsum</p></td>
<td></td>
</tr>
</tbody>
</table>

Etiam vehicula luctus fermentum. In vel metus congue, pulvinar lectus
vel, fermentum dui. Maecenas ante orci, egestas ut aliquet sit amet,
sagittis a magna. Aliquam ante quam, pellentesque ut dignissim quis,
laoreet eget est. Aliquam erat volutpat. Class aptent taciti sociosqu ad
litora torquent per conubia nostra, per inceptos himenaeos. Ut
ullamcorper justo sapien, in cursus libero viverra eget. Vivamus auctor
imperdiet urna, at pulvinar leo posuere laoreet. Suspendisse neque nisl,
fringilla at iaculis scelerisque, ornare vel dolor. Ut et pulvinar nunc.
Pellentesque fringilla mollis efficitur. Nullam venenatis commodo
imperdiet. Morbi velit neque, semper quis lorem quis, efficitur
dignissim ipsum. Ut ac lorem sed turpis imperdiet eleifend sit amet id
sapien.

Maecenas non lorem quis tellus placerat varius. Nulla facilisi. Aenean
congue fringilla justo ut aliquam. Mauris id ex erat. Nunc vulputate
neque vitae justo facilisis, non condimentum ante sagittis. Morbi
viverra semper lorem nec molestie. Maecenas tincidunt est efficitur
ligula euismod, sit amet ornare est vulputate.

Maecenas non lorem quis tellus placerat varius. Nulla facilisi. Aenean
congue fringilla justo ut aliquam. Mauris id ex erat. Nunc vulputate
neque vitae justo facilisis, non condimentum ante sagittis. Morbi
viverra semper lorem nec molestie. Maecenas tincidunt est efficitur
ligula euismod, sit amet ornare est vulputate.

In non mauris justo. Duis vehicula mi vel mi pretium, a viverra erat
efficitur. Cras aliquam est ac eros varius, id iaculis dui auctor. Duis
pretium neque ligula, et pulvinar mi placerat et. Nulla nec nunc sit
amet nunc posuere vestibulum. Ut id neque eget tortor mattis tristique.
Donec ante est, blandit sit amet tristique vel, lacinia pulvinar arcu.
Pellentesque scelerisque fermentum erat, id posuere justo pulvinar ut.
Cras id eros sed enim aliquam lobortis. Sed lobortis nisl ut eros
efficitur tincidunt. Cras justo mi, porttitor quis mattis vel, ultricies
ut purus. Ut facilisis et lacus eu cursus.In eleifend velit vitae libero
sollicitudin euismod.

Fusce vitae vestibulum velit. Pellentesque vulputate lectus quis
pellentesque commodo. Aliquam erat volutpat. Vestibulum in egestas
velit. Pellentesque fermentum nisl vitae fringilla venenatis. Etiam id
mauris vitae orci maximus ultricies. Cras fringilla ipsum magna, in
fringilla dui commodo a.

Etiam vehicula luctus fermentum. In vel metus congue, pulvinar lectus
vel, fermentum dui. Maecenas ante orci, egestas ut aliquet sit amet,
sagittis a magna. Aliquam ante quam, pellentesque ut dignissim quis,
laoreet eget est. Aliquam erat volutpat. Class aptent taciti sociosqu ad
litora torquent per conubia nostra, per inceptos himenaeos. Ut
ullamcorper justo sapien, in cursus libero viverra eget. Vivamus auctor
imperdiet urna, at pulvinar leo posuere laoreet. Suspendisse neque nisl,
fringilla at iaculis scelerisque, ornare vel dolor. Ut et pulvinar nunc.
Pellentesque fringilla mollis efficitur. Nullam venenatis commodo
imperdiet. Morbi velit neque, semper quis lorem quis, efficitur
dignissim ipsum. Ut ac lorem sed turpis imperdiet eleifend sit amet id
sapien.

- **Lorem ipsum dolor sit amet, consectetur adipiscing elit. **

Nunc ac faucibus odio. Vestibulum neque massa, scelerisque sit amet
ligula eu, congue molestie mi. Praesent ut varius sem. Nullam at
porttitor arcu, nec lacinia nisi. Ut ac dolor vitae odio interdum
condimentum. Vivamus dapibus sodales ex, vitae malesuada ipsum cursus
convallis. Maecenas sed egestas nulla, ac condimentum orci. Mauris diam
felis, vulputate ac suscipit et, iaculis non est. Curabitur semper arcu
ac ligula semper, nec luctus nisl blandit. Integer lacinia ante ac
libero lobortis imperdiet. Nullam mollis convallis ipsum, ac accumsan
nunc vehicula vitae. Nulla eget justo in felis tristique fringilla.
Morbi sit amet tortor quis risus auctor condimentum. Morbi in
ullamcorper elit. Nulla iaculis tellus sit amet mauris tempus fringilla.

- **Maecenas mauris lectus, lobortis et purus mattis, blandit dictum
  tellus. **

Maecenas non lorem quis tellus placerat varius. Nulla facilisi. Aenean
congue fringilla justo ut aliquam. Mauris id ex erat. Nunc vulputate
neque vitae justo facilisis, non condimentum ante sagittis. Morbi
viverra semper lorem nec molestie. Maecenas tincidunt est efficitur
ligula euismod, sit amet ornare est vulputate.

Nunc ac faucibus odio. Vestibulum neque massa, scelerisque sit amet
ligula eu, congue molestie mi. Praesent ut varius sem. Nullam at
porttitor arcu, nec lacinia nisi. Ut ac dolor vitae odio interdum
condimentum. Vivamus dapibus sodales ex, vitae malesuada ipsum cursus
convallis. Maecenas sed egestas nulla, ac condimentum orci. Mauris diam
felis, vulputate ac suscipit et, iaculis non est. Curabitur semper arcu
ac ligula semper, nec luctus nisl blandit. Integer lacinia ante ac
libero lobortis imperdiet. Nullam mollis convallis ipsum, ac accumsan
nunc vehicula vitae.
```
<sup><a href='#snippet-Samples.VerifyRtf.verified.md' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->


### Word


#### Verify a file

<!-- snippet: VerifyWord -->
<a id='snippet-VerifyWord'></a>
```cs
[Test]
public Task VerifyWord() =>
    VerifyFile("sample.docx");
```
<sup><a href='/src/Tests/Samples.cs#L23-L29' title='Snippet source file'>snippet source</a> | <a href='#snippet-VerifyWord' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->


#### Verify a Stream

<!-- snippet: VerifyWordStream -->
<a id='snippet-VerifyWordStream'></a>
```cs
[Test]
public Task VerifyWordStream()
{
    var stream = new MemoryStream(File.ReadAllBytes("sample.docx"));
    return Verify(stream, "docx");
}
```
<sup><a href='/src/Tests/Samples.cs#L31-L40' title='Snippet source file'>snippet source</a> | <a href='#snippet-VerifyWordStream' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->


#### Result

<!-- snippet: Samples.VerifyWord.verified.md -->
<a id='snippet-Samples.VerifyWord.verified.md'></a>
```md
# Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc ac faucibus odio. 

Vestibulum neque massa, scelerisque sit amet ligula eu, congue molestie
mi. Praesent ut varius sem. Nullam at porttitor arcu, nec lacinia nisi.
Ut ac dolor vitae odio interdum condimentum. **Vivamus dapibus sodales
ex, vitae malesuada ipsum cursus convallis. Maecenas sed egestas nulla,
ac condimentum orci.** Mauris diam felis, vulputate ac suscipit et,
iaculis non est. Curabitur semper arcu ac ligula semper, nec luctus nisl
blandit. Integer lacinia ante ac libero lobortis imperdiet. *Nullam
mollis convallis ipsum, ac accumsan nunc vehicula vitae.* Nulla eget
justo in felis tristique fringilla. Morbi sit amet tortor quis risus
auctor condimentum. Morbi in ullamcorper elit. Nulla iaculis tellus sit
amet mauris tempus fringilla.

Maecenas mauris lectus, lobortis et purus mattis, blandit dictum tellus.

- **Maecenas non lorem quis tellus placerat varius.**

- *Nulla facilisi.*

- <u>Aenean congue fringilla justo ut aliquam.</u>

- [<u>Mauris id ex erat.</u>](https://products.office.com/en-us/word)
  Nunc vulputate neque vitae justo facilisis, non condimentum ante
  sagittis.

- Morbi viverra semper lorem nec molestie.

- Maecenas tincidunt est efficitur ligula euismod, sit amet ornare est
  vulputate.

In non mauris justo. Duis vehicula mi vel mi pretium, a viverra erat
efficitur. Cras aliquam est ac eros varius, id iaculis dui auctor. Duis
pretium neque ligula, et pulvinar mi placerat et. Nulla nec nunc sit
amet nunc posuere vestibulum. Ut id neque eget tortor mattis tristique.
Donec ante est, blandit sit amet tristique vel, lacinia pulvinar arcu.
Pellentesque scelerisque fermentum erat, id posuere justo pulvinar ut.
Cras id eros sed enim aliquam lobortis. Sed lobortis nisl ut eros
efficitur tincidunt. Cras justo mi, porttitor quis mattis vel, ultricies
ut purus. Ut facilisis et lacus eu cursus.

In eleifend velit vitae libero sollicitudin euismod. Fusce vitae
vestibulum velit. Pellentesque vulputate lectus quis pellentesque
commodo. Aliquam erat volutpat. Vestibulum in egestas velit.
Pellentesque fermentum nisl vitae fringilla venenatis. Etiam id mauris
vitae orci maximus ultricies.

# Cras fringilla ipsum magna, in fringilla dui commodo a.

<table>
<colgroup>
<col style="width: 7%" />
<col style="width: 58%" />
<col style="width: 16%" />
<col style="width: 17%" />
</colgroup>
<tbody>
<tr class="odd">
<td></td>
<td>Lorem ipsum</td>
<td>Lorem ipsum</td>
<td>Lorem ipsum</td>
</tr>
<tr class="even">
<td>1</td>
<td>In eleifend velit vitae libero sollicitudin euismod.</td>
<td>Lorem</td>
<td></td>
</tr>
<tr class="odd">
<td>2</td>
<td>Cras fringilla ipsum magna, in fringilla dui commodo a.</td>
<td>Ipsum</td>
<td></td>
</tr>
<tr class="even">
<td>3</td>
<td>Aliquam erat volutpat.</td>
<td>Lorem</td>
<td></td>
</tr>
<tr class="odd">
<td>4</td>
<td>Fusce vitae vestibulum velit.</td>
<td>Lorem</td>
<td></td>
</tr>
<tr class="even">
<td>5</td>
<td>Etiam vehicula luctus fermentum.</td>
<td>Ipsum</td>
<td></td>
</tr>
</tbody>
</table>

Etiam vehicula luctus fermentum. In vel metus congue, pulvinar lectus
vel, fermentum dui. Maecenas ante orci, egestas ut aliquet sit amet,
sagittis a magna. Aliquam ante quam, pellentesque ut dignissim quis,
laoreet eget est. Aliquam erat volutpat. Class aptent taciti sociosqu ad
litora torquent per conubia nostra, per inceptos himenaeos. Ut
ullamcorper justo sapien, in cursus libero viverra eget. Vivamus auctor
imperdiet urna, at pulvinar leo posuere laoreet. Suspendisse neque nisl,
fringilla at iaculis scelerisque, ornare vel dolor. Ut et pulvinar nunc.
Pellentesque fringilla mollis efficitur. Nullam venenatis commodo
imperdiet. Morbi velit neque, semper quis lorem quis, efficitur
dignissim ipsum. Ut ac lorem sed turpis imperdiet eleifend sit amet id
sapien.

# Lorem ipsum dolor sit amet, consectetur adipiscing elit. 

Nunc ac faucibus odio. Vestibulum neque massa, scelerisque sit amet
ligula eu, congue molestie mi. Praesent ut varius sem. Nullam at
porttitor arcu, nec lacinia nisi. Ut ac dolor vitae odio interdum
condimentum. Vivamus dapibus sodales ex, vitae malesuada ipsum cursus
convallis. Maecenas sed egestas nulla, ac condimentum orci. Mauris diam
felis, vulputate ac suscipit et, iaculis non est. Curabitur semper arcu
ac ligula semper, nec luctus nisl blandit. Integer lacinia ante ac
libero lobortis imperdiet. Nullam mollis convallis ipsum, ac accumsan
nunc vehicula vitae. Nulla eget justo in felis tristique fringilla.
Morbi sit amet tortor quis risus auctor condimentum. Morbi in
ullamcorper elit. Nulla iaculis tellus sit amet mauris tempus fringilla.

## Maecenas mauris lectus, lobortis et purus mattis, blandit dictum tellus. 

Maecenas non lorem quis tellus placerat varius. Nulla facilisi. Aenean
congue fringilla justo ut aliquam. Mauris id ex erat. Nunc vulputate
neque vitae justo facilisis, non condimentum ante sagittis. Morbi
viverra semper lorem nec molestie. Maecenas tincidunt est efficitur
ligula euismod, sit amet ornare est vulputate.

In non mauris justo. Duis vehicula mi vel mi pretium, a viverra erat
efficitur. Cras aliquam est ac eros varius, id iaculis dui auctor. Duis
pretium neque ligula, et pulvinar mi placerat et. Nulla nec nunc sit
amet nunc posuere vestibulum. Ut id neque eget tortor mattis tristique.
Donec ante est, blandit sit amet tristique vel, lacinia pulvinar arcu.
Pellentesque scelerisque fermentum erat, id posuere justo pulvinar ut.
Cras id eros sed enim aliquam lobortis. Sed lobortis nisl ut eros
efficitur tincidunt. Cras justo mi, porttitor quis mattis vel, ultricies
ut purus. Ut facilisis et lacus eu cursus.

## In eleifend velit vitae libero sollicitudin euismod. 

Fusce vitae vestibulum velit. Pellentesque vulputate lectus quis
pellentesque commodo. Aliquam erat volutpat. Vestibulum in egestas
velit. Pellentesque fermentum nisl vitae fringilla venenatis. Etiam id
mauris vitae orci maximus ultricies. Cras fringilla ipsum magna, in
fringilla dui commodo a.

Etiam vehicula luctus fermentum. In vel metus congue, pulvinar lectus
vel, fermentum dui. Maecenas ante orci, egestas ut aliquet sit amet,
sagittis a magna. Aliquam ante quam, pellentesque ut dignissim quis,
laoreet eget est. Aliquam erat volutpat. Class aptent taciti sociosqu ad
litora torquent per conubia nostra, per inceptos himenaeos. Ut
ullamcorper justo sapien, in cursus libero viverra eget. Vivamus auctor
imperdiet urna, at pulvinar leo posuere laoreet. Suspendisse neque nisl,
fringilla at iaculis scelerisque, ornare vel dolor. Ut et pulvinar nunc.
Pellentesque fringilla mollis efficitur. Nullam venenatis commodo
imperdiet. Morbi velit neque, semper quis lorem quis, efficitur
dignissim ipsum. Ut ac lorem sed turpis imperdiet eleifend sit amet id
sapien.

<img src="media/image1.jpeg" style="width:6.69306in;height:4.46181in" />
```
<sup><a href='#snippet-Samples.VerifyWord.verified.md' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->


## File Samples

http://file-examples.com/


## Icon

[Swirl](https://thenounproject.com/term/swirl/1568686/) designed by [creativepriyanka](https://thenounproject.com/creativepriyanka) from [The Noun Project](https://thenounproject.com/).
