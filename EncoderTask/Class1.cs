using System;
using Class1;

namespace Class1
//namespace Encrypt_and_Decrypt
{
    public class Class1
    {
        public Dictionary<char, char> dict1;
        public Dictionary<char, char> dict2;
        public string result;
        public string key;

        public Class1()

        {
            dict1 = new Dictionary<char, char>(){
                {'a',  '£'},  { 'b',  '*'},  { 'c',  '%'},  { 'd',  '&'},
                { 'e',  '>'},  { 'f',  '<'},  {'g',  '!'},  { 'h',  ')'},
                {'i',  '\"' }, { 'j',  '('}, { 'k',  '@'},  { 'l',  'a'},
                { 'm',  'b'},  { 'n',  'c'},  { 'o',   'd'},  { 'p',  'e'},
                { 'q',  'f'},  { 'r',  'g'},  { 's',  'h'},  { 't',  'i'},
              { 'u',  'j'},  { 'v',  'k'},  { 'w',  'l'},  { 'x',  'm'},
                { 'y',  'n'},  {  'z',  'o'}

            };
            dict2 = new Dictionary<char, char>()
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
            Dictionary<char, char> dict1 = myClass.dict1;


            foreach (char letter in word)
            {
                result += dict1[letter];
            }
            return result;
        }
        public static string decrypt1(string word)
        {
            var myClass = new Class1();
            string result = myClass.result;
            Dictionary<char, char> dict2 = myClass.dict2;



            foreach (char letter in word)
            {
                result += dict2[letter];
            }
            return result;
        }
    }
}

