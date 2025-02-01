using Microsoft.AspNetCore.Http;

namespace CodeBehind
{
    public class WebForms
    {
        private NameValueCollection WebFormsData = new NameValueCollection();

        // For Extension
        public void AddLine(string Name, string Value) => WebFormsData.Add(Name, Value);

        // Add
        public void AddId(string InputPlace, string Id) => WebFormsData.Add("ai" + InputPlace, Id);
        public void AddName(string InputPlace, string Name) => WebFormsData.Add("an" + InputPlace, Name);
        public void AddValue(string InputPlace, string Value) => WebFormsData.Add("av" + InputPlace, Value);
        public void AddClass(string InputPlace, string Class) => WebFormsData.Add("ac" + InputPlace, Class);
        public void AddStyle(string InputPlace, string Style) => WebFormsData.Add("as" + InputPlace, Style);
        public void AddStyle(string InputPlace, string Name, string Value) => WebFormsData.Add("as" + InputPlace, Name + ':' + Value);
        public void AddOptionTag(string InputPlace, string Text, string Value, bool Selected = false) => WebFormsData.Add("ao" + InputPlace, Value + '|' + Text + (Selected ? "|1" : ""));
        public void AddCheckBoxTag(string InputPlace, string Text, string Value, bool Checked = false) => WebFormsData.Add("ak" + InputPlace, Value + '|' + Text + (Checked ? "|1" : ""));
        public void AddTitle(string InputPlace, string Title) => WebFormsData.Add("al" + InputPlace, Title);
        public void AddText(string InputPlace, string Text) => WebFormsData.Add("at" + InputPlace, Text.Replace('\n'.ToString(), "$[ln];"));
        public void AddTextToUp(string InputPlace, string Text) => WebFormsData.Add("pt" + InputPlace, Text.Replace('\n'.ToString(), "$[ln];"));
        public void AddAttribute(string InputPlace, string Attribute, string Value = "") => WebFormsData.Add("aa" + InputPlace, Attribute + '|' + Value);
        public void AddTag(string InputPlace, string TagName, string Id = "") => WebFormsData.Add("nt" + InputPlace, TagName + (!string.IsNullOrEmpty(Id) ? '|' + Id : ""));
        public void AddTagToUp(string InputPlace, string TagName, string Id = "") => WebFormsData.Add("ut" + InputPlace, TagName + (!string.IsNullOrEmpty(Id) ? '|' + Id : ""));
        public void AddTagBefore(string InputPlace, string TagName, string Id = "") => WebFormsData.Add("bt" + InputPlace, TagName + (!string.IsNullOrEmpty(Id) ? '|' + Id : ""));
        public void AddTagAfter(string InputPlace, string TagName, string Id = "") => WebFormsData.Add("ft" + InputPlace, TagName + (!string.IsNullOrEmpty(Id) ? '|' + Id : ""));

        // Set
        public void SetId(string InputPlace, string Id) => WebFormsData.Add("si" + InputPlace, Id);
        public void SetName(string InputPlace, string Name) => WebFormsData.Add("sn" + InputPlace, Name);
        public void SetValue(string InputPlace, string Value) => WebFormsData.Add("sv" + InputPlace, Value);
        public void SetClass(string InputPlace, string Class) => WebFormsData.Add("sc" + InputPlace, Class);
        public void SetStyle(string InputPlace, string Style) => WebFormsData.Add("ss" + InputPlace, Style);
        public void SetStyle(string InputPlace, string Name, string Value) => WebFormsData.Add("ss" + InputPlace, Name + ':' + Value);
        public void SetOptionTag(string InputPlace, string Text, string Value, bool Selected = false) => WebFormsData.Add("so" + InputPlace, Value + '|' + Text + (Selected ? "|1" : ""));
        public void SetChecked(string InputPlace, bool Checked = false) => WebFormsData.Add("sk" + InputPlace, Checked ? "1" : "0");
        public void SetCheckBoxTagToList(string InputPlace, string Text, string Value, bool Checked = false) => WebFormsData.Add("sk" + InputPlace, Value + '|' + Text + (Checked ? "|1" : ""));
        public void SetTitle(string InputPlace, string Title) => WebFormsData.Add("sl" + InputPlace, Title);
        public void SetText(string InputPlace, string Text) => WebFormsData.Add("st" + InputPlace, Text.Replace('\n'.ToString(), "$[ln];"));
        public void SetAttribute(string InputPlace, string Attribute, string Value = "") => WebFormsData.Add("sa" + InputPlace, Attribute + (!string.IsNullOrEmpty(Value) ? '|' + Value : ""));
        public void SetWidth(string InputPlace, string Width) => WebFormsData.Add("sw" + InputPlace, Width);
        public void SetWidth(string InputPlace, int Width) => SetWidth(InputPlace, Width.ToString() + "px");
        public void SetHeight(string InputPlace, string Height) => WebFormsData.Add("sh" + InputPlace, Height);
        public void SetHeight(string InputPlace, int Height) => SetHeight(InputPlace, Height.ToString() + "px");

