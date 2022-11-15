using System;
using Class1;

namespace Class1
{
    public class Class1
    {
        public Dictionary<char, char> dict_one;
        public Dictionary<char, char> dict_two;
        public string result;
        public string key;

        public Class1()

        {
            dict_one = new Dictionary<char, char>(){
                {'a',  '£'},  { 'b',  '*'},  { 'c',  '%'},  { 'd',  '&'},
                { 'e',  '>'},  { 'f',  '<'},  {'g',  '!'},  { 'h',  ')'},
                {'i',  '\"' }, { 'j',  '('}, { 'k',  '@'},  { 'l',  'a'},
                { 'm',  'b'},  { 'n',  'c'},  { 'o',   'd'},  { 'p',  'e'},
                { 'q',  'f'},  { 'r',  'g'},  { 's',  'h'},  { 't',  'i'},
              { 'u',  'j'},  { 'v',  'k'},  { 'w',  'l'},  { 'x',  'm'},
                { 'y',  'n'},  {  'z',  'o'}

            };
            dict_two = new Dictionary<char, char>()
            {
                {'£', 'a' }, {'*', 'b'}, {'%', 'c'}, {'&', 'd'}, {'>', 'e'},
                {'<', 'f'}, {'!', 'g'}, {')', 'h'}, {'\"', 'i'}, {'(', 'j'},
                {'@', 'k'}, {'a', 'l'}, {'b',  'm' },  {'c', 'n' },  {'d', 'o' },
                {'e', 'p'},  {'f', 'q'}, { 'g', 'r'}, { 'h', 's'},  {'i', 't'},
                { 'j', 'u' },  {'k', 'v' }, { 'l', 'w' },  {'m', 'x' },
                {'n', 'y' },  {'o', 'z' }
            };
            result = "";


        }

        public static string encrypt1(string word)
        {
            var myClass = new Class1();
            string result = myClass.result;
            Dictionary<char, char> dict_one = myClass.dict_one;


            foreach (char letter in word)
            {
                result += dict_one[letter];
            }
            return result;
        }
        public static string decrypt1(string word)
        {
            var myClass = new Class1();
            string result = myClass.result;
            Dictionary<char, char> dict_two = myClass.dict_two;



            foreach (char letter in word)
            {
                result += dict_two[letter];
            }
            return result;
        }
    }
}

