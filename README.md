The simple library that recognizes mouse gestures

Based on http://www.bytearray.org/?p=91

* Each letter is defined by a n ' 8-directions gesture sequence
* The mouse moves are saved with the same 8-directions sensibility
* A Levenshtein distance is calculated from each letter to the user moves
* The algorithm return the best candidate (lowest levenshtein cost)
