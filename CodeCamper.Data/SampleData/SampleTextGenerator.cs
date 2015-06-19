using NLipsum.Core;

namespace CodeCamper.Data.SampleData
{
    /// <summary>
    ///     Generate sample text for the database
    /// </summary>
    /// <remarks>
    ///     Uses the open source nlipsum "Lorem Ipsum Generator"
    ///     downloaded from here: http://code.google.com/p/nlipsum/
    ///     Licensed under the MIT License here: http://www.opensource.org/licenses/mit-license.php
    /// </remarks>
    public class SampleTextGenerator
    {
        /// <summary>
        ///     Original sources of text from which to generate sample text.
        ///     All are out of copyright.
        /// </summary>
        public enum SourceNames
        {
            LoremIpsum,
            ChildHarold,
            TheRaven,
            Decameron,
            Faust
        }

        public string GenWords(int wordCount = 1, SourceNames sourceNames = 0)
        {
            var gen = new LipsumGenerator(GetSource(sourceNames), false);
            return string.Join(" ", gen.GenerateWords(wordCount));
        }

        public string GenSentences(int sentenceCount = 1, SourceNames sourceNames = 0)
        {
            var gen = new LipsumGenerator(GetSource(sourceNames), false);
            return string.Join(" ", gen.GenerateSentences(sentenceCount));
        }

        protected string GetSource(SourceNames sourceName)
        {
            switch (sourceName)
            {
                case SourceNames.ChildHarold:
                    return Lipsums.ChildHarold;
                case SourceNames.TheRaven:
                    return Lipsums.TheRaven;
                case SourceNames.Decameron:
                    return Lipsums.Decameron;
                case SourceNames.Faust:
                    return Lipsums.Faust;
                default:
                    return Lipsums.LoremIpsum;
            }
        }
    }
}