        // Insert
        public void InsertId(string InputPlace, string Id) => WebFormsData.Add("ii" + InputPlace, Id);
        public void InsertName(string InputPlace, string Name) => WebFormsData.Add("in" + InputPlace, Name);
        public void InsertValue(string InputPlace, string Value) => WebFormsData.Add("iv" + InputPlace, Value);
        public void InsertClass(string InputPlace, string Class) => WebFormsData.Add("ic" + InputPlace, Class);
        public void InsertStyle(string InputPlace, string Style) => WebFormsData.Add("is" + InputPlace, Style);
        public void InsertStyle(string InputPlace, string Name, string Value) => WebFormsData.Add("is" + InputPlace, Name + ':' + Value);
        public void InsertOptionTag(string InputPlace, string Text, string Value, bool Selected = false) => WebFormsData.Add("io" + InputPlace, Value + '|' + Text + (Selected ? "|1" : ""));
        public void InsertCheckBoxTag(string InputPlace, string Text, string Value, bool Checked = false) => WebFormsData.Add("ik" + InputPlace, Value + '|' + Text + (Checked ? "|1" : ""));
        public void InsertTitle(string InputPlace, string Title) => WebFormsData.Add("il" + InputPlace, Title);
        public void InsertText(string InputPlace, string Text) => WebFormsData.Add("it" + InputPlace, Text.Replace('\n'.ToString(), "$[ln];"));
        public void InsertAttribute(string InputPlace, string Attribute, string Value = "") => WebFormsData.Add("ia" + InputPlace, Attribute + (!string.IsNullOrEmpty(Value) ? '|' + Value : ""));

        // Delete
        public void DeleteId(string InputPlace) => WebFormsData.Add("di" + InputPlace, "1");
        public void DeleteName(string InputPlace) => WebFormsData.Add("dn" + InputPlace, "1");
        public void DeleteValue(string InputPlace) => WebFormsData.Add("dv" + InputPlace, "1");
        public void DeleteClass(string InputPlace, string ClassName) => WebFormsData.Add("dc" + InputPlace, ClassName);
        public void DeleteStyle(string InputPlace, string StyleName) => WebFormsData.Add("ds" + InputPlace, StyleName);
        public void DeleteOptionTag(string InputPlace, string Value) => WebFormsData.Add("do" + InputPlace, Value);
        public void DeleteAllOptionTag(string InputPlace) => WebFormsData.Add("do" + InputPlace, "*");
        public void DeleteCheckBoxTag(string InputPlace, string Value) => WebFormsData.Add("dk" + InputPlace, Value);
        public void DeleteAllCheckBoxTag(string InputPlace) => WebFormsData.Add("dk" + InputPlace, "*");
        public void DeleteTitle(string InputPlace) => WebFormsData.Add("dl" + InputPlace, "1");
        public void DeleteText(string InputPlace) => WebFormsData.Add("dt" + InputPlace, "1");
        public void DeleteAttribute(string InputPlace, string Attribute) => WebFormsData.Add("da" + InputPlace, Attribute);
        public void Delete(string InputPlace) => WebFormsData.Add("de" + InputPlace, "1");
        public void DeleteParent(string InputPlace) => WebFormsData.Add("dp" + InputPlace, "1");


