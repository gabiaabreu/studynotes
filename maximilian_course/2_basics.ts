/*

2. BASICS: Variables, operators, data types & functions

JS code can be called inside .html files, in the tag <script> JS code </script>
or using <script src="/path/to/script.js"> (you can place several of those if you want)
OBS: code gets executed from top to bottom. The place you put it matters!

* VARIABLES
Variable naming: use camelCase in most cases
human-readable and meaningful names
keep it clean without special characters (excluding $ and _, which can be used)
when naming hard-coded values, you could also go for something like: 
*/

const COLOR_RED: string = "#ff0000";

/*

OBS: don't name consts like that when their value is unknown at first.

'var' isn't used anymore. Always go for 'let' or 'const'.

* OPERATORS 
+, -, *, /, %, **
= is an assignment operator, not a comparison one

typeof operator returns the type of something
some special events:
typeof Math is "object" (a built-in object for math operations)
typeof null is "object" (it's an error. null is not an object.)

* DATA TYPES
1. NUMBER: integer or float
! special numeric values: Infinity, -Infinity, NaN

*/

const myInfinity: number = (1 / 0);
const directInfinity: number = Infinity;

const alsoNaN: number = 3 * NaN;
const one: number = NaN ** 0;

/*
yes, NaN ^ 0 is 1!

const myNaN: number = ("word" / 2);
typescript won't even let me do that, as it prevents this kind of thing
also, doing any kind of math is safe on JS. it won't crash.

2. BIGINT: for values bigger than 9007199254740991, positive or negative
number type could even store them, but as an approximate value.

you could declare a BigInt like that, with the 'n' on the end:
*/

const bigNumber: BigInt = 1234567890123456789012345678901234567890n;

/*

3. STRING: "hi", 'hi' or `hi`
there's no character type in JS (like char in C or Java)

*/

const word: string = 'nice';
`interpolation is a ${word} feature for strings`

/*

4. BOOLEAN: true XOR false (it's an exclusive or)
they can come as a result of a comparison.

5. NULL: it's its own type.
a special value for: nothing. emptiness.

6. UNDEFINED: also its own type.
it means "value not assigned". it's the default initial value for unassigned things

7. OBJECT: a remarkable type. this one isn't primitive like the others.
objects are used to store collections of data.

8. SYMBOL: is used to create unique identifiers for objects. yes it's a type!

*/


