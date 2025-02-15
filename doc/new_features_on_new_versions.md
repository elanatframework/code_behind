# New features on new versions

**New releases policy:** Our effort at Elanat team is to add new features to new releases. We put a lot of effort into testing the CodeBehind framework before releasing new versions, but usually adding new features causes a series of new bugs. We receive bug reports very quickly and provide new sub-versions with bug fixes. So try to always use the latest versions of the CodeBehind framework.

## Early versions

The first version of CodeBehind is based on .NET Core version 7.0; if the version of .NET Core is updated in a version compared to the previous one, it will be explained in the description section of that new version.

## Version 1.7

**New features:**
- The possibility of creating a page view without having to follow the MVC pattern
  - Possibility to create only view without controller and model
  - Possibility to create model and view without controller

## Version 1.8

**New features:**
- Razor syntax support 
- Template support
  - Added return template
  - External template
- Added option
  - The option to specify the path of aspx files
  - possibility of rewriting the path of aspx files as a directory name
  - Ability to remove additional lines, tabs, and spaces
- Namespace and dll for CodeBehind view class
- Added HtmlData classes
- Constructor method 

**This version guarantees 100% Code-Behind support**

**Problems that were solved:**
- The problem of executing the path with extra characters after the slash character was solved.
- Fixed the problem of replacing the class file with failed compilation in the last successful compilation.

### Version 1.8.1

**Problems that were solved:**
- Solving the problem of removing one or two characters after Razor syntax.

## Version 1.9

**New features:**
- Ability to add layout page
  - Ability to send data from the current page to the layout page
  - The possibility of calling external pages from the view section
- The possibility of preventing the direct execution of some pages (such as separate header and footer)
- Ability to call aspx files in their own path, after rewriting
- Improvements in the trim operation at the beginning of the aspx file

**Problems that were solved:**
- The problem of loading the constructor model without a controller was solved.
- Fixed else detection problem for if in Razor syntax.

### Version 1.9.1

**Problems that were solved:**
- A mistake caused the arguments of the model constructor to be wrongly placed in the controller constructor; this problem has been fixed now.
- In this version, if the CodeBehind framework is activated for the first time, it will no longer give the wwwroot directory missing error and a default welcome file will be placed in it.
- The error that occurred when activating the set break for layout page (`set_break_for_layout_page=true`) option was resolved.
- The problem of not automatically moving from the wwwroot path to the view path has been solved.
- The problem of not applying, ignoring the default Default.aspx files to rewrite as a directory, was solved.

### Version 1.9.2

**New features:**
- In this version and later, in the methods of the final view class, when creating a new instance of the controller class, the term controller is used instead of the term CurrentController
- In this version and later, the context inside the astx files are added at the beginning of the aspx file

**Problems that were solved:**
- In the standard syntax, the problem of identifying template blocks that have the next line character or Tab character after the template name was solved.

### Version 1.9.3

**Problems that were solved:**
- Fixed the problem of naming templates with numbers in the standard syntax.
- Solving the problem of not ignoring two consecutive at sign (@) in conditional blocks and loop blocks.

## Version 2.0

**New features:**
- Ability to add data to ViewData in controller and model
- The addition of download API and the possibility of downloading files from executive pages in all three sections, view, model and controller
- The addition of a global template file to support all view pages
- The possibility of adding more templates, by separating the semicolon character (;)
- New option to support cshtml files in the options file
- Added default pages (include layout) after first run

## Version 2.1

**New features:**
- Ability to change the view in the controller
- Ability to transfer template block data in ViewData
- Complete rewriting of codes related to new lines and backslash of executable files
- Complete rewriting of the codes related to creating files
- And a series of minor changes and improvements

**Problems that were solved:**
- Deleting unused ex variable from the final view class.

### Version 2.1.1

**Problems that were solved:**
- Resolving the problem of Razor syntax page attributes ending with the less-than (<) character.

### Version 2.1.2

**New features:**
- Complete rewrite codes related of page attribute recognition in Razor syntax
- Adding the view file path comment above their methods in the view class

## Version 2.2