        // Other
        public void SetBackgroundColor(string InputPlace, string Color) => WebFormsData.Add("bc" + InputPlace, Color);
        public void SetTextColor(string InputPlace, string Color) => WebFormsData.Add("tc" + InputPlace, Color);
        public void SetFontName(string InputPlace, string Name) => WebFormsData.Add("fn" + InputPlace, Name);
        public void SetFontSize(string InputPlace, string Size) => WebFormsData.Add("fs" + InputPlace, Size);
        public void SetFontSize(string InputPlace, int Size) => WebFormsData.Add("fs" + InputPlace, Size + "px");
        public void SetFontBold(string InputPlace, bool Bold) => WebFormsData.Add("fb" + InputPlace, Bold ? "1" : "0");
        public void SetVisible(string InputPlace, bool Visible) => WebFormsData.Add("vi" + InputPlace, Visible ? "1" : "0");
        public void SetTextAlign(string InputPlace, string Align) => WebFormsData.Add("ta" + InputPlace, Align);
        public void SetReadOnly(string InputPlace, bool ReadOnly) => WebFormsData.Add("sr" + InputPlace, ReadOnly ? "1" : "0");
        public void SetDisabled(string InputPlace, bool Disabled) => WebFormsData.Add("sd" + InputPlace, Disabled ? "1" : "0");
        public void SetFocus(string InputPlace, bool Focus) => WebFormsData.Add("sf" + InputPlace, Focus ? "1" : "0");
        public void SetMinLength(string InputPlace, int Length) => WebFormsData.Add("mn" + InputPlace, Length.ToString());
        public void SetMaxLength(string InputPlace, int Length) => WebFormsData.Add("mx" + InputPlace, Length.ToString());
        public void SetSelectedValue(string InputPlace, string Value) => WebFormsData.Add("ts" + InputPlace, Value);
        public void SetSelectedIndex(string InputPlace, int Index) => WebFormsData.Add("ti" + InputPlace, Index.ToString());
        public void SetCheckedValue(string InputPlace, string Value, bool Selected) => WebFormsData.Add("ks" + InputPlace, Value + "|" + (Selected ? "1" : "0"));
        public void SetCheckedIndex(string InputPlace, int Index, bool Selected) => WebFormsData.Add("ki" + InputPlace, Index.ToString() + "|" + (Selected ? "1" : "0"));
        public void CallScript(string ScriptText) => WebFormsData.Add("_", ScriptText.Replace('\n'.ToString(), "$[ln];"));
        public void LoadUrl(string InputPlace, string Url) => WebFormsData.Add("lu" + InputPlace, Url);
        public void ChangeUrl(string Url) => WebFormsData.Add("cu", Url);
        public void RemoveSessionCache(string CacheKey) => WebFormsData.Add("rs", CacheKey);
        public void RemoveAllSessionCache() => WebFormsData.Add("rs", "*");
        public void RemoveCache(string CacheKey) => WebFormsData.Add("rd", CacheKey);
        public void RemoveAllCache() => WebFormsData.Add("rd", "*");
        public void SetSessionCache() => WebFormsData.Add("cs", "1");
        public void SetCache(int Second) => WebFormsData.Add("cd", Second.ToString());
        public void SetCache() => WebFormsData.Add("cd", "*");

        // Increase
        public void IncreaseMinLength(string InputPlace, int Value) => WebFormsData.Add("+n" + InputPlace, Value.ToString());
        public void IncreaseMaxLength(string InputPlace, int Value) => WebFormsData.Add("+x" + InputPlace, Value.ToString());
        public void IncreaseFontSize(string InputPlace, int Value) => WebFormsData.Add("+f" + InputPlace, Value.ToString());
        public void IncreaseWidth(string InputPlace, int Value) => WebFormsData.Add("+w" + InputPlace, Value.ToString());
        public void IncreaseHeight(string InputPlace, int Value) => WebFormsData.Add("+h" + InputPlace, Value.ToString());
        public void IncreaseValue(string InputPlace, int Value) => WebFormsData.Add("+v" + InputPlace, Value.ToString());

        // Descrease
        public void DescreaseMinLength(string InputPlace, int Value) => WebFormsData.Add("-n" + InputPlace, Value.ToString());
        public void DescreaseMaxLength(string InputPlace, int Value) => WebFormsData.Add("-x" + InputPlace, Value.ToString());
        public void DescreaseFontSize(string InputPlace, int Value) => WebFormsData.Add("-f" + InputPlace, Value.ToString());
        public void DescreaseWidth(string InputPlace, int Value) => WebFormsData.Add("-w" + InputPlace, Value.ToString());
        public void DescreaseHeight(string InputPlace, int Value) => WebFormsData.Add("-h" + InputPlace, Value.ToString());
        public void DescreaseValue(string InputPlace, int Value) => WebFormsData.Add("-v" + InputPlace, Value.ToString());

