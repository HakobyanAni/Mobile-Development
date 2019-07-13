# MVVM pattern

<b>The Model View ViewModel (MVVM)</b> is an architectural pattern used in software engineering that originated from Microsoft which is specialized in the Presentation Model design pattern. It is based on the Model-view-controller pattern (MVC), and is targeted at modern UI development platforms (WPF and Silverlight) in which there is a UX developer who has different requirements than a more "traditional" developer. MVVM is a way of creating client applications that leverages core features of the WPF platform, allows for simple unit testing of application functionality, and helps developers and designers work together with less technical difficulties.

<b>VIEW</b> - A View is defined in XAML and should not have any logic in the code-behind. It binds to the view-model by only using data binding. 

<b>MODEL</b> - A Model is responsible for exposing data in a way that is easily consumable by WPF. It must implement INotifyPropertyChanged and/or INotifyCollectionChanged as appropriate.

<b>VIEWMODEL</b> - A ViewModel is a model for a view in the application or we can say as abstraction of the view. It exposes data relevant to the view and exposes the behaviors for the views, usually with Commands.



<h2> Xamarin </h2>
<b>Xamarin</b> is the name of a company that Microsoft acquired in 2016 and, at the same time, the name of a set of development tools and services that developers can use to build native apps for iOS, Android, and Windows in C#. <i>Xamarin’s main goal is to make it easier for .NET developers to build native apps for Android, iOS, and Windows reusing their existing skills.</i> The reason behind this goal is simple: building apps for Android requires you to know Java and Android Studio or Eclipse; building apps for iOS requires you to know Objective-C or Swift and Xcode; building apps for Windows requires you to know C# and Visual Studio. As an existing .NET developer, whether you are experienced or a beginner, getting to know all the possible platforms, languages, and development environments is extremely difficult, and costs are extremely high. 
