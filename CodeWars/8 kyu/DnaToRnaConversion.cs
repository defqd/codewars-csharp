/*
https://www.codewars.com/kata/5556282156230d0e5e000089/train/csharp

8 kyu

Deoxyribonucleic acid, DNA is the primary information storage molecule in biological systems. It is composed of four nucleic
acid bases Guanine ('G'), Cytosine ('C'), Adenine ('A'), and Thymine ('T').

Ribonucleic acid, RNA, is the primary messenger molecule in cells. RNA differs slightly from DNA its chemical structure and
contains no Thymine. In RNA Thymine is replaced by another nucleic acid Uracil ('U').

Create a function which translates a given DNA string into RNA.

For example:

"GCAT"  =>  "GCAU"
The input string can be of arbitrary length - in particular, it may be empty. All input is guaranteed to be valid, i.e. each
input string will only ever consist of 'G', 'C', 'A' and/or 'T'.

*/
namespace CodeWars._8_kyu
{
    public class DnaToRnaConversion
    {
        public string dnaToRna(string dna)
        {
            return dna.Replace("T", "U");
        }
    }
}
