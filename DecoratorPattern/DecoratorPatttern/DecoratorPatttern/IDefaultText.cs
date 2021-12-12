namespace DecoratorPatttern
{
    public interface IDefaultText
    {
        string TextInput { get; set; }
        string TagSelection1 { get; set; }
        string TagSelection2 { get; set; }


        string GetText(string textinput);
    }
}