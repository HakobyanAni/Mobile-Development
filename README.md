# MVVM pattern

<b>The Model View ViewModel (MVVM)</b> is an architectural pattern used in software engineering that originated from Microsoft which is specialized in the Presentation Model design pattern. It is based on the Model-View-Controller pattern (MVC), and is targeted at modern UI development platforms (WPF and Silverlight) in which there is a UX developer who has different requirements than a more "traditional" developer. MVVM is a way of creating client applications that leverages core features of the WPF platform, allows for simple unit testing of application functionality, and helps developers and designers work together with less technical difficulties.

The <i>Model-View-ViewModel (MVVM)</i> pattern helps to cleanly separate the business and presentation logic of an application from its user interface (UI). Maintaining a clean separation between application logic and the UI helps to address numerous development issues and can make an application easier to test, maintain, and evolve. It can also greatly improve code re-use opportunities and allows developers and UI designers to more easily collaborate when developing their respective parts of an app.
In addition to understanding the responsibilities of each component, it's also important to understand how they interact with each other. At a high level, the view "knows about" the view model, and the view model "knows about" the model, but the model is unaware of the view model, and the view model is unaware of the view. Therefore, the view model isolates the view from the model, and allows the model to evolve independently of the view.

<b>VIEW</b> - A View is defined in XAML and should not have any logic in the code-behind. It binds to the view-model by only using data binding. 

<b>MODEL</b> - A Model is responsible for exposing data in a way that is easily consumable by WPF. It must implement INotifyPropertyChanged and/or INotifyCollectionChanged as appropriate.

<b>VIEWMODEL</b> - A ViewModel is a model for a view in the application or we can say as abstraction of the view. It exposes data relevant to the view and exposes the behaviors for the views, usually with Commands.



<h2> Xamarin </h2>
<b>Xamarin</b> is the name of a company that Microsoft acquired in 2016 and, at the same time, the name of a set of development tools and services that developers can use to build native apps for iOS, Android, and Windows in C#. <i>Xamarin’s main goal is to make it easier for .NET developers to build native apps for Android, iOS, and Windows reusing their existing skills.</i> The reason behind this goal is simple: building apps for Android requires you to know Java and Android Studio or Eclipse; building apps for iOS requires you to know Objective-C or Swift and Xcode; building apps for Windows requires you to know C# and Visual Studio. As an existing .NET developer, whether you are experienced or a beginner, getting to know all the possible platforms, languages, and development environments is extremely difficult, and costs are extremely high. 

<i> From a development point of view, Xamarin offers a number of flavors: Xamarin.iOS and Xamarin.Mac, libraries that wrap native Apple APIs you can use to build apps for iOS and macOS using C# and Visual Studio; Xamarin.Android, a library that wraps native Java and Google APIs you can use to build apps for Android using C# and Visual Studio; and Xamarin.Forms, an open-source library that allows you to share code across platforms and build apps that run on Android, iOS, and Windows from a single C# codebase.</i> The biggest benefit of Xamarin.Forms is that you write code once and it will run on all the supported platforms at no additional cost. Additionally, Xamarin integrates with the Visual Studio IDE on Windows and is also part of Visual Studio for Mac, so you can not only create cross-platform solutions, but also write code on different systems.  