        // Event
        public void SetPostEvent(string InputPlace, string HtmlEvent) => WebFormsData.Add("Ep" + InputPlace, HtmlEvent);
        public void SetPostEventAdding(string InputPlace, string HtmlEvent) => WebFormsData.Add("Ep" + InputPlace, HtmlEvent + "|+");
        public void SetPostEventTo(string InputPlace, string HtmlEvent, string OutputPlace) => WebFormsData.Add("Ep" + InputPlace, HtmlEvent + "|" + OutputPlace);
        public void SetPostEventListener(string InputPlace, string HtmlEventListener) => WebFormsData.Add("EP" + InputPlace, HtmlEventListener);
        public void SetPostEventListenerAdding(string InputPlace, string HtmlEventListener) => WebFormsData.Add("EP" + InputPlace, HtmlEventListener + "|+");
        public void SetPostEventListenerTo(string InputPlace, string HtmlEventListener, string OutputPlace) => WebFormsData.Add("EP" + InputPlace, HtmlEventListener + "|" + OutputPlace);
        public void SetGetEvent(string InputPlace, string HtmlEvent, string Path = null) => WebFormsData.Add("Eg" + InputPlace, HtmlEvent + "|" + (Path.Has() ? Path : "#"));
        public void SetGetEvent(string InputPlace, string HtmlEvent, string OutputPlace, string Path = null) => WebFormsData.Add("Eg" + InputPlace, HtmlEvent + "|" + (Path.Has() ? Path : "#") + "|" + OutputPlace);
        public void SetGetEventInForm(string InputPlace, string HtmlEvent) => WebFormsData.Add("Eg" + InputPlace, HtmlEvent);
        public void SetGetEventInForm(string InputPlace, string HtmlEvent, string OutputPlace) => WebFormsData.Add("Eg" + InputPlace, HtmlEvent + "|" + OutputPlace);
        public void SetGetEventListener(string InputPlace, string HtmlEventListener, string Path = null) => WebFormsData.Add("EG" + InputPlace, HtmlEventListener + "|" + (Path.Has() ? Path : "#"));
        public void SetGetEventListener(string InputPlace, string HtmlEventListener, string OutputPlace, string Path = null) => WebFormsData.Add("EG" + InputPlace, HtmlEventListener + "|" + (Path.Has() ? Path : "#") + "|" + OutputPlace);
        public void SetGetEventInFormListener(string InputPlace, string HtmlEventListener) => WebFormsData.Add("EG" + InputPlace, HtmlEventListener);
        public void SetGetEventInFormListener(string InputPlace, string HtmlEventListener, string OutputPlace) => WebFormsData.Add("EG" + InputPlace, HtmlEventListener + "|" + OutputPlace);
        public void SetTagEvent(string InputPlace, string HtmlEvent, string OutputPlace) => WebFormsData.Add("Et" + InputPlace, HtmlEvent + "|" + OutputPlace);
        public void SetTagEventListener(string InputPlace, string HtmlEvent, string OutputPlace) => WebFormsData.Add("ET" + InputPlace, HtmlEvent + "|" + OutputPlace);
        public void RemovePostEvent(string InputPlace, string HtmlEvent) => WebFormsData.Add("Rp" + InputPlace, HtmlEvent);
        public void RemoveGetEvent(string InputPlace, string HtmlEvent) => WebFormsData.Add("Rg" + InputPlace, HtmlEvent);
        public void RemoveTagEvent(string InputPlace, string HtmlEvent) => WebFormsData.Add("Rt" + InputPlace, HtmlEvent);
        public void RemovePostEventListener(string InputPlace, string HtmlEventListener) => WebFormsData.Add("RP" + InputPlace, HtmlEventListener);
        public void RemoveGetEventListener(string InputPlace, string HtmlEventListener) => WebFormsData.Add("RG" + InputPlace, HtmlEventListener);
        public void RemoveTagEventListener(string InputPlace, string HtmlEventListener) => WebFormsData.Add("RT" + InputPlace, HtmlEventListener);

        // Save
        public void SaveId(string InputPlace, string Key = ".") => WebFormsData.Add("@gi" + InputPlace, Key);
        public void SaveName(string InputPlace, string Key = ".") => WebFormsData.Add("@gn" + InputPlace, Key);
        public void SaveValue(string InputPlace, string Key = ".") => WebFormsData.Add("@gv" + InputPlace, Key);
        public void SaveValueLength(string InputPlace, string Key = ".") => WebFormsData.Add("@ge" + InputPlace, Key);
        public void SaveClass(string InputPlace, string Key = ".") => WebFormsData.Add("@gc" + InputPlace, Key);
        public void SaveStyle(string InputPlace, string Key = ".") => WebFormsData.Add("@gs" + InputPlace, Key);
        public void SaveTitle(string InputPlace, string Key = ".") => WebFormsData.Add("@gl" + InputPlace, Key);
        public void SaveText(string InputPlace, string Key = ".") => WebFormsData.Add("@gt" + InputPlace, Key);
        public void SaveTextLength(string InputPlace, string Key = ".") => WebFormsData.Add("@gg" + InputPlace, Key);
        public void SaveAttribute(string InputPlace, string Attribute, string Key = ".") => WebFormsData.Add("@ga" + InputPlace, Key + '|' + Attribute);
        public void SaveWidth(string InputPlace, string Key = ".") => WebFormsData.Add("@gw" + InputPlace, Key);
        public void SaveHeight(string InputPlace, string Key = ".") => WebFormsData.Add("@gh" + InputPlace, Key);
        public void SaveReadOnly(string InputPlace, string Key = ".") => WebFormsData.Add("@gr" + InputPlace, Key);
        public void SaveSelectedIndex(string InputPlace, string Key = ".") => WebFormsData.Add("@gx" + InputPlace, Key);
        public void SaveTextAlign(string InputPlace, string Key = ".") => WebFormsData.Add("@ta" + InputPlace, Key);
        public void SaveNodeLength(string InputPlace, string Key = ".") => WebFormsData.Add("@nl" + InputPlace, Key);
        public void SaveVisible(string InputPlace, string Key = ".") => WebFormsData.Add("@vi" + InputPlace, Key);