**New features:**
- Added CallerViewPath and CallerViewDirectoryPath to view, model and controller
- New option to display minor errors in the options file
- Improved debugging and improved `views_compile_error.log` error file
- The possibility of creating a controller without requiring the existence of the PageLoad method
- Added error page to default pages
- Added the path of the error page in the options file
- Added FoundPage attribute to detect page execution
- Improved detection of closed brackets related to server codes, after apostrophes
- Added PageLoad method to Controller abstract class
- Added new feature section for better route control
- The ability to create model, without the need to add an abstract
- The ability to create a CodeBehindConstructor method without the need for input arguments
- And a series of minor changes and improvements

## Version 2.3

**New features:**
- Ability to specify View along with Model from all Controllers
  - The possibility of loading pages with the model in the LoadPage method in View pages
- Support strings written from the previous Controller
- Added possible to prevent access to Default.aspx
  - Added the prevent access to Default.aspx in the options file
- Added StaticObject class
- And a series of minor changes and improvements

**Problems that were solved:**
- In cases where the current View is wrongly requested from the Controller, the loop is avoided.

## Version 2.4

**New features:**
- New feature for route configuration
- The possibility of running the controller with the text name of the controller
- Applying multi-threaded processing to create the View class
- Marking the View class for when new View pages are added
- Ability to set page attributes with lowercase letters in standard syntax
- Ability to add text tag with multiple lines in Razor syntax
- And a series of minor changes and improvements

**In this version, it is possible to give preference to the controller**

**Problems that were solved:**
- Fixed the problem of finding the `Microsoft.AspNetCore.App` directory for some operating systems.
- Fixed problem matching projects whose name does not match for namespace name.

### Version 2.4.1

**Problems that were solved:**
- Fixing the problem of calling the pages that were requested with the query string.

### Version 2.4.2

**Problems that were solved:**
- Fixed the problem of not creating a query string after calling the pages in the `Run` method.

### Version 2.4.3

**New features:**
- Adding Name and NameCollection classes in HtmlData namespase

**Problems that were solved:**
- Avoiding adding the same query.

## Version 2.5

**New features:**
- Adding middleware for easier configuration

### Version 2.5.1

**New features:**
- Default.aspx not being added in Section when `prevent access default aspx` is enabled
- And a series of minor changes and improvements

## Version 2.6

**New features:**
- Support for constructor method of Controller class and Model class
- Improved detection of View page attributes in standard syntax

## Version 2.7

**New features:**
- Adding CodeBehind roles
  - Adding role access middleware
  - The possibility of preventing the access of the rolls to the routes
  - Ability to define action and give action access for roles
  - Ability to define actions for each user based on the session

### Version 2.7.1

**Problems that were solved:**
- Correcting a typo in the `UseRollAccess` middleware and changing it to `UseRoleAccess`.

## Version 2.8

**New features:**
- Adding cache
- Improved numbering of aspx file methods in the View final class

## Version 2.9

**New features:**
- Added WebFormsJS
- Added support for Web-Forms controls
- Added PostBack and GetBack method
- Added possibility to ignore Layout through Controller class and Model class and View page
- Added possibility to ignore View through Model class
- Added `IgnoreAll` method in Controller class and Model class
- Automatic moving of dll files from the `wwwroot/dll` path to the designated View path
- And a series of minor changes and improvements

**In this version, access to Web-Forms controls has been added**

### Version 2.9.1

**Problems that were solved:**
- Fixing server response location problem in WebFormsJS.

### Version 2.9.2

**Problems that were solved:**
- Better identification of the `PostBack` method in submit type inputs in WebFormsJS.

## Version 3.0

**New features:**
- Improved implementation structure of Action Controls for the first browser request
- Extending WebForms class methods to support new WebFormsJS features
- Support for specifying the location of the tag to place the data received from the server in WebFormsJS
- Added new `web-forms` tag in WebFormsJS
- Multiple ViewState types in PostBack and GetBack methods in WebFormsJS
- Support for Pre Runners and running them back to back in the queue in WebFormsJS
- Script code execution support in WebFormsJS
- Support delay and repetition in time intervals in WebFormsJS
- Support for negative indexes to access values ​​from the end of the list in WebFormsJS
- Support for calling URLs in WebFormsJS
- Improving the functionality of HtmlData classes by adding new methods
- And a series of minor changes and improvements

## Version 3.1

**New features:**
- Better compatibility with older browsers in WebFormsJS
- And a series of minor changes and improvements

