using System;
using System.Linq;

namespace AdventCalendar2018
{
    public class DayTwo
    {
        private const string CHALLENGE_INPUT = @"wlpiogsvdfecjdqmnxakudrhbz
wbpioesvyfecjuqmlxaktdrhbz
blviogavyfecjuqmnxaktdrhbz
wlpiogsvydecjuqmnipktdrhbz
wlwiogsvyfmcjuqmoxaktdrhbz
wlpiogsvphecjuqmnxaktdrzbz
wlpiogsvyfecjuqmnkakhdrkbz
wlpiogsvyfhcjuqmnxxktddhbz
wlpiogsvyfccfuqmnxgktdrhbz
wlpiogsvhmecjvqmnxaktdrhbz
wlpiogsvyfecjdqqnxaktdrhyz
wlpiogyvycecjaqmnxaktdrhbz
wlpiogsvyfecjfqmnxaktybhbz
wkpiogsvyfmcauqmnxaktdrhbz
wlmiolsvyfecjuqmnxaktdrhbn
wlpioksvyfecjuqmnxaktdrhgs
wlpiogsvyflcjuvmnxsktdrhbz
wgziogsvyfecjuqmnxaktdrhoz
whpingsvyeecjuqmnxaktdrhbz
wlpiogsvyfecjuqgnxaktdvhlz
wlpioasvtfecjuqmnxaktdahbz
wlpihgsvefeceuqmnxaktdrhbz
wlpiogsvyfecyuqwnxaktdghbz
wlpfsgsvyfhcjuqmnxaktdrhbz
wlpiogyvyfecjuqmnxalpdrhbz
wlpiogsvyfescsqmnxaktdrhbz
wluiogsvyfecytqmnxaktdrhbz
wltiorsvyfecjuqmoxaktdrhbz
wlmiogwvyfejjuqmnxaktdrhbz
wlpiogsvyfycjuumnxvktdrhbz
wlkiogsqyfecjqqmnxaktdrhbz
wlpiogsvyfecouqmnxaktfrubz
hupiogsvlfecjuqmnxaktdrhbz
wlpiogsvpxecjuqmnxaksdrhbz
wlpiogsvyfkcjfqmnxxktdrhbz
wlpiogsjyfecjuqnnxakthrhbz
wlpiogsvyfecjuqmnxaktddhdk
wlpipgsvyfecjuqmnhaktdrubz
wlpiogsoyfenjpqmnxaktdrhbz
wlpiogsvyfecnuqmnxaxtdrmbz
wlpiggsvyfjcjuumnxaktdrhbz
wlppogsvyfecjuqmnxautdhhbz
wlpiovbvyfecjuqmnxaktcrhbz
wlpiogsvyfecjoqmnxaktdrobu
wlpiohsvyfecjugmnxakthrhbz
wvpiogovyfecjuqmnxakwdrhbz
wlpiogsbyfecjuqmnxdktdrtbz
wlpnogsvyfecjuqmnxakykrhbz
wlpiogpvyfecjuqmnxvktdrhbs
wlpiogsvkvecjuqmnxadtdrhbz
wlkihgsvyfecjuqmnxlktdrhbz
wlpilgsvyfhcjuqmnxakudrhbz
wlpioksvysgcjuqmnxaktdrhbz
wlpiogsvyfecorqmoxaktdrhbz
wlpiogsvyfectzlmnxaktdrhbz
wlpiogsvywecjuqwnqaktdrhbz
wlpiowsvyfecjuqrnxaftdrhbz
wlpiogsuyfecjutmnxaktnrhbz
wepiowsvyfqcjuqmnxaktdrhbz
wlpirgssyfecjuqmvxaktdrhbz
wlyiogstyfecjuqmnxaktdrhbw
wlpiogseyfecauqmnxaktdjhbz
wlpioisvyfenjuqmnxakrdrhbz
wlpiogsvyfrgjfqmnxaktdrhbz
wlpionsvyfecjmqmjxaktdrhbz
alpiggsvyfecjuqmnxaktdrhkz
wlphngsvyfecjuqmnxfktdrhbz
wlpiogsvyferjuqmlxakttrhbz
wlniogsvefecjuqsnxaktdrhbz
wlpiogsvyfncjurmnxakudrhbz
wlpiogsvyfecjuqmnxaktprlaz
wlpiocsvyfecjupmkxaktdrhbz
wlpihgsvyfecjeqfnxaktdrhbz
wlwioasvyfjcjuqmnxaktdrhbz
wlpifgsvyfecjuqsnxaktdshbz
wlxiogsvyrechuqmnxaktdrhbz
wlpiogovyfxcjuqmnxakkdrhbz
wlpiogsvyfecjkqmdxaktmrhbz
wlpiogsvyfecjwqmntaktdhhbz
wlpiogsvdfecjuqmmxaktbrhbz
wlpiogsvyfecauqmnxaksdrhwz
wlpiogsvwfecjuqznxaktorhbz
wlpiogtvyfecjuqhnxakidrhbz
wlpiogsvyyecjuqmnxaktdrhwt
wljiogsvyfecfuqbnxaktdrhbz
wlpiogsvybecjuqmnxagtdrjbz
wrpiogsvyfecjuqmnuaktdrhbd
wlpiogsvyfecjurmnxnltdrhbz
blpvogsvyaecjuqmnxaktdrhbz
bfpiogyvyfecjuqmnxaktdrhbz
wlpiogsvyfecjuqinxaknddhbz
wlpizgsvvfecjuqxnxaktdrhbz
glpiogsvyrecjuqmnxaktdrhbr
wlpiogskhfecjutmnxaktdrhbz
wlpiogsvyfecmuqmnxaktdribc
wlpioesvwfecjuqmnxakkdrhbz
wlpionsrafecjuqmnxaktdrhbz
wlsiogsvyfecjuqmnaaktdrhvz
bloiogsvyfecjuqmnxakjdrhbz
wlpiogsvyfecjuqenmastdrhbz
wlpiogyvyfecjuqmuxakldrhbz
plpiogovyfecjuvmnxaktdrhbz
wlpiogsvyfebjuqmnkakvdrhbz
wlziogsvyfhcjuqmngaktdrhbz
wlsiogsvyfecjuqmnxaktdrzjz
plbiogsvyfecfuqmnxaktdrhbz
wfpiogsvyfecjuqknxaktdrhiz
wlpiogjbyfecjuqmnxaktprhbz
wmpiogsvyrecjcqmnxaktdrhbz
wlpiogsyyfecjuqmqxaktdrbbz
wlpiogsvyfecjuqknxaetdehbz
wlpiogsvyfezjuqmnxakkdhhbz
wlpiogsvyfecjjqvnxaktdrhiz
wkpiogsvyfucjuqmnxaktdrhbd
lliiogsvyfecjuqmnxaktdrhoz
wlpiogsvyfecjuqmsxdktdshbz
wlprogtvyfecjuqmnxaktvrhbz
wlpizgssyffcjuqmnxaktdrhbz
wlpioasvyfvcjuqmnxakldrhbz
wlpoogsvyyecjuqmnxastdrhbz
wlpiognvyfecjuqmnsaktdrhbr
wlpiogsoyfecjuqmnxaktdrhho
wfpiogsvydecjuqmnxaotdrhbz
wlpiogsvqhecjuqmnxaktdrhhz
wkpiogsvyfeojuqmnxaktdrqbz
wlpiogsvyfeveuqmnxaktdshbz
wlpiogbvyfecjuqmexaktdrcbz
wlpxogsvyfehjsqmnxaktdrhbz
wlpcogsvyfecjuqmnjakttrhbz
wlpiogsvvkecjuqmnxaftdrhbz
wlpiogsvffecnuqmnxaktdnhbz
wlpiogsvyfecjupjnxaktdrhbr
wlpqogsvyfecjuqmnxlktdphbz
wlpxogsvyfecjvqmnxaktirhbz
elpiogsvyfecjuqlnxaqtdrhbz
wspiogsvrfecjuqmnxakadrhbz
wlpiogsmyfecbuqmnxactdrhbz
wlpiogsvyfecauqmnyakzdrhbz
wlsiogsvyfecjuqmnxakvdrnbz
wlpiogsxyfeijuqmnxakndrhbz
wlpiogsvyfecjuumnxakbyrhbz
wlpiogsvyfecjuqmnxhktdyhbo
wlpiogsvyfecjuqqnxnjtdrhbz
wapiogsvyfecjuqmnxoktdrmbz
wlpiogsvyfeejvqmnxaktdrubz
wlpitgsvyeectuqmnxaktdrhbz
alpiogsvyfecjulmnxaktdchbz
wlpiogsvyfecjuqmuxoktdrwbz
wlpiogsvyfzgjuhmnxaktdrhbz
wlpnogsvyfecjuqmdxaktyrhbz
wlpiogsvyfecjuqmnxakthrhra
wliiogsvyfecluqmnxaktdhhbz
wlpiogsvyfecjuymnxaltdrhwz
wlpiogsvyfeljuqmnxaktyrhbd
wlpiygsvvfecjuqmfxaktdrhbz
wlpiogihsfecjuqmnxaktdrhbz
wlpiogjvyfecjuqmnhuktdrhbz
wldiogsvyfecjiqmwxaktdrhbz
wlpiogsvjfecjuqmnxaktdrgbr
wlpioisvyfecjuqwnxabtdrhbz
wlviogsvyfscjuqmnxqktdrhbz
wlpiogsvyfecjuqmuxakbdrubz
wlpiogsvyfecjuqmnxmatdrhqz
wlpiogsvyfbcjuqwmxaktdrhbz
wlpiogsvyfexjuqmnxuxtdrhbz
wljiogsvbfecjuqmnxartdrhbz
wlpvogsvyfeujuqmnxaktdmhbz
wnpiogsvyfekjuqanxaktdrhbz
wlprogsvyfecjuqmzxvktdrhbz
wkpiogvvyfecjuqmnxaktdrabz
wlpiogsvwfecjuqmnxaktkbhbz
wlpiogsvyfecjlqmnxtttdrhbz
wlpioqsvyfecjuqznxaktyrhbz
wlpiogsvyfecjuqmnxnethrhbz
wlpiogsyyfgcjuqmnxaktdrhbm
wlpiopsvbfecjuqmnxaktdlhbz
wloqogsvyfucjuqmnxaktdrhbz
wlpiogsvmfecjuqmnxmktdrhtz
wlhiogsvyfecjuhmnxaktsrhbz
wlpioggvpfecjufmnxaktdrhbz
wlpiogsvyfbcjuomnxaktdrhbh
wlpmogsvyfecyuqmnxoktdrhbz
wlpiogslyfecjuqmnxaptyrhbz
tlpiogsnyfecguqmnxaktdrhbz
wlpiogsvyfecjuqmnxwktwehbz
wlpiogsvgfecjuqmnxaktdrabu
wbpiogsvyfecjuqmnxagtdrhoz
wlwipgsvyfecjuqmnxaktdrhbu
wlpwogsvykeczuqmnxaktdrhbz
wlpgogsvwfecjuqmnxcktdrhbz
wlpiogsqyfecjuqmrxaktdrrbz
wlpiogsvyfecjuqmnxakthrafz
wypicgseyfecjuqmnxaktdrhbz
wlpiogcvqfecjuqmnxaktdrhzz
wlriogsvyfecouqmnkaktdrhbz
wlpiogsvyfemjulmnxaktdrhdz
flpiogadyfecjuqmnxaktdrhbz
wupiogsvyfbvjuqmnxaktdrhbz
wlpiogsvyfebjummnxaktdrrbz
wjpiogsvyfecjuqmnxaktprybz
wlpirgsvyfecjiqmnxaatdrhbz
bvpiogsvyfecjuqmnxaktdrhez
wlpiogsvyfxcjuqmnxykzdrhbz
wlkiwgsqyfecjqqmnxaktdrhbz
wepaogsvyfecjxqmnxaktdrhbz
wlpiovsvyfecjjqmnxaktdmhbz
wlpioysryfecjuqmnxaktdrhiz
wlpizjsvyfecjuvmnxaktdrhbz
dlpiogsvyfecjucmnxakbdrhbz
wlpiogsccfecjrqmnxaktdrhbz
wlpioggvyfecpuqmnxagtdrhbz
wlpiogsvyfvcjuumlxaktdrhbz
wwpiogsryfjcjuqmnxaktdrhbz
wlpiogsvyfecjuqynxaktdrogz
wlpiogsvyfecjpqmnxskbdrhbz
wlpiogsvyfecjuhmfxaktvrhbz
wlpiogevyfecjrqmnwaktdrhbz
wlpiigsvyfemjuqmnxaktdrhtz
wlpcogsvyfecjuqhnxakgdrhbz
wupiogsvyfxcjuqmnxaktdrhgz
wlsiogsvyfecjuqenxuktdrhbz
wlpioglvyfecjujmexaktdrhbz
wlriogsvyfeljuqmnxattdrhbz
wlpiogsvyfecfuqmhxaktkrhbz
wlppogsvyfecjuqmxxabtdrhbz
wlniogsvyfevjuqwnxaktdrhbz
wlhiogsvyfecjuqmnxactxrhbz
ilpiogivyflcjuqmnxaktdrhbz
wlpmogsvyfecjuqmnxaktdrlbs
wipiogsvyfeqjuqmnxaktrrhbz
wvpiogsvyfecjuqknxaktdrrbz
wwpioguvyfecxuqmnxaktdrhbz
wlpiogsvkfdcjuqmnxaktdzhbz
wlpiogfvyfecjuqmnxadtdrhbg
wlpiogsvyzefjuqfnxaktdrhbz
wlpiogstyfechuqmnxaktdchbz
wlpiogszyfedjuqmnxsktdrhbz
wzpiozsvyfncjuqmnxaktdrhbz
xlpiogsvyfefjuqmnmaktdrhbz
wlpiogsvyfebxummnxaktdrhbz
wlpiogsgyfecfurmnxaktdrhbz
wlpqogsvyfecjuomnxaktdrhbi
wlpiogjvufecjuqmnxaktdrhbd
wlpiolsvyfecduqmnxaktrrhbz
wlpxogsvyfecjuqmnxaktgrhbk
wlpiogsfyfncjuqmnxsktdrhbz
wlpioggvyfecjufmnxaktdrebz
wlpiogsvyfecfujmnxaktdrwbz
rlpiogsvyfecjlqmnxaktdqhbz
wlpfogsvyfecjuimnxaktfrhbz";

