namespace BasicFacebookFeatures.StrategyPattern
{
    public interface IParser<T>
    {
        T Parse(string i_TextToParse);
    }
}