        // Pre Runner
        public void AssignDelay(float Second, int Index = -1)
        {
            string CurrentName = WebFormsData.GetNameByIndex(Index);

            if (string.IsNullOrEmpty(CurrentName))
                return;

            WebFormsData.ChangeNameByIndex(Index, ":" + Second + ")" + CurrentName);
        }

        public void AssignDelayChange(float Second, int Index = -1)
        {
            string CurrentName = WebFormsData.GetNameByIndex(Index);

            if (string.IsNullOrEmpty(CurrentName))
                return;

            CurrentName = CurrentName.RemoveOuter(":", ")");

            WebFormsData.ChangeNameByIndex(Index, ":" + Second + ")" + CurrentName);
        }

        public void AssignInterval(float Second, int Index = -1)
        {
            string CurrentName = WebFormsData.GetNameByIndex(Index);

            if (string.IsNullOrEmpty(CurrentName))
                return;

            WebFormsData.ChangeNameByIndex(Index, "(" + Second + ")" + CurrentName);
        }

        public void AssignIntervalChange(float Second, int Index = -1)
        {
            string CurrentName = WebFormsData.GetNameByIndex(Index);

            if (string.IsNullOrEmpty(CurrentName))
                return;

            CurrentName = CurrentName.RemoveOuter("(", ")");

            WebFormsData.ChangeNameByIndex(Index, "(" + Second + ")" + CurrentName);
        }

        // Index
        public void StartIndex(string Name) => WebFormsData.Add("#", Name);
        public void StartIndex() => StartIndex("");

        // Get
        public string GetFormsActionData()
        {
            string ReturnValue = "";

            foreach (NameValue nv in WebFormsData.GetList())
            {
                ReturnValue += Environment.NewLine + nv.Name;

                if (!string.IsNullOrEmpty(nv.Value))
                    ReturnValue += "=" + nv.Value;
            }

            return ReturnValue;
        }

        public string Response()
        {
            return "[web-forms]" + GetFormsActionData();
        }

        // Overload
        public string Response(HttpContext context)
        {
            SetHeaders(context);
            return Response();
        }

        public string GetFormsActionDataLineBreak()
        {
            string ReturnValue = "";

            List<NameValue> WebFormsDataList = WebFormsData.GetList();

            int i = WebFormsDataList.Count;
            foreach (NameValue nv in WebFormsData.GetList())
            {
                ReturnValue += nv.Name;

                if (!string.IsNullOrEmpty(nv.Value))
                    ReturnValue += "=" + nv.Value.Replace("\"", "$[dq];");

                if (i-- > 1)
                    ReturnValue += "$[sln];";
            }

            return ReturnValue;
        }

        // Export
        public string ExportToWebFormsTag(string src = null)
        {
            return "<web-forms ac=\"" + GetFormsActionDataLineBreak() + "\"" + (!string.IsNullOrEmpty(src) ? " src=\"" + src + "\"" : "") + "></web-forms>";
        }


        // Overload
        public string ExportToWebFormsTag(string Width, string Height, string src = null)
        {
            return "<web-forms ac=\"" + GetFormsActionDataLineBreak() + "\" width=\"" + Width + "\" height=\"" + Height + "\"" + (!string.IsNullOrEmpty(src) ? " src=\"" + src + "\"" : "") + "></web-forms>";
        }

        // Overload
        public string ExportToWebFormsTag(int Width, int Height, string src = null)
        {
            return ExportToWebFormsTag(Width.ToString() + "px", Height.ToString() + "px", src);
        }

        public string DoneToWebFormsTag(string Id = null)
        {
            return "<web-forms ac=\"" + GetFormsActionDataLineBreak() + "\"" + (!string.IsNullOrEmpty(Id) ? " id=\"" + Id + "\" done=\"true\"" : "") + "></web-forms>";
        }

        public NameValueCollection ExportToNameValue()
        {
            return WebFormsData;
        }

        public void AppendForm(WebForms form)
        {
            WebFormsData.AddList(form.ExportToNameValue().GetList());
        }

