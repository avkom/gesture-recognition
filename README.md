The simple library that recognizes mouse gestures

Based on http://www.bytearray.org/?p=91

* Each letter is defined by a n ' 8-directions gesture sequence
* The mouse moves are saved with the same 8-directions sensibility
* A Levenshtein distance is calculated from each letter to the user moves
* The algorithm return the best candidate (lowest levenshtein cost)

![image](https://cloud.githubusercontent.com/assets/26693746/25807457/91552acc-340f-11e7-9633-8017a1996b2a.png)
