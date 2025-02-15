### Load aspx page finally result in another aspx page

Before we explain this tutorial, it is necessary to know that the method we are explaining will recreate and execute an instance of the final View class. This is not recommended under normal circumstances.

Instead, you can use the `LoadPage` method on View pages.

Example:
```html
...
<div>
@LoadPage(/menu/left.aspx, context);
</div>
...
```

The following example shows the power of CodeBehind:

aspx page (razor syntax)
```cshtml
@page
@controller YourProjectName.DefaultController
@model YourProjectName.DefaultModel
<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <title>@model.PageTitle</title>
</head>
<body>
    @model.LeftMenuValue
    <div class="main_content">
        @model.MainContentValue
    </div>
    @model.RightMenuValue
</body>
</html>
```

aspx page (standard syntax)
```aspx
<%@ Page Controller="YourProjectName.DefaultController" Model="YourProjectName.DefaultModel" %>
<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <title><%=model.PageTitle%></title>
</head>
<body>
    <%=model.LeftMenuValue%>
    <div class="main_content">
        <%=model.MainContentValue%>
    </div>
    <%=model.RightMenuValue%>
</body>
</html>
```

Controller class
```csharp
using CodeBehind;

namespace YourProjectName
{
    public partial class DefaultController : CodeBehindController
    {
        public void PageLoad(HttpContext context)
        {
            public DefaultModel model = new DefaultModel();

            model.PageTitle = "My Title";

            CodeBehindExecute execute = new CodeBehindExecute();

            // Add Left Menu Page
            model.LeftMenuValue = execute.Run(context, "/menu/left.aspx");

            // Add Right Menu Page
            model.RightMenuValue = execute.Run(context, "/menu/right.aspx");

            // Add Main Content Page
            model.MainContentValue = execute.Run(context, "/pages/main.aspx");

            View(model);
        }
    }
}
```

Each of the pages left.aspx, right.aspx and main.aspx can also call several other aspx files; these calls can definitely be dynamic and an add-on can be executed that the kernel programmers don't even know about.

You can also call a page without specifying an HttpContext. You should note that query string and HttpContext data are not supported in this method.

```csharp
CodeBehindExecute execute = new CodeBehindExecute();
model.MainContentValue = execute.Run("/pages/main.aspx");
```

You can even call pages with query strings.

```csharp
model.MainContentValue = execute.Run(context, "/pages/main.aspx?template=1");
```

You can also call a path that is determined at runtime and may change over time.

```csharp
string MainPage = Pages.GetDefaultPage();
model.MainContentValue = execute.Run(context, MainPage);
```

Note: If you have enabled the Rewrite Aspx File To Directory option and the Access Aspx File After Rewrite option is disabled, either you must enter the path argument in the Run method without an extension or use the RunFullPath method instead of the Run method.

Enjoy CodeBehind, but be careful not to loop the program! (Don't call pages that call the current page)