        public void SetHeaders(HttpContext context)
        {
            context.Response.Headers.Add("Content-Type", "text/plain");
        }

        public void Clean()
        {
            WebFormsData = new NameValueCollection();
        }
    }

    public class InputPlace
    {
        public static string Id(string Id) => Id;
        public static string Name(string Name) => '(' + Name + ')';
        public static string Name(string Name, int Index) => '(' + Name + ')' + Index;
        public static string Tag(string Tag) => '<' + Tag + '>';
        public static string Tag(string Tag, int Index) => '<' + Tag + '>' + Index;
        public static string Class(string Class) => '{' + Class + '}';
        public static string Class(string Class, int Index) => '{' + Class + '}' + Index;
        public static string Query(string Query) => "*" + Query.Replace("=", "$[eq];");
        public static string QueryAll(string Query) => "[" + Query.Replace("=", "$[eq];");
    }

    public class OutputPlace : InputPlace { }

    /// <summary>
    /// Do Not Add Any Data Before Or After It
    /// </summary>
    public class Fetch
    {
        public static string Random(int MaxValue) => "@mr" + MaxValue;
        public static string Random(int MinValue, int MaxValue) => "@mr" + MaxValue + "," + MinValue;
        public static string DateYear = "@dy";
        public static string DateMonth = "@dm";
        public static string DateDay = "@dd";
        public static string DateHours = "@dh";
        public static string Dateinutes = "@di";
        public static string DateSeconds = "@ds";
        public static string DateMilliseconds = "@dl";
        public static string Cookie(string Key) => "@co" + Key;
        public static string Session(string Key) => "@cs" + Key;
        public static string Session(string Key, string ReplaceValue) => "@cs" + Key + "," + ReplaceValue;
        public static string SessionAndRemove(string Key) => "@cl" + Key;
        public static string SessionAndRemove(string Key, string ReplaceValue) => "@cl" + Key + "," + ReplaceValue;
        public static string Saved(string Key = ".") => "@cl" + Key;
        public static string Cache(string Key) => "@cd" + Key;
        public static string Cache(string Key, string ReplaceValue) => "@cd" + Key + "," + ReplaceValue;
        public static string CacheAndRemove(string Key) => "@ct" + Key;
        public static string CacheAndRemove(string Key, string ReplaceValue) => "@ct" + Key + "," + ReplaceValue;
        public static string Script(string ScriptText) => "@_" + ScriptText.Replace('\n'.ToString(), "$[ln];");
    }

    public class HtmlEvent
    {
        public static string OnAbort = "onabort";
        public static string OnAfterPrint = "onafterprint";
        public static string OnBeforePrint = "onbeforeprint";
        public static string OnBeforeUnload = "onbeforeunload";
        public static string OnBlur = "onblur";
        public static string OnCanPlay = "oncanplay";
        public static string OnCanPlayThrough = "oncanplaythrough";
        public static string OnChange = "onchange";
        public static string OnClick = "onclick";
        public static string OnCopy = "oncopy";
        public static string OnCut = "oncut";
        public static string OnDoubleClick = "ondblclick";
        public static string OnDrag = "ondrag";
        public static string OnDragEnd = "ondragend";
        public static string OnDragEnter = "ondragenter";
        public static string OnDragLeave = "ondragleave";
        public static string OnDragOver = "ondragover";
        public static string OnDragStart = "ondragstart";
        public static string OnDrop = "ondrop";
        public static string OnDurationChange = "ondurationchange";
        public static string OnEnded = "onended";
        public static string OnError = "onerror";
        public static string OnFocus = "onfocus";
        public static string OnFocusin = "onfocusin";
        public static string OnFocusOut = "onfocusout";
        public static string OnHashChange = "onhashchange";
        public static string OnInput = "oninput";
        public static string OnInvalid = "oninvalid";
        public static string OnKeyDown = "onkeydown";
        public static string OnKeyPress = "onkeypress";
        public static string OnKeyUp = "onkeyup";
        public static string OnLoad = "onload";
        public static string OnLoadedData = "onloadeddata";
        public static string OnLoadedMetaData = "onloadedmetadata";
        public static string OnLoadStart = "onloadstart";
        public static string OnMouseDown = "onmousedown";
        public static string OnMouseEnter = "onmouseenter";
        public static string OnMouseLeave = "onmouseleave";
        public static string OnMouseMove = "onmousemove";
        public static string OnMouseOver = "onmouseover";
        public static string OnMouseOut = "onmouseout";
        public static string OnMouseUp = "onmouseup";
        public static string OnOffline = "onoffline";
        public static string OnOnline = "ononline";
        public static string OnPageHide = "onpagehide";
        public static string OnPageShow = "onpageshow";
        public static string OnPaste = "onpaste";
        public static string OnPause = "onpause";
        public static string OnPlay = "onplay";
        public static string OnPlaying = "onplaying";
        public static string OnProgress = "onprogress";
        public static string OnRateChange = "onratechange";
        public static string OnResize = "onresize";
        public static string OnReset = "onreset";
        public static string OnScroll = "onscroll";
        public static string OnSearch = "onsearch";
        public static string OnSeeked = "onseeked";
        public static string OnSeeking = "onseeking";
        public static string OnSelect = "onselect";
        public static string OnStalled = "onstalled";
        public static string OnSubmit = "onsubmit";
        public static string OnSuspend = "onsuspend";
        public static string OnTimeUpdate = "ontimeupdate";
        public static string OnToggle = "ontoggle";
        public static string OnTouchCancel = "ontouchcancel";
        public static string OnTouchend = "ontouchend";
        public static string OnTouchMove = "ontouchmove";
        public static string OnTouchStart = "ontouchstart";
        public static string OnUnload = "onunload";
        public static string OnVolumeChange = "onvolumechange";
        public static string OnWaiting = "onwaiting";
    }