**Problems that were solved:**
- Solved the problem of other operating systems not working due to the wrong determination of the separator of directories in the path.

## Version 3.2

**New features:**
- Support for default Controller
  - Support for Section mode in the default Controller

### Version 3.2.1

**Problems that were solved:**
- Fixed extra line issue in Razor syntax code blocks
- Fixed a minor problem in creating the list of Sections in Controllers

### Version 3.2.2

**New features:**
- Adding manual cache class
- Improving the source code of CodeBehind classes

**Problems that were solved:**
- Resolving the problem of detecting `else` after `else if` in Razor syntax
- Adaptation of WebForms class with delay and period

## Version 3.3

**New features:**
- Adding two middleware named `UseCodeBehindNextNotFound` and `UseCodeBehindRouteNextNotFound` to continue the process if the page or controller is not found

**Problems that were solved:**
- Resolving the problem of detecting multi line between `text` tag in Razor syntax code blocks
- Solving the problem of ignoring cache parameters
- Solving the problem of additional `default` code in the `switch case` code for load Controllers
- A series of other minor corrections

## Version 3.4

**New features:**
- Structure improvements for faster execution and increased performance

**Problems that were solved:**
- Fixed issue of not allocating controller attributes

### Version 3.4.1

**Problems that were solved:**
- The problem of program break in calling View was solved

## Version 3.5

**New features:**
- Ability to support conditional expressions and loops without needing brackets in Razor syntax
- New options for accessing controllers, in lower case
- Adding an option to create or not create default pages in the options file
- Adding option to ignore the controller name prefix and suffix
- Adding option to convert two underlines into a single dash to call the controller name
- And a series of minor changes and improvements

**Problems that were solved:**
- Fixed location tag detection issue when calling back in WebFormsJS

## Version 3.6

**New features:**
- Improved performance for making final View classes
- Added `SetViewPath` method in Controller class
- Added `SetErrorPage` method in Controller class
- And a series of minor changes and improvements

**Problems that were solved:**
- Fixing the problem of not adding the log file to display errors in View files

### Version 3.6.1

**New features:**
- Adding extension method named `Has` to be used instead of `string.IsNullOrEmpty`
- Creating a null state for Layout to set the global Layout value

## Version 3.7

**New features:**
- The possibility of IgnoreAll in the Control method in the Controller class
- The possibility of appending the instance created from the WebForms class to another created instance
- Ability to add new text and tags at the beginning of the tag
- Ability to cache action control
- The possibility of adding text at the beginning of the tag
- The possibility of creating a tag at the beginning of the tag
- Ability to delete all option tags
- Ability to delete all checkbox tags
- Added the ability to focus on tags
- Ability to change the URL in the user's browser
- Added new cache and session features with the ability to insert and delete and delete all and cache duration
- Ability to temporarily store values ​​in the browser cache session
- The possibility of assigning random numbers to the attributes of tags
- Ability to assign time and date
- Ability to assign session and cache
- Ability to assign scripts
- Other features and improvements

### Version 3.7.1

**Problems that were solved:**
- Fixing the problem of saving title tags

### Version 3.7.2

**Problems that were solved:**
- Add trim to better detect Action Controls responses

## Version 3.8

**New features:**
- Change the default template
- Ability to add a new tag, before and after the tag

## Version 3.9

**New features:**
- New TagBack feature for executing web-forms tag control actions
- Ability to assign Events to HTML tags
- Ability to delete action controls of the WebForms class
- New method for inserting web-forms tag without first render
- The possibility of deleting events
- Other features and improvements

**In this version it is possible to add events in WebForms Core**

### Version 3.9.1

**Problems that were solved:**
- Fixing the problem of having double cue instead of cue in event methods

### Version 3.9.2

**New features:**
- Security coordination with MapStaticAssets middleware in .NET 9

## Version 4.0

**New features:**
- Support for multiple responses in Action Controls
- Possibility of internal client caching on server responses
- New feature of sending values ​​embedded in the names of submit inputs
- Ability to select parent input places in WebForms Core
- New ability to remove parent tag in WebForms Core
- New ability to fetch cookie in WebForms Core
- Added AddLine method to support extended multi-command methods
- And a series of minor changes and improvements

## Version 4.1

**New features:**
- WebSocket protocol support in WebForms Core technology
- New SendBack feature for sending all types of data
