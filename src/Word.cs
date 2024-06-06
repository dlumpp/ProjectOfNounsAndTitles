using CrypticWizard.RandomWordGenerator;

namespace ProjectOfNounsAndTitles;

public static class Word 
{
    public static string RandomNoun() {
        WordGenerator myWordGenerator = new();
        return myWordGenerator.GetWord(WordGenerator.PartOfSpeech.noun);
    }

    public static string ChooseArticle(string noun) => AvsAnLib.AvsAn.Query(noun).Article;
}