using static System.Net.Mime.MediaTypeNames;

namespace CodeBehind
{
    public class WebForms
    {
        private HtmlData.NameValueCollection WebFormsData = new HtmlData.NameValueCollection();

        // Add
        public void AddId(string InputPlace, string Id) => WebFormsData.Add("ai" + InputPlace, Id);
        public void AddName(string InputPlace, string Name) => WebFormsData.Add("an" + InputPlace, Name);
        public void AddValue(string InputPlace, string Value) => WebFormsData.Add("av" + InputPlace, Value);
        public void AddClass(string InputPlace, string Class) => WebFormsData.Add("ac" + InputPlace, Class);
        public void AddStyle(string InputPlace, string Style) => WebFormsData.Add("as" + InputPlace, Style);
        public void AddOptionTag(string InputPlace, string Text, string Value, bool Selected = false) => WebFormsData.Add("ao" + InputPlace, Value + '|' + Text + (Selected? "|1" : ""));
        public void AddCheckBoxTag(string InputPlace, string Text, string Value, bool Checked = false) => WebFormsData.Add("ak" + InputPlace, Value + '|' + Text + (Checked ? "|1" : ""));
        public void AddTitle(string InputPlace, string Title) => WebFormsData.Add("al" + InputPlace, Title);
        public void AddText(string InputPlace, string Text) => WebFormsData.Add("at" + InputPlace, Text.Replace('\n'.ToString(), "$[ln];"));
        public void AddAttribute(string InputPlace, string Attribute, string Value = "") => WebFormsData.Add("aa" + InputPlace, Attribute + '|' + Value);
        public void AddTag(string InputPlace, string TagName, string Id = "") => WebFormsData.Add("nt" + InputPlace, TagName + (!string.IsNullOrEmpty(Id) ? '|' + Id : ""));

        // Set
        public void SetId(string InputPlace, string Id) => WebFormsData.Add("si" + InputPlace, Id);
        public void SetName(string InputPlace, string Name) => WebFormsData.Add("sn" + InputPlace, Name);
        public void SetValue(string InputPlace, string Value) => WebFormsData.Add("sv" + InputPlace, Value);
        public void SetClass(string InputPlace, string Class) => WebFormsData.Add("sc" + InputPlace, Class);
        public void SetStyle(string InputPlace, string Style) => WebFormsData.Add("ss" + InputPlace, Style);
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
        public void InsertOptionTag(string InputPlace, string Text, string Value, bool Selected = false) => WebFormsData.Add("io" + InputPlace, Value + '|' + Text + (Selected ? "|1" : ""));
        public void InsertCheckBoxTag(string InputPlace, string Text, string Value, bool Checked = false) => WebFormsData.Add("ik" + InputPlace, Value + '|' + Text + (Checked ? "|1" : ""));
        public void InsertTitle(string InputPlace, string Title) => WebFormsData.Add("il" + InputPlace, Title);
        public void InsertText(string InputPlace, string Text) => WebFormsData.Add("it" + InputPlace, Text.Replace('\n'.ToString(), "$[ln];"));
        public void InsertAttribute(string InputPlace, string Attribute, string Value = "") => WebFormsData.Add("ia" + InputPlace, Attribute + (!string.IsNullOrEmpty(Value) ? '|' + Value : ""));

        // Delete
        public void DeleteId(string InputPlace) => WebFormsData.Add("di" + InputPlace , "1");
        public void DeleteName(string InputPlace) => WebFormsData.Add("dn" + InputPlace, "1");
        public void DeleteValue(string InputPlace) => WebFormsData.Add("dv" + InputPlace, "1");
        public void DeleteClass(string InputPlace, string ClassName) => WebFormsData.Add("dc" + InputPlace, ClassName);
        public void DeleteStyle(string InputPlace, string StyleName) => WebFormsData.Add("ds" + InputPlace, StyleName);
        public void DeleteOptionTag(string InputPlace, string Value) => WebFormsData.Add("do" + InputPlace, Value);
        public void DeleteCheckBoxTag(string InputPlace, string Value) => WebFormsData.Add("dk" + InputPlace, Value);
        public void DeleteTitle(string InputPlace) => WebFormsData.Add("dl" + InputPlace, "1");
        public void DeleteText(string InputPlace) => WebFormsData.Add("dt" + InputPlace, "1");
        public void DeleteAttribute(string InputPlace, string Attribute) => WebFormsData.Add("da" + InputPlace, Attribute);
        public void Delete(string InputPlace) => WebFormsData.Add("de" + InputPlace, "1");

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
        public void SetMinLength(string InputPlace, int Length) => WebFormsData.Add("mn" + InputPlace, Length.ToString());
        public void SetMaxLength(string InputPlace, int Length) => WebFormsData.Add("mx" + InputPlace, Length.ToString());
        public void SetSelectedValue(string InputPlace, string Value) => WebFormsData.Add("ts" + InputPlace, Value);
        public void SetSelectedIndex(string InputPlace, int Index) => WebFormsData.Add("ti" + InputPlace, Index.ToString());
        public void SetCheckedValue(string InputPlace, string Value, bool Selected) => WebFormsData.Add("ks" + InputPlace, Value + "|" + (Selected ? "1" : "0"));
        public void SetCheckedIndex(string InputPlace, int Index, bool Selected) => WebFormsData.Add("ki" + InputPlace, Index.ToString() + "|" + (Selected ? "1" : "0"));

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

        public string GetFormsActionData()
        {
            string ReturnValue = "";

            foreach (HtmlData.NameValue nv in WebFormsData.GetList())
                ReturnValue += Environment.NewLine + nv.Name + "=" + nv.Value;

            return ReturnValue;
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
}
