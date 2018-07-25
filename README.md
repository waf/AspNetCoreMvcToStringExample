# Render Razor to String in ASP.NET Core

An example project that shows how to render a razor view and optional controller to a string.
This repo contains the standard ASP.NET Core MVC project template, modified to support rendering the `HomeController.Index`
route to a string from the command line.

Unlike other solutions available on the web, this solution does not require an HttpContext, making
it suitable for scenarios like command line applications.

This is based heavily off of [RazorViewToStringRenderer](https://github.com/aspnet/Entropy/blob/93ee2cf54eb700c4bf8ad3251f627c8f1a07fb17/samples/Mvc.RenderViewToString/RazorViewToStringRenderer.cs),
however that proof-of-concept is out of date and no longer works.