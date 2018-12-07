﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventCalendar2018
{

    public static class DayOne
    {
        private const string CHALLENGE_INPUT = @"-8
-13
+17
+7
+12
-18
+19
+14
-19
+16
-10
-16
-16
-8
-7
+19
+10
-12
+18
+13
-20
-7
-3
-2
-6
-7
+5
-16
+2
-9
+10
-13
-18
+9
+18
-10
-10
+6
-7
-19
-10
+5
+4
+9
+17
+3
-18
-12
-10
+14
+2
+12
+11
+9
-18
+17
-11
-3
+2
+10
+9
+20
+7
+16
+2
-1
-13
-10
-15
+24
+17
+11
+4
+19
+1
+16
-15
-12
-2
+11
+15
+14
-18
+9
+13
-17
-9
-1
+17
-19
-19
+23
-3
+8
-14
-6
+5
-8
-2
+4
-11
-5
+18
+2
+18
+12
+19
+6
-14
-1
-4
+15
+17
-4
-20
-15
+5
+18
-13
-1
+15
+18
+7
+14
+12
+16
-8
+7
+15
-19
-16
-15
-5
-10
+6
+12
+1
-7
+1
+14
+11
-1
-15
+3
+14
-11
-17
-6
-4
+16
-9
+12
+9
+18
+16
+5
+10
+16
+12
+16
-5
+15
+9
+7
+6
-19
+7
+16
+15
+4
-3
+1
-10
+16
-9
+19
+2
+2
+10
-7
-14
-14
-2
-7
-18
-23
+18
+15
+3
+1
-12
+7
-18
+6
-7
-12
-12
-7
-4
-11
-2
+3
+12
+11
-18
+17
-7
-19
+12
+12
+7
+13
-10
+5
-18
-8
+7
+10
+15
+7
+10
-7
-13
-14
+19
-7
+23
-10
-21
+3
-6
-30
+7
+2
-22
-4
+8
+17
-15
+25
-2
+8
+18
+2
+23
-20
+19
+20
-2
+4
-16
+7
-11
+15
+13
+8
+3
+14
-3
-4
-11
+2
-6
-22
+4
+16
+5
+4
+18
+7
+16
-14
-13
+10
+10
+12
+1
+12
+3
+4
+12
+3
+2
+16
-12
-11
+19
-6
+8
+11
+20
-17
-11
-14
-19
+8
-3
-16
+13
-8
-18
-7
-16
-10
+11
-2
-14
-2
+19
+18
+8
-4
+9
+17
+12
+12
+2
-19
+3
+10
-16
+17
-18
-10
+16
+9
+18
+14
-1
-14
+12
-19
+9
-6
-17
-26
-21
+13
-17
+2
-18
+21
-7
-3
+32
-5
-16
+3
-16
-15
+2
-24
+40
+16
-22
+26
-19
+22
-20
-25
-20
-13
+20
+57
+14
+6
+22
+17
-7
-18
+30
+16
+12
-22
+5
-1
+4
-6
-31
-38
+10
+4
+85
+8
-10
+8
+6
-5
-8
+36
+9
+19
-1
+18
+15
+9
+21
+11
-7
-15
+10
+20
-4
-19
+16
-11
-4
+11
+6
+13
+3
+7
+20
+15
+13
-10
+9
+3
-11
+6
+12
+1
+5
-2
+11
+3
-16
-19
-10
-12
+8
+20
-2
-22
-10
-5
+12
-9
+24
+7
-13
-26
-29
-8
+19
-4
-4
-46
-26
-17
+20
-17
-36
-5
-18
+21
+8
-1
+32
+7
+18
+27
+2
+4
-9
+8
-17
+48
+4
+6
+28
+14
-4
+15
+1
+24
-14
+2
+11
+15
-16
+3
+62
+15
-253
-12
-27
-111
+196
+70135
-1
+17
+13
+8
-17
-13
-11
-4
-9
-13
+1
-8
-14
+10
-3
-2
+15
+8
-1
+2
+4
-1
+6
-7
+17
+4
-17
+19
+1
+5
-19
-18
-11
+14
-13
+2
-16
+9
-5
+16
-13
-9
-3
+8
+2
+7
-19
-2
+6
-9
-12
+11
+7
-12
-18
-3
+5
-6
+20
+3
-11
-13
+3
-12
-15
-7
+10
-2
+20
+13
-1
-3
+16
-18
-5
+15
+5
-4
+3
-2
+4
+7
+24
+9
+26
-4
+17
+2
-17
-12
-5
+24
+4
+16
-4
+7
+7
+20
+1
-5
+16
-17
-13
+3
-14
+12
+7
-13
-15
+3
+13
+19
-6
-7
-9
+17
+1
-17
-19
+17
-11
+4
+2
+10
+25
-5
+20
-14
+9
+3
+11
-15
+18
-16
+12
+15
-10
+3
-12
+17
+11
-4
+3
-11
+16
+2
-4
-7
+19
-13
+4
-18
-14
-17
-4
+7
+11
+8
+16
+14
-15
-1
+19
+15
+7
+11
+13
-3
+1
-16
-19
-8
+9
-12
-19
-7
+15
+9
+3
+15
-10
+19
-5
+11
+9
-3
+1
-12
-8
-10
+5
+2
-1
+18
-10
+21
+17
+18
-16
+6
-5
-16
+18
+6
+16
-3
-9
+7
+19
-15
+9
-6
-8
+10
+20
+4
-2
-8
-9
+4
+12
-14
+10
+2
-11
-7
+1
-13
+8
+9
-3
+10
+5
-6
-1
+19
+2
+20
+3
+11
-8
-7
+3
-12
+4
+11
-14
+17
+16
+7
+10
+17
-3
+1
+1
-7
+11
+18
+8
-3
-10
+15
-9
+6
-8
-9
+16
-17
+9
+6
+5
+8
+11
+12
-17
-9
+12
+13
+6
-8
+14
-17
-5
+9
+16
+3
-8
+12
+14
-19
-3
-11
-10
-10
+3
+22
-12
-19
+14
-6
-12
+1
-19
+8
+13
+4
-23
-3
+10
-20
+14
-11
-2
-16
-5
-16
-8
+1
-7
+4
+5
-10
-14
-14
-10
+9
-18
+10
+19
-6
-2
+16
+16
-4
+21
+12
-14
+22
+13
-19
-5
+2
-17
+21
-11
-9
-20
-2
-15
-4
+7
-6
-5
-3
-6
+11
+10
-17
-8
+6
-1
-29
-21
+5
-7
-16
-1
-14
+20
+10
+10
-3
-1
-20
+12
-9
+3
+1
-10
-15
-5
-2
+6
-24
-15
-21
-3
-12
-9
+7
+10
-20
-19
-1
+22
+12
+5
-3
+14
-42
+4
+13
-9
+46
+19
+3
+11
+2
+30
-12
+29
+13
-41
+15
-13
-16
-9
+20
-35
-27
-100
+1
+2
+7
-1
-29
+8
-40
-1
-13
-24
-3
-21
+2
-22
+16
+14
+22
-3
+5
-17
+11
+19
-28
+54
+6
-10
-3
+10
+19
-135
-31
-19
-10
-6
+18
+18
-15
+12
+14
-7
-9
-5
-7
+10
+20
+13
-2
-4
-1
-32
-12
+84
+42
+36
-106
+26
-61
+16
+48
-102
-64
-16
+18
-25
+31
+309
+24
+178
+70218
-8
-2
-18
+1
+18
+3
-15
-1
-11
+17
+2
+11
-9
+11
-6
+2
-8
+11
-16
-16
-5
-2
+1
+4
-12
+17
-11
+4
-12
-7
+12
-4
-2
-16
-140560";

        public static int ExecuteChallengeOne()
        {
            return ComputeChallengeOneResult(CHALLENGE_INPUT);
        }

        public static int ExecuteChallengeTwo()
        {
            return ComputeChallengeTwoResult(CHALLENGE_INPUT);
        }

        public static int ComputeChallengeOneResult(string input)
        {
            return InputToFrequencyChanges(input).Sum();
        }

        public static int ComputeChallengeTwoResult(string input)
        {
            List<int> reachedFrequencies = new List<int>();
            List<int> frequencyChanges = InputToFrequencyChanges(input).ToList();

            int currentFrequency = 0;
            int cursor = 0;

            do
            {
                reachedFrequencies.Add(currentFrequency);
                currentFrequency += frequencyChanges[cursor % frequencyChanges.Count];

                cursor++;
            } while (!reachedFrequencies.Contains(currentFrequency));

            return currentFrequency;
        }

        private static int[] InputToFrequencyChanges(string input)
        {
            string[] inputs;
            if (input.Contains(','))
            {
                inputs = input.Split(',');
            }
            else
            {
                inputs = input.Split(Environment.NewLine);
            }

            int[] intInputs = inputs.Select(inp => int.Parse(inp)).ToArray();

            return intInputs;
        }
    }
}