    public class HtmlEventListener
    {
        public static string Abort = "abort";
        public static string AfterPrint = "afterprint";
        public static string BeforePrint = "beforeprint";
        public static string BeforeUnload = "beforeunload";
        public static string Blur = "blur";
        public static string CanPlay = "canplay";
        public static string CanPlayThrough = "canplaythrough";
        public static string Change = "change";
        public static string Click = "click";
        public static string Copy = "copy";
        public static string Cut = "cut";
        public static string DoubleClick = "dblclick";
        public static string Drag = "drag";
        public static string DragEnd = "dragend";
        public static string DragEnter = "dragenter";
        public static string DragLeave = "dragleave";
        public static string DragOver = "dragover";
        public static string DragStart = "dragstart";
        public static string Drop = "drop";
        public static string DurationChange = "durationchange";
        public static string Ended = "ended";
        public static string Error = "error";
        public static string Focus = "focus";
        public static string Focusin = "focusin";
        public static string FocusOut = "focusout";
        public static string HashChange = "hashchange";
        public static string Input = "input";
        public static string Invalid = "invalid";
        public static string KeyDown = "keydown";
        public static string KeyPress = "keypress";
        public static string KeyUp = "keyup";
        public static string Load = "load";
        public static string LoadedData = "loadeddata";
        public static string LoadedMetaData = "loadedmetadata";
        public static string LoadStart = "loadstart";
        public static string MouseDown = "mousedown";
        public static string MouseEnter = "mouseenter";
        public static string MouseLeave = "mouseleave";
        public static string MouseMove = "mousemove";
        public static string MouseOver = "mouseover";
        public static string MouseOut = "mouseout";
        public static string MouseUp = "mouseup";
        public static string Offline = "offline";
        public static string Online = "online";
        public static string PageHide = "pagehide";
        public static string PageShow = "pageshow";
        public static string Paste = "paste";
        public static string Pause = "pause";
        public static string Play = "play";
        public static string Playing = "playing";
        public static string Progress = "progress";
        public static string RateChange = "ratechange";
        public static string Resize = "resize";
        public static string Reset = "reset";
        public static string Scroll = "scroll";
        public static string Search = "search";
        public static string Seeked = "seeked";
        public static string Seeking = "seeking";
        public static string Select = "select";
        public static string Stalled = "stalled";
        public static string Submit = "submit";
        public static string Suspend = "suspend";
        public static string TimeUpdate = "timeupdate";
        public static string Toggle = "toggle";
        public static string TouchCancel = "touchcancel";
        public static string Touchend = "touchend";
        public static string TouchMove = "touchmove";
        public static string TouchStart = "touchstart";
        public static string Unload = "unload";
        public static string VolumeChange = "volumechange";
        public static string Waiting = "waiting";

        public static string AnimationEnd = "animationend";
        public static string AnimationIteration = "animationiteration";
        public static string AnimationStart = "animationstart";
        public static string ContextMenu = "contextmenu";
        public static string FullScreenChange = "fullscreenchange";
        public static string FullScreenError = "fullscreenerror";
        public static string PopState = "popstate";
        public static string TransitionEnd = "transitionend";
        public static string Storage = "storage";
        public static string Wheel = "wheel";
    }

    public static class ExtensionWebFormsMethods
    {
        /// <summary>
        /// This Method Does Not Support QueryAll
        /// </summary>
        public static string AppendPlace(this string Text, string Value)
        {
            if (Text.Length < 1)
                return Value;

            return Text + "|" + Value;
        }

