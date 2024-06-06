using Humanizer;

namespace ProjectOfNounsAndTitles;

public static class Title
{
    public static string CreateTitle()
    {
        static string randomCapitalNoun() => Word.RandomNoun().Humanize(LetterCasing.Title);
        string[] nouns = Enumerable.Range(0,3).Select(x => randomCapitalNoun()).ToArray();
        string leadingArticle = Word.ChooseArticle(nouns[0]).Humanize(LetterCasing.Title);
        return $"{leadingArticle} {nouns[0]} of {nouns[1]} and {nouns[2]}";
    }
}