        public static int ExecuteChallengeOne()
        {
            return ComputeChallengeOneResult(CHALLENGE_INPUT);
        }

        public static int ComputeChallengeOneResult(string input)
        {
            string[] inputs = input.Split(Environment.NewLine);

            var twiceAndThreeTimes = inputs.Select(i => CountTwiceAndThreeTimes(i)).ToList();

            int[] twices = twiceAndThreeTimes.Select(t => t.Twice ? 1 : 0).ToArray();
            int[] threes = twiceAndThreeTimes.Select(t => t.ThreeTimes ? 1 : 0).ToArray();

            return twices.Sum() * threes.Sum();
        }

        public static int ComputeChallengeTwoResult(string input)
        {
            string[] inputs = input.Split(Environment.NewLine);

            foreach (string boxId in inputs)
            {
                // Same length boxIds 
                inputs
                    .Where(i => i.Length == boxId.Length)
                    .Where(i => i.ToCharArray().Intersect(boxId.ToCharArray()).Count() == boxId.Length - 1);

                if (inputs.Any(i => i.ToCharArray().Intersect(boxId.ToCharArray()).Count() == boxId.Length - 1))
                {

                }
            }
        }

        public static (bool Twice, bool ThreeTimes) CountTwiceAndThreeTimes(string input)
        {
            var lettersCount = input
                .ToCharArray()
                .GroupBy(c => c)
                .Select(g => new { Letter = g.Key, Count = g.Count() })
                .ToList();

            bool twice = lettersCount.Any(lc => lc.Count == 2);
            bool threeTimes = lettersCount.Any(lc => lc.Count == 3);

            return (Twice: twice, ThreeTimes: threeTimes);
        }
    }
}