        public static string AppendParrent(this string Text)
        {
            return "/" + Text;
        }

        public static string ExportToWebFormsTag(this string src)
        {
            return "<web-forms src=\"" + src + "\"></web-forms>";
        }

        // Overload
        public static string ExportToWebFormsTag(this string src, int Width, int Height)
        {
            return "<web-forms src=\"" + src + "\" width=\"" + Width + "\" height=\"" + Height + "\"></web-forms>";
        }

        public static string ExportActionControlsToWebFormsTag(this string ActionControls)
        {
            return "<web-forms ac=\"" + ActionControls + "\"></web-forms>";
        }

        public static string RemoveOuter(this string Text, string StartString, string EndString)
        {
            int Start = Text.IndexOf(StartString);
            if (Start == -1)
                return Text;

            int End = Text.IndexOf(EndString, Start);
            if (End == -1)
                return Text;

            int lengthToRemove = (End - Start) + EndString.Length;

            return Text.Remove(Start, lengthToRemove);
        }
    }

    public class NameValue
    {
        public string Name { get; set; }
        public string Value { get; set; }

        public NameValue()
        {

        }

        public NameValue(string Name, string Value)
        {
            this.Name = Name;
            this.Value = Value;
        }
    }
    public class NameValueCollection
    {
        private List<NameValue> NameValueList = new List<NameValue>();

        public void Add(string Name, string Value)
        {
            NameValueList.Add(new NameValue(Name, Value));
        }

        public void Set(string Name, string Value)
        {
            if (!Exist(Name))
                Add(Name, Value);
            else
                ChangeValue(Name, Value);
        }

        public void Delete(string Name)
        {
            List<NameValue> TmpNameValueList = new List<NameValue>();

            foreach (NameValue nv in NameValueList)
            {
                if (nv.Name != Name)
                    TmpNameValueList.Add(nv);
            }

            NameValueList = TmpNameValueList;
        }

        public void DeleteByIndex(int Index)
        {
            int TmpIndex = (Index >= 0) ? Index : NameValueList.Count + Index;
            NameValueList.RemoveAt(TmpIndex);
        }

        public void Empty()
        {
            NameValueList = new List<NameValue>();
        }

        public bool Exist(string Name)
        {
            foreach (NameValue nv in NameValueList)
            {
                if (nv.Name == Name)
                    return true;
            }

            return false;
        }

        public void ChangeValue(string Name, string Value)
        {
            foreach (NameValue nv in NameValueList)
            {
                if (nv.Name == Name)
                {
                    nv.Value = Value;
                    break;
                }
            }
        }

        public void ChangeName(string Name, string NewName)
        {
            foreach (NameValue nv in NameValueList)
            {
                if (nv.Name == Name)
                {
                    nv.Name = NewName;
                    break;
                }
            }
        }

        // Overload
        public void ChangeValue(string Name, string NewName, string Value)
        {
            foreach (NameValue nv in NameValueList)
            {
                if (nv.Name == Name)
                {
                    nv.Name = NewName;
                    nv.Value = Value;
                    break;
                }
            }
        }

        public void ChangeValueByIndex(int Index, string Value)
        {
            if (Index >= 0)
                NameValueList[Index].Value = Value;
            else
                NameValueList[NameValueList.Count + Index].Value = Value;
        }

        public void ChangeNameByIndex(int Index, string Name)
        {
            if (Index >= 0)
                NameValueList[Index].Name = Name;
            else
                NameValueList[NameValueList.Count + Index].Name = Name;
        }

        public void ChangeNameValueByIndex(int Index, string Name, string Value)
        {
            if (Index >= 0)
            {
                NameValueList[Index].Name = Name;
                NameValueList[Index].Value = Value;
            }
            else
            {
                NameValueList[NameValueList.Count + Index].Name = Name;
                NameValueList[NameValueList.Count + Index].Value = Value;
            }
        }

        public void AddList(List<NameValue> NameValueList)
        {
            foreach (NameValue nv in NameValueList)
                this.NameValueList.Add(nv);
        }

        public string GetValue(string Name)
        {
            foreach (NameValue nv in NameValueList)
            {
                if (nv.Name == Name)
                    return nv.Value;
            }

            return "";
        }

        public string GetNameByIndex(int Index)
        {
            int TmpIndex = (Index >= 0) ? Index : NameValueList.Count + Index;
            return NameValueList[TmpIndex].Name;
        }

        public string GetValueByIndex(int Index)
        {
            int TmpIndex = (Index >= 0) ? Index : NameValueList.Count + Index;
            return NameValueList[TmpIndex].Value; ;
        }

        public List<NameValue> GetList()
        {
            return NameValueList;
        }
    }
}
