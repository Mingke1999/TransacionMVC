# MyMVC
 
## Controller
ModelState.IsValid -> force not empty
viewBag.Action and partial
## View
shared view with same folder/ API  -> _name.cshtml
## Model
Data models and static methods
## wwwroot
expose to all public

## _ViewImports.cshtml
@using MyMVC.Models
@addTagHelper *, Microsoft.AspNetCore.Mvc.TagHelpers
all imports
## _ViewStart.cshtml
all imported view parts
@{
    Layout = "_Layout";
}
## Shared/_Layout.cshtml
all resuable html part
