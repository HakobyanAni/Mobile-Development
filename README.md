# Mobile Development


Dependency service

Static class that provides the Get<T>(DependencyFetchTarget) factory method for retrieving platform-specific implementations of the specified type T.
  
  
  Xamarin.Forms Custom Renderers
  
  Custom renderers provide a powerful approach for customizing the appearance and behavior of Xamarin.Forms controls. They can be used for small styling changes or sophisticated platform-specific layout and behavior customization. This article provides an introduction to custom renderers, and outlines the process for creating a custom renderer.
  Xamarin.Forms Pages, Layouts and Controls present a common API to describe cross-platform mobile user interfaces. Each page, layout, and control is rendered differently on each platform, using a Renderer class that in turn creates a native control (corresponding to the Xamarin.Forms representation), arranges it on the screen, and adds the behavior specified in the shared code. However, implementing a custom renderer class to perform a simple control customization is often a heavy-weight response. Effects simplify this process, and are typically used for small styling changes.
